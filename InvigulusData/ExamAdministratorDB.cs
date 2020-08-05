using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvigulusData
{
    public static class ExamAdministratorDB
    {
        public static List<ExamAdministrator> GetAdministrators()
        {
            // contains all the Ids
            List<ExamAdministrator> admins = new List<ExamAdministrator>();
            // for each retrieved line from db
            ExamAdministrator admin;
             
            // create connection
            using (SqlConnection connection = Invigulus.GetConnection())
            {
                // create SELECT command
                string query = "SELECT DISTINCT AdministratorID, u.UserID, LastName, FirstName, Email, InstitutionName FROM  Exam ex " +
                               "RIGHT JOIN ExamAdministrator adm ON ex.Administrator = adm.AdministratorID " +
                               "INNER JOIN _User u ON adm.UserID = u.UserID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    // execute the command and process results
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            admin = new ExamAdministrator();
                            admin.AdministratorID = (int)dr["AdministratorID"];
                            admin.UserID = (int)dr["UserID"];
                            admin.FirstName = (string)dr["FirstName"];
                            admin.LastName = (string)dr["LastName"];
                            admin.Email = (string)dr["Email"];
                            admin.InstitutionName = (string)dr["InstitutionName"];
                            admins.Add(admin);
                        }

                    }// automatically data reader closes and gets  recycled
                }

            } // object automatically  closed and recycled

            return admins;

        }

        public static List<ExamAdministrator> GetInstitutions() {
            // contains all the Ids
            List<ExamAdministrator> institutions = new List<ExamAdministrator>();
            // for each retrieved line from db
            ExamAdministrator institution;

            // create connection
            using (SqlConnection connection = Invigulus.GetConnection()) {
                // create SELECT command
                string query = "SELECT DISTINCT InstitutionName FROM  ExamAdministrator " ;
                using (SqlCommand cmd = new SqlCommand(query, connection)) {
                    connection.Open();
                    // execute the command and process results
                    using (SqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read()) {
                            institution = new ExamAdministrator();
                            institution.InstitutionName = (string)dr["InstitutionName"];
                            institutions.Add(institution);
                        }

                    }// automatically data reader closes and gets  recycled
                }

            } // object automatically  closed and recycled

            return institutions;
        }
    }

    
}
