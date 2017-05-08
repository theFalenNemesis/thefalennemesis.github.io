using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowler_Reservation_Database
{
    public partial class editForm : Form
    {
        mainForm mForm = new mainForm();
        public editForm()
        {
            InitializeComponent();
        }

        public editForm(string lastName, string firstName, string companyName, string league, string phone, 
            string email, string address, string emContact, string emPhone, string type, string resDate, string childsName, 
            string childsAge, string specialNotes)
        {
            InitializeComponent();
            lastNameTextBox.Text = lastName;
            firstNameTextBox.Text = firstName;
            companyNameTextBox.Text = companyName;
            leagueComboBox.SelectedIndex = leagueComboBox.FindStringExact(league);
            phoneTextBox.Text = phone;
            emailTextBox.Text = email;
            addressTextBox.Text = address;
            emContactTextBox.Text = emContact;
            emPhoneTextBox.Text = emPhone;            
            typeComboBox.SelectedIndex = typeComboBox.FindStringExact(type);
            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "MM/dd/yyyy";
            if (resDate != "")
            {
                try
                {
                    reservationDateTime.Value = DateTime.ParseExact(resDate, format, provider);
                }
                catch
                {
                    MessageBox.Show("Error importing date.");
                }
            }
            
            childsNameTextBox.Text = childsName;
            childsAgeTextBox.Text = childsAge;
            specialNotesTextBox.Text = specialNotes;
            

        }

        private void editForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = saveEntryButton;
            this.CancelButton = cancelButton;
            reservationDateTime.Enabled = false;
        }

        private void resDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (resDateCheckBox.Checked == true)
            {
                reservationDateTime.Enabled = true;
            }
            else
            {
                reservationDateTime.Enabled = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveEntryButton_Click(object sender, EventArgs e)
        {
            mainForm.lastName = lastNameTextBox.Text;
            mainForm.firstName = firstNameTextBox.Text;
            mainForm.companyName = companyNameTextBox.Text;
            mainForm.league = "";
            if (leagueComboBox.SelectedIndex > -1)
            {
                mainForm.league = leagueComboBox.SelectedItem.ToString();
            }
            mainForm.phone = phoneTextBox.Text;
            mainForm.email = emailTextBox.Text;
            mainForm.address = addressTextBox.Text;
            mainForm.emContact = emContactTextBox.Text;
            mainForm.emPhone = emPhoneTextBox.Text;
            mainForm.type = "";
            if (typeComboBox.SelectedIndex > -1)
            {
                mainForm.type = typeComboBox.SelectedItem.ToString();
            }
            mainForm.resDate = "";
            if (reservationDateTime.Enabled == true)
            {
                mainForm.resDate = reservationDateTime.Value.ToShortDateString();
            }
            mainForm.childsName = childsNameTextBox.Text;
            mainForm.childsAge = "";
            if (childsAgeTextBox.Enabled == true)
            {
                int parsedValue;
                if (int.TryParse(childsAgeTextBox.Text, out parsedValue))
                {
                    mainForm.childsAge = parsedValue.ToString();
                }
            }
            mainForm.specialNotes = specialNotesTextBox.Text;

            this.Close();
        }

        private void companyNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void leageLabel_Click(object sender, EventArgs e)
        {

        }

        private void resDateCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (resDateCheckBox.Checked == true)
            {
                reservationDateTime.Enabled = true;
            }
            else
            {
                reservationDateTime.Enabled = false;
            }
        }
    }
}
