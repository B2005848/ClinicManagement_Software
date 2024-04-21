using System;
using System.Data;
using System.Data.SqlClient;

namespace project_gr
{
    public static class DatabaseManager
    {
        private static SqlConnection conn;

        public static bool OpenConnection()
        {
            try
            {

                conn = new SqlConnection("Data Source=NIGHTMARE\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;Encrypt=False");
                conn.Open();
                Console.WriteLine("Connected to database.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect to database: " + ex.Message);
                return false;
            }
        }

        public static bool CloseConnection()
        {
            try
            {
                conn.Close();
                Console.WriteLine("Connection closed.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while closing connection: " + ex.Message);
                return false;
            }
        }


        //FOR ADMIN
        public static bool CheckAdminLogin(string username, string password)
        {
            try
            {
                if (!OpenConnection()) // Mở kết nối đến cơ sở dữ liệu
                {
                    Console.WriteLine("Failed to open connection.");
                    return false;
                }

                string query = "SELECT COUNT(*) FROM Employees WHERE username = @Username AND password = @Password AND role_id = 1;";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while checking admin login: " + ex.Message);
                return false;
            }
        }


        //FOR PATIENT
        //get quantity patient
        public static String? GetQuantity_patient()
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return null;
                }

                String query = "SELECT COUNT(patient_id) as Quantity FROM Patients;";
                using SqlCommand command = new(query, conn);

                int count = (int)command.ExecuteScalar();
                return count.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("Error while get quantity of patients");
            }
            return null;
        }

        //show list patient
        public static DataTable? getListPatients()
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open");
                    return null;
                }
                string query = @"
          SELECT 
                ROW_NUMBER() OVER (ORDER BY patient_id) AS No, 
                patient_id,
                citizen_id,
                name,
                age,
                    CASE 
                    WHEN gender = 0 THEN N'Nữ'
                    WHEN gender = 1 THEN N'Nam'
                END AS gender_text,
                address,
                phone
            FROM 
                patients";
                using SqlCommand command = new(query, conn);
                DataTable dataTable = new();
                using SqlDataAdapter adapter = new(command);
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while getting list patients: " + ex.Message);
                return null;
            }
        }


        //Get info patient by patient_id
        public static DataSet GetPatientDetails(int patientId)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open");
                    return null;
                }

                DataSet dataSet = new();

                //Query for info patient
                string queryPersonalInfo = @"
            SELECT 
                P.patient_id,
                P.citizen_id,
                P.name,
                P.other_details,
                P.age,
                CASE 
                    WHEN P.gender = 0 THEN N'Nữ'
                    WHEN P.gender = 1 THEN N'Nam'
                END AS gender_text,
                P.address,
                P.phone
            FROM 
                Patients AS P
            WHERE
                P.patient_id = @patientId";

                using (SqlCommand commandPersonalInfo = new(queryPersonalInfo, conn))
                {
                    commandPersonalInfo.Parameters.AddWithValue("@patientId", patientId);
                    SqlDataAdapter adapterPersonalInfo = new(commandPersonalInfo);
                    adapterPersonalInfo.Fill(dataSet, "PersonalInfo");
                }


                //Query for group of patient
                string queryGroupInfo = @"
            SELECT 
                PG.group_name
            FROM 
                PatientGroupAssignments AS PGA
            JOIN 
                PatientGroups AS PG ON PGA.group_id = PG.group_id
            WHERE
                PGA.patient_id = @patientId";

                using (SqlCommand commandGroupInfo = new(queryGroupInfo, conn))
                {
                    commandGroupInfo.Parameters.AddWithValue("@patientId", patientId);
                    SqlDataAdapter adapterGroupInfo = new SqlDataAdapter(commandGroupInfo);
                    adapterGroupInfo.Fill(dataSet, "GroupInfo");
                }


                //Query for Appointments of patient
                string queryAppointments = @"
            SELECT 
                A.appointment_datetime,
                A.status,
                EMP.name,
	            EMP.employee_id
            FROM 
                Appointments AS A
            JOIN 
	            Employees AS EMP ON EMP.employee_id = A.doctor_id   
            WHERE
                A.patient_id = @patientId";

                using (SqlCommand commandAppointments = new(queryAppointments, conn))
                {
                    commandAppointments.Parameters.AddWithValue("@patientId", patientId);
                    SqlDataAdapter adapterAppointments = new SqlDataAdapter(commandAppointments);
                    adapterAppointments.Fill(dataSet, "Appointments");
                }


                //Query for medical record
                string queryMedical = @"
            SELECT diagnosis 
            FROM
                MedicalRecords 
            WHERE
                patient_id = @patientId";

                using (SqlCommand commandMedical = new(queryMedical, conn))
                {
                    commandMedical.Parameters.AddWithValue("@patientId", patientId);
                    SqlDataAdapter adapterAppointments = new SqlDataAdapter(commandMedical);
                    adapterAppointments.Fill(dataSet, "Medical_Record");
                }

                return dataSet;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while getting patient details: " + ex.Message);
                return null;
            }
        }



        //Get list group patients
        public static DataTable? getListGroupPatients()
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return null;
                }

                string query = "SELECT * FROM PatientGroups;";

                using SqlCommand command = new(query, conn);

                DataTable dataTable = new();

                using SqlDataAdapter adapter = new(command);
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while getting list of groups: " + ex.Message);
                return null;
            }
        }


        //Add a new patient
        public static bool AddNewPatientAndAssignGroups(string name, string citizen_id, DateTime age, char gender, string address, string phone, string otherDetails, List<int> groupIds)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return false;
                }

                string insertPatientQuery = @"INSERT INTO Patients (name, citizen_id, age, gender, address, phone, other_details)
                                      VALUES (@Name, @Citizen_id, @Age, @Gender, @Address, @Phone, @OtherDetails);
                                      SELECT SCOPE_IDENTITY() AS new_id;";

                using SqlCommand insertPatientCommand = new(insertPatientQuery, conn);
                insertPatientCommand.Parameters.AddWithValue("@Name", name);
                insertPatientCommand.Parameters.AddWithValue("@Citizen_id", citizen_id);
                insertPatientCommand.Parameters.AddWithValue("@Age", age);
                insertPatientCommand.Parameters.AddWithValue("@Gender", gender);
                insertPatientCommand.Parameters.AddWithValue("@Address", address);
                insertPatientCommand.Parameters.AddWithValue("@Phone", phone);
                insertPatientCommand.Parameters.AddWithValue("@OtherDetails", otherDetails);

                int newPatientId = Convert.ToInt32(insertPatientCommand.ExecuteScalar());

                foreach (int groupId in groupIds)
                {
                    string assignGroupQuery = @"INSERT INTO PatientGroupAssignments (patient_id, group_id)
                                            VALUES (@PatientId, @GroupId);";

                    using SqlCommand assignGroupCommand = new(assignGroupQuery, conn);
                    assignGroupCommand.Parameters.AddWithValue("@PatientId", newPatientId);
                    assignGroupCommand.Parameters.AddWithValue("@GroupId", groupId);
                    assignGroupCommand.ExecuteNonQuery();
                }
                Console.WriteLine("Patient added successfully");
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while adding new patient and assigning groups: " + ex.Message);
                return false;
            }
        }

        //Delete a patient by ID
        public static bool DeletePatient(int patientId)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return false;
                }

                string deletePatientQuery = "DELETE FROM PatientGroupAssignments WHERE patient_id = @PatientId;" +
                    "DELETE FROM Appointments where patient_id = @PatientId;" +
                    "DELETE FROM MedicalRecords where patient_id = @PatientId;" +
                    "DELETE FROM Patients WHERE patient_id = @PatientId";

                using SqlCommand deletePatientCommand = new SqlCommand(deletePatientQuery, conn);
                deletePatientCommand.Parameters.AddWithValue("@PatientId", patientId);

                int rowsAffected = deletePatientCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while deleting patient: " + ex.Message);
                return false;
            }
        }


        //Upadate infomation of patient include (basic info and group _patient)
        public static bool UpdatePatientInformation(int patientId, string name, string citizenId, DateTime age, string gender, string address, string phoneNumber, String other_detail, List<string> selectedGroups)
        {

            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return false;
                }
                string updatePatientQuery = "UPDATE Patients SET name = @Name, citizen_id = @CitizenId, age = @Age, gender = @Gender, address = @Address, other_details = @OtherInfo, phone = @PhoneNumber WHERE patient_id = @PatientId";
                Console.WriteLine("Executing SQL query: " + updatePatientQuery);

                using SqlCommand command = new(updatePatientQuery, conn);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@CitizenId", citizenId);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@OtherInfo", other_detail);
                command.Parameters.AddWithValue("@PatientId", patientId);


                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    string deleteGroupsQuery = "DELETE FROM PatientGroupAssignments WHERE patient_id = @PatientId";
                    using (SqlCommand deleteCommand = new(deleteGroupsQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@PatientId", patientId);
                        deleteCommand.ExecuteNonQuery();
                    }

                    string insertGroupQuery = "INSERT INTO PatientGroupAssignments (patient_id, group_id) VALUES (@PatientId, @GroupId)";
                    foreach (string groupName in selectedGroups)
                    {
                        int groupId = GetGroupIdByName(groupName);

                        using SqlCommand insertCommand = new(insertGroupQuery, conn);
                        insertCommand.Parameters.AddWithValue("@PatientId", patientId);
                        insertCommand.Parameters.AddWithValue("@GroupId", groupId);
                        insertCommand.ExecuteNonQuery();
                    }
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return false;
        }



        //get id group by name
        private static int GetGroupIdByName(string groupName)
        {
            int groupId = -1;

            string query = "SELECT group_id FROM PatientGroups WHERE group_name = @GroupName";


            using SqlCommand command = new(query, conn);
            command.Parameters.Add("@GroupName", SqlDbType.NVarChar).Value = groupName;

            try
            {
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    groupId = Convert.ToInt32(result);
                    Console.WriteLine("Group ID for group name " + groupName + " is: " + groupId);

                }
                Console.WriteLine("Group ID not found for group name: " + groupName);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            return groupId;
        }

        //FOR APPOINTMENT

        //Get slottime for clinic
        public static DataTable GetAvailableTimeSlots()
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return null;
                }

                string query = "SELECT * FROM AvailableTimeSlots;";

                using (SqlCommand command = new(query, conn))
                {
                    DataTable dataTable = new();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while getting available time slots: " + ex.Message);
                return null;
            }
        }

        //Get info slot time clinic to show Form+New+Patinet interface
        public static DataTable GetInfoSlottime(int slot_Id)
        {
            DataTable dataTable = new();

            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return null;
                }

                string query = "SELECT * FROM AvailableTimeSlots WHERE slot_id = @slot_Id";
                using (SqlCommand command = new(query, conn))
                {
                    command.Parameters.AddWithValue("@slot_Id", slot_Id);

                    using (SqlDataAdapter adapter = new(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }

            return dataTable;
        }

        //get doctor by specialization_id
        public static DataTable GetDoctorsByPatientGroups(List<int> groupIds)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return null;
                }

                DataTable doctorDataTable = new();

                string query = @"
                    SELECT 
                        DISTINCT EMP.name AS DoctorName,
                        EMP.employee_id AS DoctorId
                    FROM 
                        Employees AS EMP
                    JOIN 
                        DoctorSpecializations AS DS ON EMP.employee_id = DS.doctor_id
                    JOIN 
                        PatientGroups AS PG ON DS.specialization_id = PG.group_id
                    WHERE
                        PG.group_id IN ({0});";

                List<string> paramNames = new List<string>();
                for (int i = 0; i < groupIds.Count; i++)
                {
                    string paramName = "@GroupId" + i;
                    paramNames.Add(paramName);
                    query = query.Replace("{" + i + "}", paramName);
                }

                using (SqlCommand command = new(query, conn))
                {
                    for (int i = 0; i < groupIds.Count; i++)
                    {
                        //add id gr to query such as @groupId0, 1, 2
                        command.Parameters.AddWithValue(paramNames[i], groupIds[i]);
                    }

                    using (SqlDataAdapter adapter = new(command))
                    {
                        adapter.Fill(doctorDataTable);
                    }
                }

                return doctorDataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while getting doctors by patient groups: " + ex.Message);
                return null;
            }
        }


        //Booking appointment
        public static bool BookAppointment(int patientId, int slotId, int doctorId, DateTime appointmentDateTime, string notes)
        {
            try
            {
                //check appoint exits
                string checkQuery = @"SELECT COUNT(*) FROM Appointments WHERE slot_id = @slotId AND appointment_datetime 
                                    BETWEEN DATEADD(minute, -30, @appointmentDateTime) AND DATEADD(minute, 30, @appointmentDateTime)";
                SqlCommand checkCommand = new(checkQuery, conn);
                checkCommand.Parameters.AddWithValue("@slotId", slotId);
                checkCommand.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);
                int existingAppointmentsCount = (int)checkCommand.ExecuteScalar();

                if (existingAppointmentsCount > 0)
                {
                    MessageBox.Show("Lịch hẹn cho thời gian này đã tồn tại.");
                    return false;
                }

                string insertQuery = @"INSERT INTO Appointments (patient_id, slot_id, doctor_id, appointment_datetime, notes, status) 
                                        VALUES (@patientId, @slotId, @doctorId, @appointmentDateTime, @notes, 'Chưa khám')";
                SqlCommand insertCommand = new(insertQuery, conn);
                insertCommand.Parameters.AddWithValue("@patientId", patientId);
                insertCommand.Parameters.AddWithValue("@slotId", slotId);
                insertCommand.Parameters.AddWithValue("@doctorId", doctorId);
                insertCommand.Parameters.AddWithValue("@appointmentDateTime", appointmentDateTime);
                insertCommand.Parameters.AddWithValue("@notes", notes);

                insertCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đặt lịch hẹn: " + ex.Message);
                return false;
            }
        }


        //get patient_id by name, citizne_id
        public static int GetPatientIdByNameAndCitizenId(string name, string citizenId)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return -1;
                }

                string query = "SELECT patient_id FROM Patients WHERE name = @Name AND citizen_id = @CitizenId";

                using (SqlCommand command = new(query, conn))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@CitizenId", citizenId);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        Console.WriteLine("Patient not found with name: " + name + " and citizen ID: " + citizenId);
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while getting patient ID by name and citizen ID: " + ex.Message);
                return -1;
            }
        }

        //get id_doctor by name
        public static int GetDoctorIdByName(string doctorName)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return -1;
                }

                string query = "SELECT employee_id FROM Employees WHERE name = @DoctorName";

                using (SqlCommand command = new(query, conn))
                {
                    command.Parameters.Add("@DoctorName", SqlDbType.NVarChar).Value = doctorName;

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        Console.WriteLine("Doctor not found with name: " + doctorName);
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while getting doctor ID by name: " + ex.Message);
                return -1;
            }
        }

        //get all schedule
        public static DataTable getAll_Schedule()
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return null;
                }


                string query = @"SELECT  
                                    ROW_NUMBER() OVER (ORDER BY appointment_id) AS No, pa.name, pa.patient_id, appointment_id, appointment_datetime, e.name as doctor_name, status
                                    FROM Appointments
                                    JOIN Patients pa ON pa.patient_id = Appointments.patient_id
                                    JOIN Employees e ON e.employee_id = Appointments.doctor_id";
                using (SqlCommand command = new(query, conn))
                {
                    DataTable dataTable = new();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while getting doctors by patient groups: " + ex.Message);
                return null;
            }
        }


        //get all medicine
        public static DataTable GetAllMedicines()
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return null;
                }

                string query = @"SELECT  ROW_NUMBER() OVER (ORDER BY medicine_id) AS No, * FROM Medicines";

                using SqlCommand command = new(query, conn);
                DataTable dataTable = new();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Error while getting medicines: " + ex.Message);
                return null;
            }
        }

    }

}





