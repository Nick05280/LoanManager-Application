namespace LoanManager
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_LoanFilterByCustomer = new Button();
            button1 = new Button();
            comboBox_CustomerList = new ComboBox();
            panel1 = new Panel();
            btn_AddCustomer = new Button();
            dataGridView_LoanList = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LoanList).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btn_Delete);
            panel2.Controls.Add(btn_Edit);
            panel2.Controls.Add(btn_LoanFilterByCustomer);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox_CustomerList);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1199, 88);
            panel2.TabIndex = 8;
            // 
            // btn_Delete
            // 
            btn_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Delete.BackColor = Color.FromArgb(255, 49, 49);
            btn_Delete.FlatStyle = FlatStyle.Popup;
            btn_Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(1061, 17);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(108, 49);
            btn_Delete.TabIndex = 6;
            btn_Delete.Text = "Delete Loan";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Edit.BackColor = Color.FromArgb(255, 128, 0);
            btn_Edit.FlatStyle = FlatStyle.Flat;
            btn_Edit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Edit.ForeColor = Color.White;
            btn_Edit.Location = new Point(930, 17);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(108, 49);
            btn_Edit.TabIndex = 5;
            btn_Edit.Text = "Edit Loan";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_LoanFilterByCustomer
            // 
            btn_LoanFilterByCustomer.BackColor = Color.SkyBlue;
            btn_LoanFilterByCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LoanFilterByCustomer.ForeColor = Color.White;
            btn_LoanFilterByCustomer.Location = new Point(383, 17);
            btn_LoanFilterByCustomer.Name = "btn_LoanFilterByCustomer";
            btn_LoanFilterByCustomer.Size = new Size(160, 36);
            btn_LoanFilterByCustomer.TabIndex = 6;
            btn_LoanFilterByCustomer.Text = "Filter By Customer";
            btn_LoanFilterByCustomer.UseVisualStyleBackColor = false;
            btn_LoanFilterByCustomer.Click += btn_LoanFilterByCustomer_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.ForestGreen;
            button1.FlatAppearance.BorderColor = Color.ForestGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(790, 17);
            button1.Name = "button1";
            button1.Size = new Size(108, 49);
            button1.TabIndex = 4;
            button1.Text = "Add Loan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox_CustomerList
            // 
            comboBox_CustomerList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_CustomerList.FormattingEnabled = true;
            comboBox_CustomerList.Location = new Point(9, 17);
            comboBox_CustomerList.Name = "comboBox_CustomerList";
            comboBox_CustomerList.Size = new Size(350, 36);
            comboBox_CustomerList.TabIndex = 5;
            comboBox_CustomerList.KeyUp += comboBox_CustomerList_KeyUp;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_AddCustomer);
            panel1.Controls.Add(dataGridView_LoanList);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 483);
            panel1.TabIndex = 9;
            // 
            // btn_AddCustomer
            // 
            btn_AddCustomer.BackColor = Color.ForestGreen;
            btn_AddCustomer.Dock = DockStyle.Bottom;
            btn_AddCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddCustomer.ForeColor = Color.White;
            btn_AddCustomer.Location = new Point(0, 434);
            btn_AddCustomer.Name = "btn_AddCustomer";
            btn_AddCustomer.Size = new Size(1199, 49);
            btn_AddCustomer.TabIndex = 7;
            btn_AddCustomer.Text = "Add Customer";
            btn_AddCustomer.UseVisualStyleBackColor = false;
            btn_AddCustomer.Click += btn_AddCustomer_Click;
            // 
            // dataGridView_LoanList
            // 
            dataGridView_LoanList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_LoanList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_LoanList.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_LoanList.Location = new Point(74, 32);
            dataGridView_LoanList.Name = "dataGridView_LoanList";
            dataGridView_LoanList.RowHeadersWidth = 51;
            dataGridView_LoanList.RowTemplate.Height = 29;
            dataGridView_LoanList.Size = new Size(1063, 374);
            dataGridView_LoanList.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1199, 571);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_LoanList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btn_LoanFilterByCustomer;
        private ComboBox comboBox_CustomerList;
        private Panel panel1;
        private DataGridView dataGridView_LoanList;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button button1;
        private Button btn_AddCustomer;
    }
}