namespace Clinic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPatientName = new TextBox();
            txtPatientAge = new TextBox();
            cmbPatientType = new ComboBox();
            cmbReasonForVisit = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(72, 34);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 0;
            label1.Text = "PATIENT NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(206, 75);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 1;
            label2.Text = "AGE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(27, 120);
            label3.Name = "label3";
            label3.Size = new Size(241, 30);
            label3.TabIndex = 2;
            label3.Text = "REASON FOR VISIT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(83, 164);
            label4.Name = "label4";
            label4.Size = new Size(185, 30);
            label4.TabIndex = 3;
            label4.Text = "PATIENT TYPE";
            // 
            // txtPatientName
            // 
            txtPatientName.Font = new Font("Segoe UI", 14.7F);
            txtPatientName.Location = new Point(280, 27);
            txtPatientName.Multiline = true;
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(476, 37);
            txtPatientName.TabIndex = 4;
            // 
            // txtPatientAge
            // 
            txtPatientAge.Font = new Font("Segoe UI", 14.7F);
            txtPatientAge.Location = new Point(280, 73);
            txtPatientAge.Multiline = true;
            txtPatientAge.Name = "txtPatientAge";
            txtPatientAge.Size = new Size(476, 37);
            txtPatientAge.TabIndex = 5;
            // 
            // cmbPatientType
            // 
            cmbPatientType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatientType.Font = new Font("Segoe UI", 15F);
            cmbPatientType.FormattingEnabled = true;
            cmbPatientType.Items.AddRange(new object[] { "Emergency", "Senior", "Pregnant", "Regular" });
            cmbPatientType.Location = new Point(280, 164);
            cmbPatientType.Name = "cmbPatientType";
            cmbPatientType.Size = new Size(476, 36);
            cmbPatientType.TabIndex = 6;
            // 
            // cmbReasonForVisit
            // 
            cmbReasonForVisit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReasonForVisit.Font = new Font("Segoe UI", 15F);
            cmbReasonForVisit.FormattingEnabled = true;
            cmbReasonForVisit.Items.AddRange(new object[] { "Appointment", "Vaccination", "Labour", "Treatment", "Check-Up/Testing" });
            cmbReasonForVisit.Location = new Point(280, 118);
            cmbReasonForVisit.Name = "cmbReasonForVisit";
            cmbReasonForVisit.Size = new Size(476, 36);
            cmbReasonForVisit.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(24, 213);
            button1.Name = "button1";
            button1.Size = new Size(109, 40);
            button1.TabIndex = 8;
            button1.Text = "ADD TO QUEUE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += QueueButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(647, 213);
            button2.Name = "button2";
            button2.Size = new Size(109, 40);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Clear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(83, 268);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 150);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbReasonForVisit);
            Controls.Add(cmbPatientType);
            Controls.Add(txtPatientAge);
            Controls.Add(txtPatientName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Clinic Queue Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPatientName;
        private TextBox txtPatientAge;
        private ComboBox cmbPatientType;
        private ComboBox cmbReasonForVisit;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
    }
}
