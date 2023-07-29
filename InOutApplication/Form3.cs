using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InOutApplication
{
    public partial class OUTFORM : Form
    {
        public OUTFORM()
        {
            InitializeComponent();
        }

        private void Insavrbtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
            //    using (MySqlConnection con = new MySqlConnection(connstring))
            //    {
            //        con.Open();
            //        //MessageBox.Show("Connection Established");

            //        string sql = "INSERT INTO `out` (ItemName, outbalance) VALUES (@itemName, @outBalance)";
            //        using (MySqlCommand cmd = new MySqlCommand(sql, con))
            //        {
            //            cmd.Parameters.AddWithValue("@itemName", this.Outcombobox.Text);
            //            cmd.Parameters.AddWithValue("@outBalance", this.OUTamountbox.Text);

            //            cmd.ExecuteNonQuery();
            //            //MessageBox.Show("Out added successfully");
            //            updatebalance(int.Parse(this.OUTamountbox.Text), this.Outcombobox.Text);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error Occurred: " + ex.Message);
            //}
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
                    selectCmd.Parameters.AddWithValue("@itemName", this.Outcombobox.Text);

                    int currentBalance = Convert.ToInt32(selectCmd.ExecuteScalar());

                    // Calculate the new balance
                    int newBalance = currentBalance - int.Parse(this.OUTamountbox.Text);
                    if (newBalance >= 0)
                    {
                        // Update the balance
                        MySqlCommand updateCmd = new MySqlCommand();
                        updateCmd.Connection = con;
                        updateCmd.CommandType = CommandType.Text;
                        updateCmd.CommandText = "INSERT INTO `out` (ItemName, outbalance,outdate) VALUES (@itemName, @outBalance,@outdate)";
                        updateCmd.Parameters.AddWithValue("@itemName", this.Outcombobox.Text);
                        updateCmd.Parameters.AddWithValue("@outBalance", this.OUTamountbox.Text);
                        updateCmd.Parameters.AddWithValue("@outdate", this.dateTimePicker1.Value.Date);
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        //if (rowsAffected > 0)
                        //{
                        //    // The update was successful
                        //    MessageBox.Show("Balance updated successfully.");
                        //}
                        //else
                        //{
                        //    // No rows were affected (item not found or no changes made)
                        //    MessageBox.Show("Item not found or no changes made.");
                        //}
                        updatebalance(int.Parse(this.OUTamountbox.Text), this.Outcombobox.Text);
                    }
                    else
                    {
                        MessageBox.Show("You don't have enough Items.");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }

        }
        private void updatebalance(int amount, string name)
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
                    int newBalance = currentBalance - amount;

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
        private void OUTFORM_Load(object sender, EventArgs e)
        {
            loadcombobox();
        }

        private void loadcombobox()
        {
            int cursorPosition = Outcombobox.SelectionStart;
            Outcombobox.Items.Clear();
            string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ItemName FROM items WHERE ItemName LIKE @itemName";
                cmd.Parameters.AddWithValue("@itemName", Outcombobox.Text + "%");

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Outcombobox.Items.Add(dr["ItemName"].ToString());
                }
            }
            Outcombobox.SelectionStart = cursorPosition;
        }

        private void Outcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadcombobox();
        }

        private void Outcombobox_TextChanged(object sender, EventArgs e)
        {
            loadcombobox();
        }

        private void Outcombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //loadcombobox();
        }
    }
}
