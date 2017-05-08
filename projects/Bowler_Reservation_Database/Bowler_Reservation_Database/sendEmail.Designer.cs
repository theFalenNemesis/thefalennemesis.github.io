namespace Bowler_Reservation_Database
{
    partial class sendEmail
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
            this.components = new System.ComponentModel.Container();
            this.selectionGroupBox = new System.Windows.Forms.GroupBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeRadioButton = new System.Windows.Forms.RadioButton();
            this.leagueRadioButton = new System.Windows.Forms.RadioButton();
            this.leagueComboBox = new System.Windows.Forms.ComboBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bowlersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bowlerDatabaseDataSet = new Bowler_Reservation_Database.BowlerDatabaseDataSet();
            this.bowlersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bowlersTableAdapter = new Bowler_Reservation_Database.BowlerDatabaseDataSetTableAdapters.BowlersTableAdapter();
            this.tableAdapterManager = new Bowler_Reservation_Database.BowlerDatabaseDataSetTableAdapters.TableAdapterManager();
            this.selectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bowlersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectionGroupBox
            // 
            this.selectionGroupBox.Controls.Add(this.typeComboBox);
            this.selectionGroupBox.Controls.Add(this.typeRadioButton);
            this.selectionGroupBox.Controls.Add(this.leagueRadioButton);
            this.selectionGroupBox.Controls.Add(this.leagueComboBox);
            this.selectionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.selectionGroupBox.Name = "selectionGroupBox";
            this.selectionGroupBox.Size = new System.Drawing.Size(205, 130);
            this.selectionGroupBox.TabIndex = 0;
            this.selectionGroupBox.TabStop = false;
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.typeComboBox.Enabled = false;
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
            this.typeComboBox.Location = new System.Drawing.Point(6, 98);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(190, 21);
            this.typeComboBox.TabIndex = 10;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // typeRadioButton
            // 
            this.typeRadioButton.AutoSize = true;
            this.typeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeRadioButton.ForeColor = System.Drawing.Color.White;
            this.typeRadioButton.Location = new System.Drawing.Point(6, 75);
            this.typeRadioButton.Name = "typeRadioButton";
            this.typeRadioButton.Size = new System.Drawing.Size(53, 17);
            this.typeRadioButton.TabIndex = 6;
            this.typeRadioButton.TabStop = true;
            this.typeRadioButton.Text = "Type";
            this.typeRadioButton.UseVisualStyleBackColor = true;
            this.typeRadioButton.CheckedChanged += new System.EventHandler(this.typeRadioButton_CheckedChanged);
            // 
            // leagueRadioButton
            // 
            this.leagueRadioButton.AutoSize = true;
            this.leagueRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leagueRadioButton.ForeColor = System.Drawing.Color.White;
            this.leagueRadioButton.Location = new System.Drawing.Point(6, 19);
            this.leagueRadioButton.Name = "leagueRadioButton";
            this.leagueRadioButton.Size = new System.Drawing.Size(67, 17);
            this.leagueRadioButton.TabIndex = 5;
            this.leagueRadioButton.TabStop = true;
            this.leagueRadioButton.Text = "League";
            this.leagueRadioButton.UseVisualStyleBackColor = true;
            this.leagueRadioButton.CheckedChanged += new System.EventHandler(this.leagueRadioButton_CheckedChanged);
            // 
            // leagueComboBox
            // 
            this.leagueComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.leagueComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.leagueComboBox.Enabled = false;
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
            "9 Pin No Tap (Fri)",
            "Youth"});
            this.leagueComboBox.Location = new System.Drawing.Point(6, 42);
            this.leagueComboBox.Name = "leagueComboBox";
            this.leagueComboBox.Size = new System.Drawing.Size(190, 21);
            this.leagueComboBox.TabIndex = 4;
            this.leagueComboBox.SelectedIndexChanged += new System.EventHandler(this.leagueComboBox_SelectedIndexChanged);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.ForeColor = System.Drawing.Color.White;
            this.subjectLabel.Location = new System.Drawing.Point(9, 158);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(54, 13);
            this.subjectLabel.TabIndex = 13;
            this.subjectLabel.Text = "Subject:";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Location = new System.Drawing.Point(12, 174);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(863, 20);
            this.subjectTextBox.TabIndex = 14;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyLabel.ForeColor = System.Drawing.Color.White;
            this.bodyLabel.Location = new System.Drawing.Point(9, 213);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(39, 13);
            this.bodyLabel.TabIndex = 13;
            this.bodyLabel.Text = "Body:";
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTextBox.Location = new System.Drawing.Point(12, 229);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(863, 200);
            this.bodyTextBox.TabIndex = 14;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sendEmailButton.BackColor = System.Drawing.Color.Yellow;
            this.sendEmailButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sendEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailButton.Location = new System.Drawing.Point(447, 435);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(102, 33);
            this.sendEmailButton.TabIndex = 15;
            this.sendEmailButton.Text = "Send";
            this.sendEmailButton.UseVisualStyleBackColor = false;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.BackColor = System.Drawing.Color.Yellow;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(328, 435);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 33);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // bowlersBindingSource
            // 
            this.bowlersBindingSource.DataMember = "Bowlers";
            this.bowlersBindingSource.DataSource = this.bowlerDatabaseDataSet;
            // 
            // bowlerDatabaseDataSet
            // 
            this.bowlerDatabaseDataSet.DataSetName = "BowlerDatabaseDataSet";
            this.bowlerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bowlersDataGridView
            // 
            this.bowlersDataGridView.AllowUserToAddRows = false;
            this.bowlersDataGridView.AllowUserToDeleteRows = false;
            this.bowlersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bowlersDataGridView.AutoGenerateColumns = false;
            this.bowlersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bowlersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bowlersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn35});
            this.bowlersDataGridView.DataSource = this.bowlersBindingSource;
            this.bowlersDataGridView.Location = new System.Drawing.Point(223, 12);
            this.bowlersDataGridView.Name = "bowlersDataGridView";
            this.bowlersDataGridView.ReadOnly = true;
            this.bowlersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bowlersDataGridView.Size = new System.Drawing.Size(652, 130);
            this.bowlersDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 35.445F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn30.FillWeight = 97.22055F;
            this.dataGridViewTextBoxColumn30.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn31.FillWeight = 97.22055F;
            this.dataGridViewTextBoxColumn31.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Company Name";
            this.dataGridViewTextBoxColumn32.FillWeight = 97.22055F;
            this.dataGridViewTextBoxColumn32.HeaderText = "Company Name";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn35.FillWeight = 97.22055F;
            this.dataGridViewTextBoxColumn35.HeaderText = "Email";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // bowlersTableAdapter
            // 
            this.bowlersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BowlersTableAdapter = this.bowlersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bowler_Reservation_Database.BowlerDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(887, 479);
            this.ControlBox = false;
            this.Controls.Add(this.bowlersDataGridView);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.selectionGroupBox);
            this.Name = "sendEmail";
            this.Text = "Send Email";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sendEmail_Load);
            this.selectionGroupBox.ResumeLayout(false);
            this.selectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bowlersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox selectionGroupBox;
        private System.Windows.Forms.ComboBox leagueComboBox;
        private System.Windows.Forms.RadioButton typeRadioButton;
        private System.Windows.Forms.RadioButton leagueRadioButton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private BowlerDatabaseDataSet bowlerDatabaseDataSet;
        private System.Windows.Forms.BindingSource bowlersBindingSource;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView bowlersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private BowlerDatabaseDataSetTableAdapters.BowlersTableAdapter bowlersTableAdapter;
        private BowlerDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}