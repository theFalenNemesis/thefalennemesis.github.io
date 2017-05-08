using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowler_Reservation_Database
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string password = "cc";
            
            string input = passwordTextBox.Text;

            if (password.Equals(input))
            {
                MessageBox.Show("Admin Privileges Active");
                mainForm.locked = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Password. Please Try Again.");
            }
            
        }

        private void Password_Load(object sender, EventArgs e)
        {
            this.AcceptButton = submitButton;
        }
    }
}
