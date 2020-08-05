using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvigulusData
{
    public class ExamRegistrationDB
    {
        public static List<ExamRegistration> GetRegistrations(int examId)
        {
            // contains all the Ids
            List<ExamRegistration> registrations = new List<ExamRegistration>();
            // for each retrieved line from db
            ExamRegistration registration;

            // create connection
            using (SqlConnection connection = Invigulus.GetConnection())
            {
                // create SELECT command
                string query = "SELECT DISTINCT RegistrationID, ExamName, LastName, FirstName, Email, PhoneNum FROM Exam ex " +
                               "INNER JOIN Registration reg ON ex.ExamID = reg.ExamID " +
                               "INNER JOIN Examinee st ON reg.ExamineeID = st.ExamineeID " +
                               "INNER JOIN _User us ON us.UserID = st.UserID " +
                               "WHERE ex.ExamID = @ExamID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ExamID", examId);
                    connection.Open();
                    // execute the command and process results
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            registration = new ExamRegistration();
                            registration.RegistrationID = (int)dr["RegistrationID"];
                            registration.ExamName = (string)dr["ExamName"];
                            registration.FirstName = (string)dr["FirstName"];
                            registration.LastName = (string)dr["LastName"];
                            registration.Email = (string)dr["Email"];
                            registration.PhoneNum = (string)dr["PhoneNum"];
                            registrations.Add(registration);
                        }

                    }// automatically data reader closes and gets  recycled
                }

            } // object automatically  closed and recycled

            return registrations;
        }

    }
}
