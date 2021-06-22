using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Register_Management_System
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void AttendanceTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void AttendanceTXT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                AttendanceTXT.Text = String.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = AttendanceTXT;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
