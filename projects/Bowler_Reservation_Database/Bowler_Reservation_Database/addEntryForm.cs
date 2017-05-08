using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowler_Reservation_Database
{
    public partial class addEntryForm : Form
    {

        public addEntryForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveEntryButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string companyName = companyNameTextBox.Text;
            string league = "";
            if (leagueComboBox.SelectedIndex > -1)
            {
                league = leagueComboBox.SelectedItem.ToString();
            }
            string phone = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            string emContact = emContactTextBox.Text;
            string emPhone = emPhoneTextBox.Text;

            string type = "";
            if (typeComboBox.SelectedIndex > -1)
            {
                type = typeComboBox.SelectedItem.ToString();
            }

            string resDate = "";
            if (reservationDateTime.Enabled == true)
            {
                resDate = reservationDateTime.Value.ToString("MM/dd/yyyy");
            }
            else
            {
                resDate = "";
            }            

            string childsName = childsNameTextBox.Text;
            string childsAge = "";
            if(childsAgeTextBox.Enabled == true)
            {
                int parsedValue;
                if(int.TryParse(childsAgeTextBox.Text, out parsedValue))
                {
                    childsAge = parsedValue.ToString();
                }
            }
            
            string specialNotes = specialNotesTextBox.Text;

            try
            {
                
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BowlerDatabase.mdf;Integrated Security=True";
                string insertQuery = "INSERT INTO Bowlers (last_name,first_name,company_name,league,phone_number,email,address,em_contact,em_phone,type,reservation_date,childs_name,childs_age,special_notes) VALUES (@lastName,@firstName,@companyName,@league,@phone,@email,@address,@emContact,@emPhone,@type,@reservation,@childsName,@childsAge,@specialNotes)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@companyName", companyName);
                        cmd.Parameters.AddWithValue("@league", league);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@emContact", emContact);
                        cmd.Parameters.AddWithValue("@emPhone", emPhone);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@reservation", resDate);                        
                        cmd.Parameters.AddWithValue("@childsName", childsName);
                        cmd.Parameters.AddWithValue("@childsAge", childsAge);
                        cmd.Parameters.AddWithValue("@specialNotes", specialNotes);
                        cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                    
                }

            }
            catch
            {
                MessageBox.Show("There was an error adding the entry");
            }
            finally
            {
                
                this.Close();
            }
        }

        private void addEntryForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = saveEntryButton;
            this.CancelButton = cancelButton;
            reservationDateTime.Enabled = false;
            childsAgeTextBox.Enabled = false;
        }

        private void resDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(resDateCheckBox.Checked == true)
            {
                reservationDateTime.Enabled = true;
            }
            else
            {
                reservationDateTime.Enabled = false;
            }
        }

        private void childsNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(childsNameTextBox.Text))
            {
                childsAgeTextBox.Enabled = true;
            }
            else
            {
                childsAgeTextBox.Enabled = false;
            }
        }
    }
}
