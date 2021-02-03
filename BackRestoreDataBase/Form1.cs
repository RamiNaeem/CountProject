using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BackRestoreDataBase
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = "";
        string connectionString = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void picConnect_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picConnect, "Connect");
        }

        private void picDisconnect_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picDisconnect, "Disconnect");

        }

        private void picConnect_Click(object sender, EventArgs e)
        {
            try{
                connectionString = "Data source = " + txtServerName.Text.Trim() + "; Trusted_connection = True;";
                connection = new SqlConnection(connectionString);
                connection.Open();
                sql = "SELECT * FROM sys.databases d WHERE d.database_id > 4";
                command = new SqlCommand(sql,connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    combDatabase.Items.Add(reader[0].ToString());
                }
                txtServerName.Enabled = false;
                picConnect.Enabled = false;
                picDisconnect.Enabled =true;
                combDatabase.Enabled = true;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void picBrowes_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBrowes, "Browse to select location");

        }

        private void picBackup_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBackup, "Backup");

        }

        private void picBrowes_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                txtDatabaseLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void picBrowsePath_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picBrowsePath, "Browse to select Backup File");

        }

        private void picRestore_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picRestore, "Restore");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtServerName.Text = System.Net.Dns.GetHostName().ToUpper() + @"\SQLEXPRESS";
            combDatabase.SelectedIndex = 0;
        }

        private void picDisconnect_Click(object sender, EventArgs e)
        {
            txtServerName.Enabled = true;
            picConnect.Enabled = true;
            picDisconnect.Enabled = false;
            combDatabase.Items.Clear();
            combDatabase.Items.Add("Please select ...");
            combDatabase.SelectedIndex = 0;
            combDatabase.Enabled = false;
            txtDatabaseLocation.Clear();
            txtDatabaseLocation.Enabled = false;
            picBrowes.Enabled = false;
            picBackup.Enabled = false;
            picBrowsePath.Enabled = false;
            txtDatabaseLocation.Enabled = false;
            picRestore.Enabled = false;

        }

        private void combDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combDatabase.SelectedIndex !=0) {
                txtDatabaseLocation.Enabled = true;
                picBrowes.Enabled = true;
                txtRestoreLocation.Enabled = true;
                picRestore.Enabled = true;
                picBrowsePath.Enabled = true;
            }
            else {
                txtDatabaseLocation.Clear();
                txtDatabaseLocation.Enabled = false;
                picBrowes.Enabled = false;
                picBackup.Enabled = false;
                txtRestoreLocation.Clear();
                txtRestoreLocation.Enabled = false;
                picRestore.Enabled = false;
                picBrowsePath.Enabled = false;
            }
            txtDatabaseLocation.Clear();
            txtRestoreLocation.Clear();
        }

        private void txtDatabaseLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtDatabaseLocation.Text.Trim() !=string.Empty) {
                picBackup.Enabled = true;
            }
            else {
                picBackup.Enabled = false;
            }
        }

        private void txtRestoreLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtRestoreLocation.Text.Trim() != string.Empty)
            {
                picRestore.Enabled = true;
            }
            else
            {
                picRestore.Enabled = false;
            }
        }

        private void picBackup_Click(object sender, EventArgs e)
        {
            try {
                connection = new SqlConnection(connectionString);
                connection.Open();
                sql = "BACKUP DATABASE " + combDatabase.Text + " TO DISK = '" + txtDatabaseLocation.Text.Trim() + "\\" + combDatabase.Text + "-" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH-mm-ss") + ".bak'";
                command = new SqlCommand(sql,connection);
                command.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();
                MessageBox.Show("Successfully database backup completed.","Backup",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBrowsePath_Click(object sender, EventArgs e)
        {
            if (txtDatabaseLocation.Text != @"C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\Backup") 
                openFileDialog1.InitialDirectory = txtDatabaseLocation.Text;
            openFileDialog1.Filter = "backup Files(*.bak)|*.bak|All Files(*.*)| *.*";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog()==DialogResult.OK) {
                txtRestoreLocation.Text = openFileDialog1.FileName;
            }         
        }

        private void picRestore_Click(object sender, EventArgs e)
        {
            try {
                connection = new SqlConnection(connectionString);
                connection.Open();
                sql = "ALTER DATABASE " + combDatabase.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "RESTORE DATABASE " + combDatabase.Text + " FROM DISK = '" + txtRestoreLocation.Text.Trim() + "' WITH REPLACE;";
                command = new SqlCommand(sql,connection);
                command.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();
                MessageBox.Show("Successfully Database Restored","Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
