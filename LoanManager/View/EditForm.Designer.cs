namespace LoanManager
{
    partial class EditForm
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
            dateTimepick_LoanDate = new DateTimePicker();
            label5 = new Label();
            btn_Save = new Button();
            label4 = new Label();
            txtBox_Term = new TextBox();
            label3 = new Label();
            txtBox_InterestRate = new TextBox();
            label1 = new Label();
            txtBox_LoanAmount = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            comboBox_CustomerList = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
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
            panel5.Controls.Add(dateTimepick_LoanDate);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(btn_Save);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtBox_Term);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtBox_InterestRate);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txtBox_LoanAmount);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 90);
            panel5.Name = "panel5";
            panel5.Size = new Size(942, 424);
            panel5.TabIndex = 3;
            // 
            // dateTimepick_LoanDate
            // 
            dateTimepick_LoanDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimepick_LoanDate.Format = DateTimePickerFormat.Short;
            dateTimepick_LoanDate.Location = new Point(176, 246);
            dateTimepick_LoanDate.Name = "dateTimepick_LoanDate";
            dateTimepick_LoanDate.Size = new Size(742, 34);
            dateTimepick_LoanDate.TabIndex = 8;
            dateTimepick_LoanDate.Value = new DateTime(2024, 9, 24, 14, 59, 6, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 246);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 7;
            label5.Text = "Loan Date";
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.ForestGreen;
            btn_Save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(3, 312);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(936, 49);
            btn_Save.TabIndex = 6;
            btn_Save.Text = "Update";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(88, 176);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 5;
            label4.Text = "Term";
            // 
            // txtBox_Term
            // 
            txtBox_Term.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_Term.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Term.Location = new Point(176, 179);
            txtBox_Term.Name = "txtBox_Term";
            txtBox_Term.Size = new Size(742, 34);
            txtBox_Term.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 109);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 3;
            label3.Text = "Interest Rate";
            // 
            // txtBox_InterestRate
            // 
            txtBox_InterestRate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_InterestRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_InterestRate.Location = new Point(176, 109);
            txtBox_InterestRate.Name = "txtBox_InterestRate";
            txtBox_InterestRate.Size = new Size(742, 34);
            txtBox_InterestRate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 1;
            label1.Text = "Loan Amount";
            // 
            // txtBox_LoanAmount
            // 
            txtBox_LoanAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_LoanAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_LoanAmount.Location = new Point(176, 44);
            txtBox_LoanAmount.Name = "txtBox_LoanAmount";
            txtBox_LoanAmount.Size = new Size(742, 34);
            txtBox_LoanAmount.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(942, 21);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(comboBox_CustomerList);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 69);
            panel2.TabIndex = 1;
            // 
            // comboBox_CustomerList
            // 
            comboBox_CustomerList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_CustomerList.FormattingEnabled = true;
            comboBox_CustomerList.Location = new Point(176, 15);
            comboBox_CustomerList.Name = "comboBox_CustomerList";
            comboBox_CustomerList.Size = new Size(742, 36);
            comboBox_CustomerList.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 2;
            label2.Text = "Customer Name:";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 514);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Loan Form";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panel5;
        private DateTimePicker dateTimepick_LoanDate;
        private Label label5;
        private Button btn_Save;
        private Label label4;
        private TextBox txtBox_Term;
        private Label label3;
        private TextBox txtBox_InterestRate;
        private Label label1;
        private TextBox txtBox_LoanAmount;
        private ComboBox comboBox_CustomerList;
    }
}