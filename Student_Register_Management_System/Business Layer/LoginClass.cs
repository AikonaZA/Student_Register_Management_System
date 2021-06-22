using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Student_Register_Management_System.Business_Layer
{
    public class LoginClass
    {
        private double staffID;
        private string password;
        DataAccessLayer dal = new DataAccessLayer();

        public LoginClass() { }

        public double GetStaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string GetPassword
        {
            get { return password; }
            set { password = value; }
        }

        public LoginClass(double staffID, string password)
        {
            this.staffID = staffID;
            this.password = password;
        }

        public DataTable GetRole()
        {
            return dal.GetRole(staffID, password);
        }
    }
}
