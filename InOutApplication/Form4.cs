using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InOutApplication
{
    public partial class ADMINFORM : Form
    {
        public ADMINFORM()
        {
            InitializeComponent();
        }

        private void loadgrid()
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
                MySqlConnection con = new MySqlConnection(connstring);
                string sql = "select * from items";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void ADMINFORM_Load(object sender, EventArgs e)
        {
            loadgrid();
            loadcombobox();
        }
        private void loadcombobox()
        {
           //Admincombobox.Enabled = true;
            int cursorPosition = Admincombobox.SelectionStart;
            Admincombobox.Items.Clear();
            string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ItemName FROM items WHERE ItemName LIKE @itemName";
                cmd.Parameters.AddWithValue("@itemName", Admincombobox.Text + "%");

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Admincombobox.Items.Add(dr["ItemName"].ToString());
                }
            }
            Admincombobox.SelectionStart = cursorPosition;
        }
        private void Insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();
                    //MessageBox.Show("Connection Established");

                    string sql = "INSERT INTO `items` (ItemName, Balance) VALUES (@itemName, @Balance)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@itemName", this.Admincombobox.Text);
                        cmd.Parameters.AddWithValue("@Balance", this.Adminamountbox.Text);

                        cmd.ExecuteNonQuery();
                    }
                    //MessageBox.Show("Item added successfully");
                    loadgrid(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();
                   // MessageBox.Show("Connection Established");

                    string sql = "UPDATE `items` SET Balance = @outBalance WHERE ItemName = @itemName";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@outBalance", this.Adminamountbox.Text);
                        cmd.Parameters.AddWithValue("@itemName", this.Admincombobox.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Out updated successfully");
                        else
                            MessageBox.Show("No matching records found");
                    }
                    loadgrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void Delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();
                    //MessageBox.Show("Connection Established");

                    string sql = "DELETE FROM `items` WHERE ItemName = @itemName";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@itemName", this.Admincombobox.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Record deleted successfully");
                        else
                            MessageBox.Show("No matching records found");
                    }
                    loadgrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void Admincombobox_TextChanged(object sender, EventArgs e)
        {
            loadcombobox();
        }
    }
}
