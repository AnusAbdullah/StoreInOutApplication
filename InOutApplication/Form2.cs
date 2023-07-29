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

namespace InOutApplication
{
    public partial class INFORM : Form
    {
        public INFORM()
        {
            InitializeComponent();
        }

        private void Insavrbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();
                   // MessageBox.Show("Connection Established");

                    string sql = "INSERT INTO `in` (ItemName, inbalance,indate) VALUES (@itemName, @inBalance,@indate)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@itemName", this.INcombobox.Text);
                        cmd.Parameters.AddWithValue("@inBalance", this.INamountbox.Text);
                        cmd.Parameters.AddWithValue("@indate", this.dateTimePicker1.Value.Date);
                        cmd.ExecuteNonQuery();
                    }
                    //MessageBox.Show("In added successfully");
                    updatebalance(int.Parse(this.INamountbox.Text), this.INcombobox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void updatebalance(int amount,string name)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();

                    // Retrieve the current balance
                    MySqlCommand selectCmd = new MySqlCommand();
                    selectCmd.Connection = con;
                    selectCmd.CommandType = CommandType.Text;
                    selectCmd.CommandText = "SELECT Balance FROM items WHERE ItemName = @itemName";
                    selectCmd.Parameters.AddWithValue("@itemName", name);

                    int currentBalance = Convert.ToInt32(selectCmd.ExecuteScalar());

                    // Calculate the new balance
                    int newBalance = currentBalance + amount;

                    // Update the balance
                    MySqlCommand updateCmd = new MySqlCommand();
                    updateCmd.Connection = con;
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.CommandText = "UPDATE items SET Balance = @newBalance WHERE ItemName = @itemName";
                    updateCmd.Parameters.AddWithValue("@newBalance", newBalance);
                    updateCmd.Parameters.AddWithValue("@itemName", name);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // The update was successful
                        MessageBox.Show("Balance updated successfully.");
                    }
                    else
                    {
                        // No rows were affected (item not found or no changes made)
                        MessageBox.Show("Item not found or no changes made.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void loadcombobox()
        {
            int cursorPosition = INcombobox.SelectionStart;
            INcombobox.Items.Clear();
            string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ItemName FROM items WHERE ItemName LIKE @itemName";
                cmd.Parameters.AddWithValue("@itemName", INcombobox.Text + "%");

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    INcombobox.Items.Add(dr["ItemName"].ToString());
                }
            }
            INcombobox.SelectionStart = cursorPosition;
        }

        private void INcombobox_TextChanged(object sender, EventArgs e)
        {
            loadcombobox();
        }

        private void INFORM_Load(object sender, EventArgs e)
        {
            loadcombobox();
        }
    }
}
