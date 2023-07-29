namespace InOutApplication
{
    partial class INFORM
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
            this.label1 = new System.Windows.Forms.Label();
            this.INamountbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Insavrbtn = new System.Windows.Forms.Button();
            this.INcombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item\'s Name";
            // 
            // INamountbox
            // 
            this.INamountbox.Location = new System.Drawing.Point(308, 178);
            this.INamountbox.Name = "INamountbox";
            this.INamountbox.Size = new System.Drawing.Size(200, 20);
            this.INamountbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // Insavrbtn
            // 
            this.Insavrbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.Insavrbtn.FlatAppearance.BorderSize = 0;
            this.Insavrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insavrbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Insavrbtn.Location = new System.Drawing.Point(308, 298);
            this.Insavrbtn.Name = "Insavrbtn";
            this.Insavrbtn.Size = new System.Drawing.Size(83, 29);
            this.Insavrbtn.TabIndex = 4;
            this.Insavrbtn.Text = "IN";
            this.Insavrbtn.UseVisualStyleBackColor = false;
            this.Insavrbtn.Click += new System.EventHandler(this.Insavrbtn_Click);
            // 
            // INcombobox
            // 
            this.INcombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.INcombobox.FormattingEnabled = true;
            this.INcombobox.Location = new System.Drawing.Point(308, 121);
            this.INcombobox.Name = "INcombobox";
            this.INcombobox.Size = new System.Drawing.Size(200, 21);
            this.INcombobox.TabIndex = 11;
            this.INcombobox.TextChanged += new System.EventHandler(this.INcombobox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantity";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 234);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // INFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.INcombobox);
            this.Controls.Add(this.Insavrbtn);
            this.Controls.Add(this.INamountbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "INFORM";
            this.Text = "IN";
            this.Load += new System.EventHandler(this.INFORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INamountbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Insavrbtn;
        private System.Windows.Forms.ComboBox INcombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}