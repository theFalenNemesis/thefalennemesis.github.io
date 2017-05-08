namespace Bowler_Reservation_Database
{
    partial class addEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveEntryButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.specialNotesTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.leagueComboBox = new System.Windows.Forms.ComboBox();
            this.reservationDateTime = new System.Windows.Forms.DateTimePicker();
            this.childsAgeTextBox = new System.Windows.Forms.TextBox();
            this.childsNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.leageLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.specialNotesLabel = new System.Windows.Forms.Label();
            this.childsAgeLabel = new System.Windows.Forms.Label();
            this.childsNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.resDateCheckBox = new System.Windows.Forms.CheckBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emPhoneLabel = new System.Windows.Forms.Label();
            this.emContactLabel = new System.Windows.Forms.Label();
            this.emPhoneTextBox = new System.Windows.Forms.TextBox();
            this.emContactTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveEntryButton
            // 
            this.saveEntryButton.BackColor = System.Drawing.Color.Yellow;
            this.saveEntryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEntryButton.Location = new System.Drawing.Point(249, 452);
            this.saveEntryButton.Name = "saveEntryButton";
            this.saveEntryButton.Size = new System.Drawing.Size(102, 33);
            this.saveEntryButton.TabIndex = 13;
            this.saveEntryButton.Text = "Save";
            this.saveEntryButton.UseVisualStyleBackColor = false;
            this.saveEntryButton.Click += new System.EventHandler(this.saveEntryButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Yellow;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(130, 452);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 33);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // specialNotesTextBox
            // 
            this.specialNotesTextBox.Location = new System.Drawing.Point(43, 354);
            this.specialNotesTextBox.Multiline = true;
            this.specialNotesTextBox.Name = "specialNotesTextBox";
            this.specialNotesTextBox.Size = new System.Drawing.Size(416, 92);
            this.specialNotesTextBox.TabIndex = 12;
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "",
            "Open Bowling",
            "League",
            "Birthday (Basic)",
            "Birthday (Food)",
            "Free Game Coupon",
            "Church",
            "School"});
            this.typeComboBox.Location = new System.Drawing.Point(43, 243);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(190, 21);
            this.typeComboBox.TabIndex = 9;
            // 
            // leagueComboBox
            // 
            this.leagueComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.leagueComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.leagueComboBox.FormattingEnabled = true;
            this.leagueComboBox.Items.AddRange(new object[] {
            "",
            "Stars and Strikes",
            "Golden Age",
            "Christianairres",
            "Night Owls",
            "9 Pin No Tap (Tues)",
            "Christian Fellowship",
            "Agape",
            "9 Pin No Tap (Thurs)",
            "Youth"});
            this.leagueComboBox.Location = new System.Drawing.Point(43, 81);
            this.leagueComboBox.Name = "leagueComboBox";
            this.leagueComboBox.Size = new System.Drawing.Size(190, 21);
            this.leagueComboBox.TabIndex = 3;
            // 
            // reservationDateTime
            // 
            this.reservationDateTime.Location = new System.Drawing.Point(269, 243);
            this.reservationDateTime.Name = "reservationDateTime";
            this.reservationDateTime.Size = new System.Drawing.Size(190, 20);
            this.reservationDateTime.TabIndex = 8;
            // 
            // childsAgeTextBox
            // 
            this.childsAgeTextBox.Location = new System.Drawing.Point(269, 299);
            this.childsAgeTextBox.Name = "childsAgeTextBox";
            this.childsAgeTextBox.Size = new System.Drawing.Size(190, 20);
            this.childsAgeTextBox.TabIndex = 11;
            // 
            // childsNameTextBox
            // 
            this.childsNameTextBox.Location = new System.Drawing.Point(42, 298);
            this.childsNameTextBox.Name = "childsNameTextBox";
            this.childsNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.childsNameTextBox.TabIndex = 10;
            this.childsNameTextBox.TextChanged += new System.EventHandler(this.childsNameTextBox_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(269, 82);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(190, 20);
            this.phoneTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(43, 136);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(189, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(269, 28);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(190, 20);
            this.companyNameTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(270, 136);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(189, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(42, 28);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(83, 20);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // leageLabel
            // 
            this.leageLabel.AutoSize = true;
            this.leageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leageLabel.ForeColor = System.Drawing.Color.White;
            this.leageLabel.Location = new System.Drawing.Point(40, 66);
            this.leageLabel.Name = "leageLabel";
            this.leageLabel.Size = new System.Drawing.Size(53, 13);
            this.leageLabel.TabIndex = 16;
            this.leageLabel.Text = "League:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(40, 120);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 13);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.Color.White;
            this.typeLabel.Location = new System.Drawing.Point(40, 227);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(39, 13);
            this.typeLabel.TabIndex = 14;
            this.typeLabel.Text = "Type:";
            // 
            // specialNotesLabel
            // 
            this.specialNotesLabel.AutoSize = true;
            this.specialNotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialNotesLabel.ForeColor = System.Drawing.Color.White;
            this.specialNotesLabel.Location = new System.Drawing.Point(40, 338);
            this.specialNotesLabel.Name = "specialNotesLabel";
            this.specialNotesLabel.Size = new System.Drawing.Size(90, 13);
            this.specialNotesLabel.TabIndex = 13;
            this.specialNotesLabel.Text = "Special Notes:";
            // 
            // childsAgeLabel
            // 
            this.childsAgeLabel.AutoSize = true;
            this.childsAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childsAgeLabel.ForeColor = System.Drawing.Color.White;
            this.childsAgeLabel.Location = new System.Drawing.Point(266, 283);
            this.childsAgeLabel.Name = "childsAgeLabel";
            this.childsAgeLabel.Size = new System.Drawing.Size(74, 13);
            this.childsAgeLabel.TabIndex = 12;
            this.childsAgeLabel.Text = "Child\'s Age:";
            // 
            // childsNameLabel
            // 
            this.childsNameLabel.AutoSize = true;
            this.childsNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childsNameLabel.ForeColor = System.Drawing.Color.White;
            this.childsNameLabel.Location = new System.Drawing.Point(39, 282);
            this.childsNameLabel.Name = "childsNameLabel";
            this.childsNameLabel.Size = new System.Drawing.Size(84, 13);
            this.childsNameLabel.TabIndex = 11;
            this.childsNameLabel.Text = "Child\'s Name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(266, 66);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(94, 13);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.ForeColor = System.Drawing.Color.White;
            this.companyNameLabel.Location = new System.Drawing.Point(266, 12);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(98, 13);
            this.companyNameLabel.TabIndex = 9;
            this.companyNameLabel.Text = "Company Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(267, 120);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(56, 13);
            this.addressLabel.TabIndex = 18;
            this.addressLabel.Text = "Address:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(39, 12);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(71, 13);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // resDateCheckBox
            // 
            this.resDateCheckBox.AutoSize = true;
            this.resDateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resDateCheckBox.ForeColor = System.Drawing.Color.White;
            this.resDateCheckBox.Location = new System.Drawing.Point(269, 225);
            this.resDateCheckBox.Name = "resDateCheckBox";
            this.resDateCheckBox.Size = new System.Drawing.Size(129, 17);
            this.resDateCheckBox.TabIndex = 7;
            this.resDateCheckBox.Text = "Reservation Date:";
            this.resDateCheckBox.UseVisualStyleBackColor = true;
            this.resDateCheckBox.CheckedChanged += new System.EventHandler(this.resDateCheckBox_CheckedChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(148, 28);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(83, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(145, 12);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(71, 13);
            this.firstNameLabel.TabIndex = 34;
            this.firstNameLabel.Text = "First Name:";
            // 
            // emPhoneLabel
            // 
            this.emPhoneLabel.AutoSize = true;
            this.emPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emPhoneLabel.ForeColor = System.Drawing.Color.White;
            this.emPhoneLabel.Location = new System.Drawing.Point(267, 174);
            this.emPhoneLabel.Name = "emPhoneLabel";
            this.emPhoneLabel.Size = new System.Drawing.Size(160, 13);
            this.emPhoneLabel.TabIndex = 18;
            this.emPhoneLabel.Text = "Emergency Phone Number:";
            // 
            // emContactLabel
            // 
            this.emContactLabel.AutoSize = true;
            this.emContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emContactLabel.ForeColor = System.Drawing.Color.White;
            this.emContactLabel.Location = new System.Drawing.Point(40, 174);
            this.emContactLabel.Name = "emContactLabel";
            this.emContactLabel.Size = new System.Drawing.Size(121, 13);
            this.emContactLabel.TabIndex = 15;
            this.emContactLabel.Text = "Emergency Contact:";
            // 
            // emPhoneTextBox
            // 
            this.emPhoneTextBox.Location = new System.Drawing.Point(270, 190);
            this.emPhoneTextBox.Name = "emPhoneTextBox";
            this.emPhoneTextBox.Size = new System.Drawing.Size(189, 20);
            this.emPhoneTextBox.TabIndex = 6;
            // 
            // emContactTextBox
            // 
            this.emContactTextBox.Location = new System.Drawing.Point(43, 190);
            this.emContactTextBox.Name = "emContactTextBox";
            this.emContactTextBox.Size = new System.Drawing.Size(189, 20);
            this.emContactTextBox.TabIndex = 5;
            // 
            // addEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(486, 499);
            this.ControlBox = false;
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.resDateCheckBox);
            this.Controls.Add(this.saveEntryButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.specialNotesTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.leagueComboBox);
            this.Controls.Add(this.reservationDateTime);
            this.Controls.Add(this.childsAgeTextBox);
            this.Controls.Add(this.childsNameTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emContactTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emPhoneTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.emContactLabel);
            this.Controls.Add(this.leageLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.specialNotesLabel);
            this.Controls.Add(this.childsAgeLabel);
            this.Controls.Add(this.childsNameLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emPhoneLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "addEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Entry";
            this.Load += new System.EventHandler(this.addEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveEntryButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox specialNotesTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox leagueComboBox;
        private System.Windows.Forms.DateTimePicker reservationDateTime;
        private System.Windows.Forms.TextBox childsAgeTextBox;
        private System.Windows.Forms.TextBox childsNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label leageLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label specialNotesLabel;
        private System.Windows.Forms.Label childsAgeLabel;
        private System.Windows.Forms.Label childsNameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.CheckBox resDateCheckBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label emPhoneLabel;
        private System.Windows.Forms.Label emContactLabel;
        private System.Windows.Forms.TextBox emPhoneTextBox;
        private System.Windows.Forms.TextBox emContactTextBox;
    }
}