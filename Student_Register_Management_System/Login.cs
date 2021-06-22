using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Register_Management_System.Business_Layer;

namespace Student_Register_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LecturerBTN_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer();
            lecturer.Show();
        }

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void HoDBTN_Click(object sender, EventArgs e)
        {
            HoD hod = new HoD();
            hod.Show();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            LoginClass login = new LoginClass(double.Parse(userTxt.Text), loginTxt.Text);
            login.GetRole();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = testxt;
            this.AcceptButton = this.LecturerBTN;
        }
    }
}
