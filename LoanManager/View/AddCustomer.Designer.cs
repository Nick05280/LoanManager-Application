namespace LoanManager
{
    partial class AddCustomer
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
            panel1 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            btn_Save = new Button();
            panel4 = new Panel();
            dateTimepick_Bday = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            txtBox_Email = new TextBox();
            label1 = new Label();
            txtBox_CustomerName = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label4 = new Label();
            lbl_age = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 514);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lbl_age);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(dateTimepick_Bday);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtBox_Email);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txtBox_CustomerName);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 90);
            panel5.Name = "panel5";
            panel5.Size = new Size(942, 424);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(btn_Save);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 279);
            panel6.Name = "panel6";
            panel6.Size = new Size(942, 98);
            panel6.TabIndex = 10;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.ForestGreen;
            btn_Save.Dock = DockStyle.Top;
            btn_Save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(0, 0);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(942, 49);
            btn_Save.TabIndex = 6;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 377);
            panel4.Name = "panel4";
            panel4.Size = new Size(942, 47);
            panel4.TabIndex = 9;
            // 
            // dateTimepick_Bday
            // 
            dateTimepick_Bday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimepick_Bday.Format = DateTimePickerFormat.Short;
            dateTimepick_Bday.Location = new Point(255, 189);
            dateTimepick_Bday.Name = "dateTimepick_Bday";
            dateTimepick_Bday.Size = new Size(655, 34);
            dateTimepick_Bday.TabIndex = 8;
            dateTimepick_Bday.Value = new DateTime(2024, 9, 24, 14, 59, 6, 0);
            dateTimepick_Bday.ValueChanged += dateTimepick_Bday_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 194);
            label5.Name = "label5";
            label5.Size = new Size(174, 28);
            label5.TabIndex = 7;
            label5.Text = "Customer Birthday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(181, 112);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // txtBox_Email
            // 
            txtBox_Email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Email.Location = new Point(255, 109);
            txtBox_Email.Name = "txtBox_Email";
            txtBox_Email.Size = new Size(655, 34);
            txtBox_Email.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 47);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 1;
            label1.Text = "Customer Name";
            // 
            // txtBox_CustomerName
            // 
            txtBox_CustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_CustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_CustomerName.Location = new Point(255, 44);
            txtBox_CustomerName.Name = "txtBox_CustomerName";
            txtBox_CustomerName.Size = new Size(655, 34);
            txtBox_CustomerName.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(942, 21);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 69);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(210, 41);
            label2.TabIndex = 9;
            label2.Text = "Add Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(193, 238);
            label4.Name = "label4";
            label4.Size = new Size(47, 28);
            label4.TabIndex = 11;
            label4.Text = "Age";
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_age.Location = new Point(255, 238);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(59, 28);
            lbl_age.TabIndex = 12;
            lbl_age.Text = "Value";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 514);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Customer Form";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private DateTimePicker dateTimepick_Bday;
        private Label label5;
        private Button btn_Save;
        private Label label3;
        private TextBox txtBox_Email;
        private Label label1;
        private TextBox txtBox_CustomerName;
        private Label label2;
        private Panel panel6;
        private Panel panel4;
        private Label label4;
        private Label lbl_age;
    }
}