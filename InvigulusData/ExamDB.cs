using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvigulusData
{
    ///<summary>
    ///Exam manager that deals with passing data between the form and the database
    ///Authors: Crystal Champion (Add and Delete methods)
    ///         Kevin Duong (Update and Get Exam methods)
    ///</summary>
    public static class ExamDB
    {
        //Get a list of exams from an administrator using their ID
        public static List<Exam> GetExamByAdmin(int adminID)
        {
            Exam exam;
            List<Exam> exams = new List<Exam>();

            // create connection
            using (SqlConnection connection = Invigulus.GetConnection())
            {
                // create SELECT command
                string query = "SELECT * FROM Exam WHERE Administrator = @AdminID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AdminID", adminID);
                    connection.Open();

                    // execute the command and process results
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            exam = new Exam();
                            exam.ExamID = Convert.ToInt32(dr["ExamID"]);
                            exam.Administrator = Convert.ToInt32(dr["Administrator"]);
                            exam.ExamName = dr["ExamName"].ToString();
                            exam.ExamURL = dr["ExamURL"].ToString();

                            //When Duration is received as null, set value to null
                            if (dr["Duration"] == DBNull.Value)
                                exam.Duration = null;
                            else //Duration is receieved as an int, set given value
                                exam.Duration = Convert.ToInt32(dr["Duration"]);

                            //When Attempts is received as null, set value to null
                            if (dr["PermittedAttempts"] == DBNull.Value)
                                exam.PermittedAttempts = null;
                            else //When Attempts is received as an int, set as given value
                                exam.PermittedAttempts = Convert.ToInt32(dr["PermittedAttempts"]);

                            exams.Add(exam);
                        }

                    }// automatically data reader closes and gets  recycled
                }

            } // object automatically  closed and recycled

            return exams;
        }

        //Add an exam to the databased using a passed in exam, return the created exam ID
        public static int AddExam(Exam exam)
        {
            int examID = 0;
            //Create connection
            using (SqlConnection connection = Invigulus.GetConnection())
            {
                //Create INSERT query
                string insertStat = "INSERT INTO Exam(Administrator, ExamName, Duration, ExamUrl, PermittedAttempts) " +
                    "OUTPUT inserted.ExamID " +
                    "VALUES(@Administrator, @ExamName, @Duration, @ExamUrl, @PermittedAttempts)";
                
                //Execute command and process results
                using (SqlCommand cmd = new SqlCommand(insertStat, connection))
                {
                    cmd.Parameters.AddWithValue("@Administrator", exam.Administrator);
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@ExamUrl", exam.ExamURL);

                    //Check if duration has a value
                    if (exam.Duration.HasValue)
                        cmd.Parameters.AddWithValue("@Duration", exam.Duration);
                    else
                        cmd.Parameters.AddWithValue("@Duration", DBNull.Value);

                    //Check if Attempts has a value
                    if (exam.PermittedAttempts.HasValue)
                        cmd.Parameters.AddWithValue("@PermittedAttempts", exam.PermittedAttempts);
                    else
                        cmd.Parameters.AddWithValue("@PermittedAttempts", DBNull.Value);
                    connection.Open();
                    examID = (int)cmd.ExecuteScalar();
                                //--reference--//
                    //exam.ExamName = lbl_examname2.Text;
                    //exam.Duration = Convert.ToInt32(txt_duration2.Text);
                    //exam.ExamURL = txt_url2.Text;
                    //exam.PermittedAttempts = Convert.ToInt32(txt_permattempt2.Text);
                }
            }
            return examID;
        }

        //Update an exam record in Exam table, returns bool of a successful update
        public static bool UpdateExam(Exam oldExam, Exam newExam)
        {
            bool success = true;
            using (SqlConnection connection = Invigulus.GetConnection())
            {
                //Update query string, making sure to that the old records are the same 
                //as the one in the database so that there's no concurrency errors
                string query = "UPDATE Exam " +
                                "SET Duration = @NewDuration, " +
                                    "ExamURL = @NewExamURL, " +
                                    "PermittedAttempts = @NewPermittedAttempts " +
                                "WHERE ExamID = @ExamID " +
                                    "AND Administrator = @Administrator " +
                                    "AND ExamName = @OldExamName " +
                                    "AND ExamURL = @OldExamURL ";

                //Check if duration has a value and change WHERE query based on that
                if (oldExam.Duration.HasValue) //Check for identical int value
                    query += "AND Duration = @OldDuration ";
                else                            //Check if it's null
                    query += "AND Duration IS NULL ";

                //Check if duration has a value and change WHERE query based on that
                if (oldExam.PermittedAttempts.HasValue) //Check for identical int value
                    query += "AND PermittedAttempts = @OldPermittedAttempts";
                else                                    //Check if it's null
                    query += "AND PermittedAttempts IS NULL ";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    //Set ID parameters
                    cmd.Parameters.AddWithValue("@ExamID", oldExam.ExamID);
                    cmd.Parameters.AddWithValue("@Administrator", oldExam.Administrator);
                    cmd.Parameters.AddWithValue("@OldExamURL", oldExam.ExamURL);

                    //Set old exam parameters
                    cmd.Parameters.AddWithValue("@OldExamName", oldExam.ExamName);

                    if (oldExam.Duration.HasValue) //Old duration is not null
                        cmd.Parameters.AddWithValue("@OldDuration", oldExam.Duration);

                    if (oldExam.PermittedAttempts.HasValue) //Old Attempts is not null
                        cmd.Parameters.AddWithValue("@OldPermittedAttempts", oldExam.PermittedAttempts);


                    //set new exam parameters
                    cmd.Parameters.AddWithValue("@NewExamURL", newExam.ExamURL);

                    if (newExam.Duration.HasValue) //New duration is not null
                        cmd.Parameters.AddWithValue("@NewDuration", newExam.Duration);
                    else                           //New duration is null
                        cmd.Parameters.AddWithValue("@NewDuration", DBNull.Value);

                    if (newExam.PermittedAttempts.HasValue) //New PermittedAttempts is not null
                        cmd.Parameters.AddWithValue("@NewPermittedAttempts", newExam.PermittedAttempts);
                    else                           //New PermittedAttempts is null
                        cmd.Parameters.AddWithValue("@NewPermittedAttempts", DBNull.Value);

                    //execute query
                    cmd.Connection.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count == 0) //check if record was not updated
                        success = false;
                }
            }
            return success;
        }

        //Delete an exam record by ID in Exam table
        public static void DeleteExam(int id)
        {
            // create connection
            using (SqlConnection connection = Invigulus.GetConnection())
            {
                // create DELETE command
                string query = "DELETE FROM Exam WHERE ExamID = @ExamID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    // execute the command and process results
                    cmd.Parameters.AddWithValue("@ExamID", id);
                    using (cmd)
                    {
                        cmd.ExecuteNonQuery();

                    }// automatically data reader closes and gets  recycled
                }

            } // object automatically  closed and recycled

        }
    }
}
