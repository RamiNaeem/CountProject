namespace BackRestoreDataBase
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picDisconnect = new System.Windows.Forms.PictureBox();
            this.picConnect = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picBrowes = new System.Windows.Forms.PictureBox();
            this.picBackup = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatabaseLocation = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picBrowsePath = new System.Windows.Forms.PictureBox();
            this.picRestore = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRestoreLocation = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisconnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnect)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowsePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(631, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SQL Server Backup & Restore Database";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picDisconnect);
            this.groupBox1.Controls.Add(this.picConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "sql server authentication;";
            // 
            // picDisconnect
            // 
            this.picDisconnect.Enabled = false;
            this.picDisconnect.Image = global::BackRestoreDataBase.Properties.Resources.disconnect2;
            this.picDisconnect.Location = new System.Drawing.Point(618, 66);
            this.picDisconnect.Name = "picDisconnect";
            this.picDisconnect.Size = new System.Drawing.Size(32, 28);
            this.picDisconnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisconnect.TabIndex = 6;
            this.picDisconnect.TabStop = false;
            this.picDisconnect.Click += new System.EventHandler(this.picDisconnect_Click);
            this.picDisconnect.MouseHover += new System.EventHandler(this.picDisconnect_MouseHover);
            // 
            // picConnect
            // 
            this.picConnect.Image = global::BackRestoreDataBase.Properties.Resources.connect;
            this.picConnect.Location = new System.Drawing.Point(575, 66);
            this.picConnect.Name = "picConnect";
            this.picConnect.Size = new System.Drawing.Size(32, 28);
            this.picConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConnect.TabIndex = 5;
            this.picConnect.TabStop = false;
            this.picConnect.Click += new System.EventHandler(this.picConnect_Click);
            this.picConnect.MouseHover += new System.EventHandler(this.picConnect_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SQL server name:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(61, 54);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(395, 20);
            this.txtServerName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combDatabase);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Selection:";
            // 
            // combDatabase
            // 
            this.combDatabase.Enabled = false;
            this.combDatabase.FormattingEnabled = true;
            this.combDatabase.Items.AddRange(new object[] {
            "Select database"});
            this.combDatabase.Location = new System.Drawing.Point(61, 55);
            this.combDatabase.Name = "combDatabase";
            this.combDatabase.Size = new System.Drawing.Size(395, 21);
            this.combDatabase.TabIndex = 7;
            this.combDatabase.SelectedIndexChanged += new System.EventHandler(this.combDatabase_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Database:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picBrowes);
            this.groupBox3.Controls.Add(this.picBackup);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDatabaseLocation);
            this.groupBox3.Location = new System.Drawing.Point(12, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database Backup:";
            // 
            // picBrowes
            // 
            this.picBrowes.Enabled = false;
            this.picBrowes.Image = global::BackRestoreDataBase.Properties.Resources.browseIcon;
            this.picBrowes.Location = new System.Drawing.Point(575, 66);
            this.picBrowes.Name = "picBrowes";
            this.picBrowes.Size = new System.Drawing.Size(32, 28);
            this.picBrowes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBrowes.TabIndex = 6;
            this.picBrowes.TabStop = false;
            this.picBrowes.Click += new System.EventHandler(this.picBrowes_Click);
            this.picBrowes.MouseHover += new System.EventHandler(this.picBrowes_MouseHover);
            // 
            // picBackup
            // 
            this.picBackup.Enabled = false;
            this.picBackup.Image = global::BackRestoreDataBase.Properties.Resources.backupIcon;
            this.picBackup.Location = new System.Drawing.Point(618, 66);
            this.picBackup.Name = "picBackup";
            this.picBackup.Size = new System.Drawing.Size(32, 28);
            this.picBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackup.TabIndex = 5;
            this.picBackup.TabStop = false;
            this.picBackup.Click += new System.EventHandler(this.picBackup_Click);
            this.picBackup.MouseHover += new System.EventHandler(this.picBackup_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Location:";
            // 
            // txtDatabaseLocation
            // 
            this.txtDatabaseLocation.Enabled = false;
            this.txtDatabaseLocation.Location = new System.Drawing.Point(61, 54);
            this.txtDatabaseLocation.Name = "txtDatabaseLocation";
            this.txtDatabaseLocation.Size = new System.Drawing.Size(395, 20);
            this.txtDatabaseLocation.TabIndex = 0;
            this.txtDatabaseLocation.TextChanged += new System.EventHandler(this.txtDatabaseLocation_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picBrowsePath);
            this.groupBox4.Controls.Add(this.picRestore);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtRestoreLocation);
            this.groupBox4.Location = new System.Drawing.Point(12, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(676, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database Restore:";
            // 
            // picBrowsePath
            // 
            this.picBrowsePath.Enabled = false;
            this.picBrowsePath.Image = global::BackRestoreDataBase.Properties.Resources.browseIcon;
            this.picBrowsePath.Location = new System.Drawing.Point(575, 66);
            this.picBrowsePath.Name = "picBrowsePath";
            this.picBrowsePath.Size = new System.Drawing.Size(32, 28);
            this.picBrowsePath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBrowsePath.TabIndex = 6;
            this.picBrowsePath.TabStop = false;
            this.picBrowsePath.Click += new System.EventHandler(this.picBrowsePath_Click);
            this.picBrowsePath.MouseHover += new System.EventHandler(this.picBrowsePath_MouseHover);
            // 
            // picRestore
            // 
            this.picRestore.Enabled = false;
            this.picRestore.Image = global::BackRestoreDataBase.Properties.Resources.restoreIcon;
            this.picRestore.Location = new System.Drawing.Point(618, 66);
            this.picRestore.Name = "picRestore";
            this.picRestore.Size = new System.Drawing.Size(32, 28);
            this.picRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRestore.TabIndex = 5;
            this.picRestore.TabStop = false;
            this.picRestore.Click += new System.EventHandler(this.picRestore_Click);
            this.picRestore.MouseHover += new System.EventHandler(this.picRestore_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Backup Path:";
            // 
            // txtRestoreLocation
            // 
            this.txtRestoreLocation.Enabled = false;
            this.txtRestoreLocation.Location = new System.Drawing.Point(61, 54);
            this.txtRestoreLocation.Name = "txtRestoreLocation";
            this.txtRestoreLocation.Size = new System.Drawing.Size(395, 20);
            this.txtRestoreLocation.TabIndex = 0;
            this.txtRestoreLocation.TextChanged += new System.EventHandler(this.txtRestoreLocation_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BackRestoreDataBase.Properties.Resources.sqlserver;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "copyright © 2020 Rami. all rights reserved";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Program Files\\Microsoft SQL Server\\MSSQL14.SQLEXPRESS\\MSSQL\\Backup";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 672);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server Backup & Restore Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisconnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnect)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackup)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowsePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.PictureBox picConnect;
        private System.Windows.Forms.PictureBox picDisconnect;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picBrowes;
        private System.Windows.Forms.PictureBox picBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatabaseLocation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picBrowsePath;
        private System.Windows.Forms.PictureBox picRestore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRestoreLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

