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

                using (SqlCommand commandPersonalInfo = new (queryPersonalInfo, conn))
                {
                    commandPersonalInfo.Parameters.AddWithValue("@patientId", patientId);
                    SqlDataAdapter adapterPersonalInfo = new (commandPersonalInfo);
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

                using (SqlCommand commandGroupInfo = new (queryGroupInfo, conn))
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

                using (SqlCommand commandAppointments = new (queryAppointments, conn))
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


    }
}



