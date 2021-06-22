using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Student_Register_Management_System
{
    public class DataAccessLayer
    {
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbAdapter;
        private string connection;

        public DataAccessLayer()
        {
            connection = "Server=localhost; Initial Catalog = StudentManagementDB; Integrated Security = SSPI;";
            dbConnection = new SqlConnection(connection);

        }

        public string Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public DataTable GetRole(double staffID, string password)
        {
            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }
            DataTable dtRole = new DataTable();
            {
                dbCommand = new SqlCommand("sp_GetRole '" + staffID + "'" + password + "'", dbConnection);
                dbAdapter = new SqlDataAdapter(dbCommand);
                dbAdapter.Fill(dtRole);
                return dtRole;
            }
        }
    }
}
