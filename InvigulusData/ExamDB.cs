using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvigulusData
{
    public static class ExamDB
    {
        /*  Authors: Kevin Duong/Robert Geipel 
         *  Date: 8/7/2020
         *  Purpose: Data access for exam related data
         */

        //Get an exam from the database using the examID
        public static Exam GetExamByID(int examID)
        {
            Exam exam = null;

            // create connection
            using (SqlConnection connection = Invigulus.GetConnection())
            {
                // create SELECT command
                string query = "SELECT * FROM Exam WHERE ExamID = @ExamID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExamID", examID);
                    connection.Open();

                    // execute the command and process results
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            exam = new Exam {
                                ExamID = Convert.ToInt32(dr["ExamID"]),
                                Administrator = Convert.ToInt32(dr["Administrator"]),
                                ExamName = dr["ExamName"].ToString(),
                                Duration = Convert.ToInt32(dr["Duration"]),
                                ExamURL = dr["ExamURL"].ToString(),
                                PermittedAttempts = Convert.ToInt32(dr["PermittedAttempts"])
                            };

                        }

                    }// automatically data reader closes and gets  recycled
                }

            } // object automatically  closed and recycled

            return exam;
        }

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
                            if (dr["Duration"] == DBNull.Value)
                                exam.Duration = null;
                            else
                                exam.Duration = Convert.ToInt32(dr["Duration"]);
                            exam.ExamURL = dr["ExamURL"].ToString();
                            exam.PermittedAttempts = Convert.ToInt32(dr["PermittedAttempts"]);
                            exams.Add(exam);
                        }

                    }// automatically data reader closes and gets  recycled
                }

            } // object automatically  closed and recycled

            return exams;
        }

        public static int AddExam(Exam exam)
        {
            int examID = 0;
            using (SqlConnection connection = Invigulus.GetConnection())
            {
                string insertStat = "INSERT INTO Exam(Administrator, ExamName, Duration, ExamUrl, PermittedAttempts) " +
                    "OUTPUT inserted.ExamID " +
                    "VALUES(@Administrator, @ExamName, @Duration, @ExamUrl, @PermittedAttempts)";
                using (SqlCommand cmd = new SqlCommand(insertStat, connection))
                {
                    cmd.Parameters.AddWithValue("@Administrator", exam.Administrator);
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);

                    //Check if duration has a value
                    if (exam.Duration.HasValue)
                        cmd.Parameters.AddWithValue("@Duration", exam.Duration);
                    else
                        cmd.Parameters.AddWithValue("@Duration", DBNull.Value);


                    cmd.Parameters.AddWithValue("@ExamUrl", exam.ExamURL);
                    cmd.Parameters.AddWithValue("@PermittedAttempts", exam.PermittedAttempts);
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
                                    "AND Duration = @OldDuration " +
                                    "AND ExamURL = @OldExamURL " +
                                    "AND PermittedAttempts = @OldPermittedAttempts";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    //Set ID parameters
                    cmd.Parameters.AddWithValue("@ExamID", oldExam.ExamID);
                    cmd.Parameters.AddWithValue("@Administrator", oldExam.Administrator);

                    //Set old exam parameters
                    cmd.Parameters.AddWithValue("@OldExamName", oldExam.ExamName);

                    if (oldExam.Duration.HasValue) //Old duration is not null
                        cmd.Parameters.AddWithValue("@OldDuration", oldExam.Duration);
                    else                           //New duration is null
                        cmd.Parameters.AddWithValue("@OldDuration", DBNull.Value);

                    cmd.Parameters.AddWithValue("@OldExamURL", oldExam.ExamURL);
                    cmd.Parameters.AddWithValue("@OldPermittedAttempts", oldExam.PermittedAttempts);

                    //set new exam parameters
                    cmd.Parameters.AddWithValue("@NewExamURL", newExam.ExamURL);

                    if (newExam.Duration.HasValue) //New duration is not null
                        cmd.Parameters.AddWithValue("@NewDuration", newExam.Duration);
                    else                           //New duration is null
                        cmd.Parameters.AddWithValue("@NewDuration", DBNull.Value);

                    cmd.Parameters.AddWithValue("@NewPermittedAttempts", newExam.PermittedAttempts);

                    //execute query
                    cmd.Connection.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count == 0) //check if record was not updated
                        success = false;
                }
            }
            return success;
        }

        public static void DeleteExam(int id)
        {

            // create connection
            using (SqlConnection connection = Invigulus.GetConnection())
            {

                // create SELECT command
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
