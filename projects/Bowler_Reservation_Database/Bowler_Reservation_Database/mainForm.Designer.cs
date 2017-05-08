namespace Bowler_Reservation_Database
{
    partial class mainForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.bowlersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bowlerDatabaseDataSet = new Bowler_Reservation_Database.BowlerDatabaseDataSet();
            this.bowlersTableAdapter = new Bowler_Reservation_Database.BowlerDatabaseDataSetTableAdapters.BowlersTableAdapter();
            this.tableAdapterManager = new Bowler_Reservation_Database.BowlerDatabaseDataSetTableAdapters.TableAdapterManager();
            this.bowlersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unlockButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bowlersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlerDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(730, 509);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(157, 36);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.Yellow;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(790, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(97, 29);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addEntryButton
            // 
            this.addEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addEntryButton.BackColor = System.Drawing.Color.Yellow;
            this.addEntryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEntryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEntryButton.Location = new System.Drawing.Point(12, 509);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(157, 36);
            this.addEntryButton.TabIndex = 6;
            this.addEntryButton.Text = "&Add Entry";
            this.addEntryButton.UseVisualStyleBackColor = false;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // emailButton
            // 
            this.emailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.emailButton.BackColor = System.Drawing.Color.Yellow;
            this.emailButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.emailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailButton.Location = new System.Drawing.Point(175, 509);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(157, 36);
            this.emailButton.TabIndex = 5;
            this.emailButton.Text = "Email";
            this.emailButton.UseVisualStyleBackColor = false;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(647, 17);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(137, 20);
            this.searchTextBox.TabIndex = 11;
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
            // bowlersDataGridView
            // 
            this.bowlersDataGridView.AllowUserToAddRows = false;
            this.bowlersDataGridView.AllowUserToDeleteRows = false;
            this.bowlersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bowlersDataGridView.AutoGenerateColumns = false;
            this.bowlersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bowlersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bowlersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43});
            this.bowlersDataGridView.DataSource = this.bowlersBindingSource;
            this.bowlersDataGridView.Location = new System.Drawing.Point(12, 51);
            this.bowlersDataGridView.Name = "bowlersDataGridView";
            this.bowlersDataGridView.ReadOnly = true;
            this.bowlersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bowlersDataGridView.Size = new System.Drawing.Size(875, 452);
            this.bowlersDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn30.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn30.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn31.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn31.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Company Name";
            this.dataGridViewTextBoxColumn32.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn32.HeaderText = "Company Name";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "League";
            this.dataGridViewTextBoxColumn33.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn33.HeaderText = "League";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Phone Number";
            this.dataGridViewTextBoxColumn34.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn34.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn35.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn35.HeaderText = "Email";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn36.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn36.HeaderText = "Address";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Emergency Contact";
            this.dataGridViewTextBoxColumn37.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn37.HeaderText = "Emergency Contact";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Emergency Phone Number";
            this.dataGridViewTextBoxColumn38.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn38.HeaderText = "Emergency Phone Number";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn39.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn39.HeaderText = "Type";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Reservation Date";
            this.dataGridViewTextBoxColumn40.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn40.HeaderText = "Reservation Date";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Child\'s Name";
            this.dataGridViewTextBoxColumn41.FillWeight = 101.2228F;
            this.dataGridViewTextBoxColumn41.HeaderText = "Child\'s Name";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Child\'s Age";
            this.dataGridViewTextBoxColumn42.FillWeight = 72.34225F;
            this.dataGridViewTextBoxColumn42.HeaderText = "Child\'s Age";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Special Notes";
            this.dataGridViewTextBoxColumn43.FillWeight = 237.8299F;
            this.dataGridViewTextBoxColumn43.HeaderText = "Special Notes";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            // 
            // unlockButton
            // 
            this.unlockButton.BackColor = System.Drawing.Color.Yellow;
            this.unlockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.unlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockButton.Location = new System.Drawing.Point(12, 12);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(59, 29);
            this.unlockButton.TabIndex = 12;
            this.unlockButton.Text = "Unlock";
            this.unlockButton.UseVisualStyleBackColor = false;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(899, 557);
            this.ControlBox = false;
            this.Controls.Add(this.unlockButton);
            this.Controls.Add(this.bowlersDataGridView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addEntryButton);
            this.Controls.Add(this.emailButton);
            this.Name = "mainForm";
            this.Text = "Bowler Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bowlersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlerDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Button emailButton;
        private BowlerDatabaseDataSet bowlerDatabaseDataSet;
        private System.Windows.Forms.BindingSource bowlersBindingSource;
        private System.Windows.Forms.TextBox searchTextBox;
        private BowlerDatabaseDataSetTableAdapters.BowlersTableAdapter bowlersTableAdapter;
        private BowlerDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bowlersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.Button unlockButton;
    }
}

