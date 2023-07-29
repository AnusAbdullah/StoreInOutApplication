namespace InOutApplication
{
    partial class OUTFORM
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
            this.Outsavebtn = new System.Windows.Forms.Button();
            this.OUTamountbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Outcombobox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Outsavebtn
            // 
            this.Outsavebtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.Outsavebtn.FlatAppearance.BorderSize = 0;
            this.Outsavebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outsavebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Outsavebtn.Location = new System.Drawing.Point(293, 312);
            this.Outsavebtn.Name = "Outsavebtn";
            this.Outsavebtn.Size = new System.Drawing.Size(83, 29);
            this.Outsavebtn.TabIndex = 9;
            this.Outsavebtn.Text = "OUT";
            this.Outsavebtn.UseVisualStyleBackColor = false;
            this.Outsavebtn.Click += new System.EventHandler(this.Insavrbtn_Click);
            // 
            // OUTamountbox
            // 
            this.OUTamountbox.Location = new System.Drawing.Point(293, 180);
            this.OUTamountbox.Name = "OUTamountbox";
            this.OUTamountbox.Size = new System.Drawing.Size(200, 20);
            this.OUTamountbox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item\'s Name";
            // 
            // Outcombobox
            // 
            this.Outcombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Outcombobox.FormattingEnabled = true;
            this.Outcombobox.Location = new System.Drawing.Point(293, 125);
            this.Outcombobox.Name = "Outcombobox";
            this.Outcombobox.Size = new System.Drawing.Size(200, 21);
            this.Outcombobox.TabIndex = 10;
            this.Outcombobox.SelectedIndexChanged += new System.EventHandler(this.Outcombobox_SelectedIndexChanged);
            this.Outcombobox.TextChanged += new System.EventHandler(this.Outcombobox_TextChanged);
            this.Outcombobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Outcombobox_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date";
            // 
            // OUTFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Outcombobox);
            this.Controls.Add(this.Outsavebtn);
            this.Controls.Add(this.OUTamountbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OUTFORM";
            this.Text = "OUT";
            this.Load += new System.EventHandler(this.OUTFORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Outsavebtn;
        private System.Windows.Forms.TextBox OUTamountbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Outcombobox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}