namespace InOutApplication
{
    partial class ADMINFORM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Admincombobox = new System.Windows.Forms.ComboBox();
            this.Delbtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Adminamountbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(384, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 450);
            this.dataGridView1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Admincombobox);
            this.panel1.Controls.Add(this.Delbtn);
            this.panel1.Controls.Add(this.Insertbtn);
            this.panel1.Controls.Add(this.Updatebtn);
            this.panel1.Controls.Add(this.Adminamountbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 450);
            this.panel1.TabIndex = 13;
            // 
            // Admincombobox
            // 
            this.Admincombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Admincombobox.FormattingEnabled = true;
            this.Admincombobox.Location = new System.Drawing.Point(146, 144);
            this.Admincombobox.Name = "Admincombobox";
            this.Admincombobox.Size = new System.Drawing.Size(144, 21);
            this.Admincombobox.TabIndex = 19;
            this.Admincombobox.TextChanged += new System.EventHandler(this.Admincombobox_TextChanged);
            // 
            // Delbtn
            // 
            this.Delbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.Delbtn.FlatAppearance.BorderSize = 0;
            this.Delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delbtn.Location = new System.Drawing.Point(260, 277);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(83, 29);
            this.Delbtn.TabIndex = 18;
            this.Delbtn.Text = "Delete";
            this.Delbtn.UseVisualStyleBackColor = false;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // Insertbtn
            // 
            this.Insertbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.Insertbtn.FlatAppearance.BorderSize = 0;
            this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Insertbtn.Location = new System.Drawing.Point(38, 277);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(83, 29);
            this.Insertbtn.TabIndex = 17;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = false;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.Updatebtn.FlatAppearance.BorderSize = 0;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Updatebtn.Location = new System.Drawing.Point(146, 277);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(83, 29);
            this.Updatebtn.TabIndex = 16;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Adminamountbox
            // 
            this.Adminamountbox.Location = new System.Drawing.Point(146, 204);
            this.Adminamountbox.Name = "Adminamountbox";
            this.Adminamountbox.Size = new System.Drawing.Size(144, 20);
            this.Adminamountbox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Item\'s Name";
            // 
            // ADMINFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ADMINFORM";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.ADMINFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.TextBox Adminamountbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Admincombobox;
    }
}