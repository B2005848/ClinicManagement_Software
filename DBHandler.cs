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
                name,
                age,
                    CASE 
                    WHEN gender = 0 THEN N'Nữ'
                    WHEN gender = 1 THEN N'Nam'
                END AS gender_text,
                address,
               
                phone,
                other_details
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
        public static bool AddNewPatientAndAssignGroups(string name, DateTime age, char gender, string address, string phone, string otherDetails, List<int> groupIds)
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open.");
                    return false;
                }

                string insertPatientQuery = @"INSERT INTO Patients (name, age, gender, address, phone, other_details)
                                      VALUES (@Name, @Age, @Gender, @Address, @Phone, @OtherDetails);
                                      SELECT SCOPE_IDENTITY() AS new_id;";

                using SqlCommand insertPatientCommand = new(insertPatientQuery, conn);
                insertPatientCommand.Parameters.AddWithValue("@Name", name);
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

    }




}



