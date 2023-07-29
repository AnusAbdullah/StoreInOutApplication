using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InOutApplication
{
   
    

    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    //string sql = "SELECT ItemName,InBalance,OutBalance,Balance FROM summary WHERE inbalance IS NOT NULL OR outbalance IS NOT NULL";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridView dataGridView = dataGridView1; // Replace with your DataGridView instance
            Font font = dataGridView.Font;
            Brush brush = new SolidBrush(Color.Black);

            int rowHeight = dataGridView.RowTemplate.Height;
            int columnsCount = dataGridView.Columns.Count;
            int totalWidth = dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int cellHeight;

            // Print additional text
            string additionalText = $"Umar & Abdullah Textiles\tIn & Out Items List ,Date : {this.dateTimePicker1.Value.Date}"; // Replace with your desired text
            int additionalTextHeight = (int)font.GetHeight() + 5;
            e.Graphics.DrawString(additionalText, font, brush, x, y);
            y += additionalTextHeight;

            // Print column headers
            for (int i = 0; i < columnsCount; i++)
            {
                int cellWidth = (int)Math.Floor((double)dataGridView.Columns[i].Width / totalWidth * e.MarginBounds.Width);
                cellHeight = rowHeight;

                e.Graphics.FillRectangle(new SolidBrush(dataGridView.ColumnHeadersDefaultCellStyle.BackColor), new Rectangle(x, y, cellWidth, cellHeight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, cellWidth, cellHeight));
                e.Graphics.DrawString(dataGridView.Columns[i].HeaderText, font, brush, new RectangleF(x, y, cellWidth, cellHeight));

                x += cellWidth;
            }

            // Print rows
            y += rowHeight;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                x = e.MarginBounds.Left;

                // Print cells
                for (int i = 0; i < columnsCount; i++)
                {
                    int cellWidth = (int)Math.Floor((double)dataGridView.Columns[i].Width / totalWidth * e.MarginBounds.Width);
                    cellHeight = rowHeight;

                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, cellWidth, cellHeight));
                    e.Graphics.DrawString(row.Cells[i].FormattedValue.ToString(), font, brush, new RectangleF(x, y, cellWidth, cellHeight));

                    x += cellWidth;
                }

                y += rowHeight;

                // Check if there are more rows to print
                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
        }


        private void Printbtn_Click(object sender, EventArgs e)
        {

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=anas;database=inout";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    string sql = "SELECT ItemName,InBalance,OutBalance,Balance FROM combined_view WHERE ((Date IS NULL) OR (Date = @selectedDate OR Date = @selectedDate))";
                    //string sql = "SELECT * FROM combined_view";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@selectedDate", this.dateTimePicker1.Value.Date);
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
    }
}
