namespace InOutApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftNavpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menulabel = new System.Windows.Forms.Label();
            this.INbtn = new System.Windows.Forms.Button();
            this.OUTbtn = new System.Windows.Forms.Button();
            this.Summarybtn = new System.Windows.Forms.Button();
            this.Adminoprbtn = new System.Windows.Forms.Button();
            this.Navpanel = new System.Windows.Forms.Panel();
            this.Mainlabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.LeftNavpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Navpanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftNavpanel
            // 
            this.LeftNavpanel.BackColor = System.Drawing.Color.DimGray;
            this.LeftNavpanel.Controls.Add(this.panel1);
            this.LeftNavpanel.Controls.Add(this.INbtn);
            this.LeftNavpanel.Controls.Add(this.OUTbtn);
            this.LeftNavpanel.Controls.Add(this.Summarybtn);
            this.LeftNavpanel.Controls.Add(this.Adminoprbtn);
            this.LeftNavpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftNavpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftNavpanel.Location = new System.Drawing.Point(0, 0);
            this.LeftNavpanel.Name = "LeftNavpanel";
            this.LeftNavpanel.Size = new System.Drawing.Size(166, 450);
            this.LeftNavpanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Menulabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 74);
            this.panel1.TabIndex = 0;
            // 
            // Menulabel
            // 
            this.Menulabel.AutoSize = true;
            this.Menulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menulabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menulabel.Location = new System.Drawing.Point(9, 28);
            this.Menulabel.Name = "Menulabel";
            this.Menulabel.Size = new System.Drawing.Size(137, 13);
            this.Menulabel.TabIndex = 0;
            this.Menulabel.Text = "Umar Abdullah Textiles";
            this.Menulabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INbtn
            // 
            this.INbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.INbtn.FlatAppearance.BorderSize = 0;
            this.INbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.INbtn.Location = new System.Drawing.Point(3, 83);
            this.INbtn.Name = "INbtn";
            this.INbtn.Size = new System.Drawing.Size(162, 23);
            this.INbtn.TabIndex = 1;
            this.INbtn.Text = "IN";
            this.INbtn.UseVisualStyleBackColor = true;
            this.INbtn.Click += new System.EventHandler(this.INbtn_Click);
            // 
            // OUTbtn
            // 
            this.OUTbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OUTbtn.FlatAppearance.BorderSize = 0;
            this.OUTbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OUTbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUTbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OUTbtn.Location = new System.Drawing.Point(3, 112);
            this.OUTbtn.Name = "OUTbtn";
            this.OUTbtn.Size = new System.Drawing.Size(162, 23);
            this.OUTbtn.TabIndex = 2;
            this.OUTbtn.Text = "OUT";
            this.OUTbtn.UseVisualStyleBackColor = true;
            this.OUTbtn.Click += new System.EventHandler(this.OUTbtn_Click);
            // 
            // Summarybtn
            // 
            this.Summarybtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Summarybtn.FlatAppearance.BorderSize = 0;
            this.Summarybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Summarybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summarybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Summarybtn.Location = new System.Drawing.Point(3, 141);
            this.Summarybtn.Name = "Summarybtn";
            this.Summarybtn.Size = new System.Drawing.Size(162, 23);
            this.Summarybtn.TabIndex = 3;
            this.Summarybtn.Text = "Summary";
            this.Summarybtn.UseVisualStyleBackColor = true;
            this.Summarybtn.Click += new System.EventHandler(this.Summarybtn_Click);
            // 
            // Adminoprbtn
            // 
            this.Adminoprbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Adminoprbtn.FlatAppearance.BorderSize = 0;
            this.Adminoprbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adminoprbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminoprbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Adminoprbtn.Location = new System.Drawing.Point(3, 170);
            this.Adminoprbtn.Name = "Adminoprbtn";
            this.Adminoprbtn.Size = new System.Drawing.Size(162, 23);
            this.Adminoprbtn.TabIndex = 4;
            this.Adminoprbtn.Text = "Admin";
            this.Adminoprbtn.UseVisualStyleBackColor = true;
            this.Adminoprbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Navpanel
            // 
            this.Navpanel.BackColor = System.Drawing.Color.DimGray;
            this.Navpanel.Controls.Add(this.Mainlabel);
            this.Navpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navpanel.Location = new System.Drawing.Point(166, 0);
            this.Navpanel.Name = "Navpanel";
            this.Navpanel.Size = new System.Drawing.Size(634, 77);
            this.Navpanel.TabIndex = 1;
            // 
            // Mainlabel
            // 
            this.Mainlabel.AutoSize = true;
            this.Mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mainlabel.Location = new System.Drawing.Point(202, 31);
            this.Mainlabel.Name = "Mainlabel";
            this.Mainlabel.Size = new System.Drawing.Size(71, 16);
            this.Mainlabel.TabIndex = 1;
            this.Mainlabel.Text = "Summary";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(166, 77);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(634, 373);
            this.MainPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Navpanel);
            this.Controls.Add(this.LeftNavpanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "IN & OUT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftNavpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Navpanel.ResumeLayout(false);
            this.Navpanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LeftNavpanel;
        private System.Windows.Forms.Panel Navpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button INbtn;
        private System.Windows.Forms.Button OUTbtn;
        private System.Windows.Forms.Button Summarybtn;
        private System.Windows.Forms.Label Menulabel;
        private System.Windows.Forms.Label Mainlabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Adminoprbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

