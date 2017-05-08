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
    public partial class mainForm : Form
    {
        
        public static string lastName = "";
        public static string firstName = "";
        public static string companyName = "";
        public static string league = "";
        public static string phone = "";
        public static string email = "";
        public static string address = "";
        public static string emContact = "";
        public static string emPhone = "";
        public static string type = "";
        public static string resDate = "";        
        public static string childsName = "";
        public static string childsAge = "";
        public static string specialNotes = "";
        public static Boolean locked;

        public mainForm()
        {
            InitializeComponent();
            this.bowlersDataGridView.CellClick += new DataGridViewCellEventHandler(this.bowlersDataGridView_CellClick);
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            if (locked == false)
            {
                sendEmail sEmail = new sendEmail();
                sEmail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Admin Priveleges Required");
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            if(locked == false)
            {
                addEntryForm aeForm = new addEntryForm();
                aeForm.ShowDialog();
                this.bowlersTableAdapter.Fill(this.bowlerDatabaseDataSet.Bowlers);
            }
            else
            {
                MessageBox.Show("Admin Priveleges Required");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.bowlersTableAdapter.Search(this.bowlerDatabaseDataSet.Bowlers, searchTextBox.Text);
        }

        private void bowlersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bowlersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bowlerDatabaseDataSet);

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bowlerDatabaseDataSet.Bowlers' table. You can move, or remove it, as needed.
            this.bowlersTableAdapter.Fill(this.bowlerDatabaseDataSet.Bowlers);
            this.AcceptButton = searchButton;
            this.CancelButton = exitButton;
            locked = true;

        }

        private void bowlersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (locked == false)
            {
                int rowId = -1;
                if (bowlerDatabaseDataSet.Tables[0].Rows.Count > 0)
                {
                    rowId = bowlersDataGridView.CurrentCell.RowIndex;

                    lastName = bowlersDataGridView.Rows[rowId].Cells[0].Value.ToString();
                    firstName = bowlersDataGridView.Rows[rowId].Cells[1].Value.ToString();
                    companyName = bowlersDataGridView.Rows[rowId].Cells[2].Value.ToString();
                    league = bowlersDataGridView.Rows[rowId].Cells[3].Value.ToString();
                    phone = bowlersDataGridView.Rows[rowId].Cells[4].Value.ToString();
                    email = bowlersDataGridView.Rows[rowId].Cells[5].Value.ToString();
                    address = bowlersDataGridView.Rows[rowId].Cells[6].Value.ToString();
                    emContact = bowlersDataGridView.Rows[rowId].Cells[7].Value.ToString();
                    emPhone = bowlersDataGridView.Rows[rowId].Cells[8].Value.ToString();
                    type = bowlersDataGridView.Rows[rowId].Cells[9].Value.ToString();
                    resDate = bowlersDataGridView.Rows[rowId].Cells[10].Value.ToString();
                    childsName = bowlersDataGridView.Rows[rowId].Cells[11].Value.ToString();
                    childsAge = bowlersDataGridView.Rows[rowId].Cells[12].Value.ToString();
                    specialNotes = bowlersDataGridView.Rows[rowId].Cells[13].Value.ToString();

                    editForm eForm = new editForm(lastName, firstName, companyName, league, phone, email, address,
                        emContact, emPhone, type, resDate, childsName, childsAge, specialNotes);

                    eForm.ShowDialog();

                    bowlerDatabaseDataSet.Bowlers[rowId].Last_Name = lastName;
                    bowlerDatabaseDataSet.Bowlers[rowId].First_Name = firstName;
                    bowlerDatabaseDataSet.Bowlers[rowId].Company_Name = companyName;
                    bowlerDatabaseDataSet.Bowlers[rowId].League = league;
                    bowlerDatabaseDataSet.Bowlers[rowId].Phone_Number = phone;
                    bowlerDatabaseDataSet.Bowlers[rowId].Email = email;
                    bowlerDatabaseDataSet.Bowlers[rowId].Address = address;
                    bowlerDatabaseDataSet.Bowlers[rowId].Emergency_Contact = emContact;
                    bowlerDatabaseDataSet.Bowlers[rowId].Emergency_Phone_Number = emPhone;
                    bowlerDatabaseDataSet.Bowlers[rowId].Type = type;
                    bowlerDatabaseDataSet.Bowlers[rowId].Reservation_Date = resDate;
                    bowlerDatabaseDataSet.Bowlers[rowId]._Child_s_Name = childsName;
                    bowlerDatabaseDataSet.Bowlers[rowId]._Child_s_Age = childsAge;
                    bowlerDatabaseDataSet.Bowlers[rowId].Special_Notes = specialNotes;

                    this.bowlersTableAdapter.Update(this.bowlerDatabaseDataSet.Bowlers);
                }
            }
            else
            {
                MessageBox.Show("Admin Priveleges Required");
            }
            
            
        }

        private void editEntryButton_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            Password passForm = new Password();
            if(locked == true)
            {
                passForm.ShowDialog();
                if(locked == false)
                {
                    unlockButton.Text = "Lock";
                }                
            }
            else if (locked == false)
            {
                locked = true;
                unlockButton.Text = "Unlock";
            }
            
        }
    }
}
