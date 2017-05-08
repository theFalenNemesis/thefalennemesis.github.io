using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bowler_Reservation_Database
{
    public partial class sendEmail : Form
    {
        public sendEmail()
        {
            InitializeComponent();
        }

        private void bowlersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bowlersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bowlerDatabaseDataSet);

        }

        private void sendEmail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bowlerDatabaseDataSet.Bowlers' table. You can move, or remove it, as needed.
            this.bowlersTableAdapter.Fill(this.bowlerDatabaseDataSet.Bowlers);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leagueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(leagueRadioButton.Checked == true)
            {
                leagueComboBox.Enabled = true;
            }
            else
            {
                leagueComboBox.Enabled = false;
            }
        }

        private void typeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (typeRadioButton.Checked == true)
            {
                typeComboBox.Enabled = true;
            }
            else
            {
                typeComboBox.Enabled = false;
            }
        }

        private void leagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bowlersTableAdapter.Search(this.bowlerDatabaseDataSet.Bowlers, leagueComboBox.SelectedItem.ToString());
            GetRecipients();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bowlersTableAdapter.Search(this.bowlerDatabaseDataSet.Bowlers, typeComboBox.SelectedItem.ToString());
            GetRecipients();
        }

        private void GetRecipients()
        {
            List<string> emailList = new List<string>();
            int visibleRows = bowlersDataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1;

            for(int index = 0; index < visibleRows; index++)
            {
                emailList.Add(bowlersDataGridView.Rows[index].Cells[4].Value.ToString());
            }

            string recipients = string.Join(", ", emailList);
            
        }

        private void SendEmail()
        {
            List<string> emailList = new List<string>();
            int visibleRows = bowlersDataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1;

            for (int index = 0; index < visibleRows; index++)
            {
                emailList.Add(bowlersDataGridView.Rows[index].Cells[4].Value.ToString());
            }

            //string recipients = string.Join(", ", emailList);

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
                //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //mail.From = new MailAddress("bo099@lab.icc.edu");
                mail.From = new MailAddress("bvahle@thechristiancenter.cc");
                //mail.Bcc.Add("bonken1992@gmail.com");
                foreach(string recipients in emailList)
                {
                    mail.Bcc.Add(recipients);
                }
                mail.Subject = subjectTextBox.Text;
                mail.Body = bodyTextBox.Text;
                //Attachment attachment = new Attachment(filename);
                //mail.Attachments.Add(attachment);

                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential("bvahle@thechristiancenter.cc", "");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                MessageBox.Show("Email Sent");
                subjectTextBox.Text = "";
                bodyTextBox.Text = "";
            }
            catch
            {
                MessageBox.Show("Error sending email.");
            }
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            SendEmail();
        }
    }
}
