using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InOutApplication
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();

        }

        private void openChildForm(Form chilfForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = chilfForm;
            chilfForm.TopLevel = false;
            chilfForm.FormBorderStyle = FormBorderStyle.None;
            chilfForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(chilfForm);
            this.MainPanel.Tag = chilfForm;
            chilfForm.BringToFront();
            chilfForm.Show();
            Mainlabel.Text = chilfForm.Text;
        }
        private void INbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new INFORM(), sender);
        }

        private void OUTbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new OUTFORM(), sender);

        }

        private void Summarybtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Summary(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new ADMINFORM(), sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 
            try
            {
                string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    string sql = "SELECT  ItemName,InBalance,OutBalance,Balance  FROM combined_view";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void NewDay_Click(object sender, EventArgs e)
        {
            //string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
            //using (MySqlConnection con = new MySqlConnection(connstring))
            //{
            //    con.Open();

            //    // Start a transaction
            //    using (MySqlTransaction transaction = con.BeginTransaction())
            //    {
            //        try
            //        {
            //            // Delete table 'in'
            //            MySqlCommand deleteInCmd = new MySqlCommand();
            //            deleteInCmd.Connection = con;
            //            deleteInCmd.Transaction = transaction;
            //            deleteInCmd.CommandType = CommandType.Text;
            //            deleteInCmd.CommandText = "DELETE FROM `in`";
            //            deleteInCmd.ExecuteNonQuery();

            //            // Delete table 'out'
            //            MySqlCommand deleteOutCmd = new MySqlCommand();
            //            deleteOutCmd.Connection = con;
            //            deleteOutCmd.Transaction = transaction;
            //            deleteOutCmd.CommandType = CommandType.Text;
            //            deleteOutCmd.CommandText = "DELETE FROM `out`";
            //            deleteOutCmd.ExecuteNonQuery();

            //            // Commit the transaction
            //            transaction.Commit();

            //            MessageBox.Show("Tables deleted successfully.");
            //        }
            //        catch (Exception ex)
            //        {
            //            // An error occurred, rollback the transaction
            //            transaction.Rollback();
            //            MessageBox.Show("Error occurred: " + ex.Message);
            //        }
            //    }
            //}
        }

        
        private void Printbtn_Click(object sender, EventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
    }
}
