using LoanManager.Models;
using LoanManager.Presenter;
using LoanManager.Services;
using LoanManager.View;

namespace LoanManager
{
    public partial class MainForm : Form, IMainFormView
    {
        private readonly MainFormPresenter mainFormPresenter;
        private readonly LoanService loanService;
        private readonly CustomerService customerService;
        public MainForm()
        {
            InitializeComponent();
            loanService = new LoanService();
            customerService = new CustomerService();
            mainFormPresenter = new MainFormPresenter(this, loanService, customerService);
            dataGridView_LoanList.AutoGenerateColumns = true;
            dataGridView_LoanList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comboBox_CustomerList.KeyUp += comboBox_CustomerList_KeyUp;
            DefineDataGridViewColumns();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLoanForm addEditLoanForm = new AddLoanForm();
            addEditLoanForm.OnLoanAdded += RefreshLoanList;
            addEditLoanForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainFormPresenter.LoadLoans();
            mainFormPresenter.LoadCustomers();
        }

        public void DisplayLoans(List<LoanModel> loans)
        {
            dataGridView_LoanList.DataSource = loans;
            dataGridView_LoanList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void RefreshLoanList()
        {
            mainFormPresenter.LoadLoans();
        }

        public void RefreshCustomerList()
        {
            mainFormPresenter.LoadCustomers();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_LoanList.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_LoanList.SelectedRows[0];
                int loanID = Convert.ToInt32(selectedRow.Cells["LoanID"].Value);

                if (ConfirmLoanDeletion())
                {
                    if (mainFormPresenter.DeleteSelectedLoan(loanID))
                    {
                        MessageBox.Show("Loan deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshLoanList();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete loan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a loan to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ConfirmLoanDeletion()
        {
            var result = MessageBox.Show("Are you sure you want to delete this loan?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        public void DisplayCustomers(List<CustomerModel> customers)
        {
            var emptyCustomer = new CustomerModel
            {
                CustomerID = 0,
                CustomerName = string.Empty
            };

            customers.Insert(0, emptyCustomer);

            comboBox_CustomerList.DisplayMember = "CustomerName";
            comboBox_CustomerList.ValueMember = "CustomerID";
            comboBox_CustomerList.DataSource = customers;

            comboBox_CustomerList.SelectedIndex = 0;
            comboBox_CustomerList.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void btn_LoanFilterByCustomer_Click(object sender, EventArgs e)
        {
            if (comboBox_CustomerList.SelectedValue is int customerID)
            {

                if (customerID == 0)
                {
                    mainFormPresenter.LoadLoans();
                }
                else
                {
                    mainFormPresenter.LoadLoansByCustomerId(customerID);
                }
            }
        }

        private void comboBox_CustomerList_KeyUp(object sender, KeyEventArgs e)
        {
            string searchTerm = comboBox_CustomerList.Text;

            mainFormPresenter.LoadCustomers(searchTerm);
            comboBox_CustomerList.Text = searchTerm;
            comboBox_CustomerList.SelectionStart = searchTerm.Length;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_LoanList.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView_LoanList.SelectedRows[0];

                var loan = new LoanModel
                {
                    loanID = Convert.ToInt32(selectedRow.Cells["LoanID"].Value),
                    customerID = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value),
                    loanAmount = Convert.ToDecimal(selectedRow.Cells["LoanAmount"].Value),
                    interestRate = Convert.ToDecimal(selectedRow.Cells["InterestRate"].Value),
                    terms = Convert.ToInt32(selectedRow.Cells["Terms"].Value),
                    loanDate = Convert.ToDateTime(selectedRow.Cells["LoanDate"].Value),
                    CustomerName = selectedRow.Cells["CustomerName"].Value.ToString()
                };

                EditForm editLoanForm = new EditForm(loan);
                editLoanForm.OnLoanAdded += RefreshLoanList;
                editLoanForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a loan to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();
            addCustomerForm.OnLoanAdded += RefreshCustomerList;
            addCustomerForm.ShowDialog();
        }

        private void DefineDataGridViewColumns()
        {

            dataGridView_LoanList.Columns.Clear();
            var loanIDColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LoanID",
                HeaderText = "Loan ID",
                Name = "LoanID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView_LoanList.Columns.Add(loanIDColumn);


            var customerNameColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Customer Name",
                Name = "CustomerName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView_LoanList.Columns.Add(customerNameColumn);


            var customerIDColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerID",
                HeaderText = "Customer ID",
                Name = "CustomerID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView_LoanList.Columns.Add(customerIDColumn);


            var loanAmountColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LoanAmount",
                HeaderText = "Loan Amount",
                Name = "LoanAmount",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView_LoanList.Columns.Add(loanAmountColumn);


            var interestRateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InterestRate",
                HeaderText = "Interest Rate",
                Name = "InterestRate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView_LoanList.Columns.Add(interestRateColumn);


            var termsColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Terms",
                HeaderText = "Terms",
                Name = "Terms",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView_LoanList.Columns.Add(termsColumn);


            var loanDateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LoanDate",
                HeaderText = "Loan Date",
                Name = "LoanDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView_LoanList.Columns.Add(loanDateColumn);


            var totalPayableColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPayable",
                HeaderText = "Total Payable",
                Name = "TotalPayable",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dataGridView_LoanList.Columns.Add(totalPayableColumn);
        }
    }

}