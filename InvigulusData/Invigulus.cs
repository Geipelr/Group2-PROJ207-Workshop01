using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvigulusData
{
    /// <summary>
    /// Class that establishes the connection to the Invigulus database
    /// Author: Robert Geipel
    /// </summary>
    public static class Invigulus
    {
        /*  Author: Robert Geipel 
         *  Date: 8/7/2020
         *  Purpose: Data base connection
         */

        // establishes the connection
        public static SqlConnection GetConnection()
        {
            string connectionString =
                @"Data Source=localhost\sqlexpress;Initial Catalog=Invigulus;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
