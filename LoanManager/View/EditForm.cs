using LoanManager.Models;
using LoanManager.Presenter;
using LoanManager.Services;
using LoanManager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManager
{
    public partial class EditForm : Form, IEditView
    {
        public event Action OnLoanAdded;
        private LoanModel loan;
        private EditPresenter editPresenter;
        public EditForm(LoanModel loan)
        {
            InitializeComponent();
            var loanService = new LoanService();
            var customerService = new CustomerService();
            editPresenter = new EditPresenter(this, loanService, customerService);
            this.loan = loan;
            LoadLoanDetails();
            LoadCustomerList();
        }
        public int LoanID => loan.loanID;

        public string LoanAmount => txtBox_LoanAmount.Text;
        public string InterestRate => txtBox_InterestRate.Text;
        public string Terms => txtBox_Term.Text;
        public DateTime LoanDate => dateTimepick_LoanDate.Value;

        public int CustomerID => (int)comboBox_CustomerList.SelectedValue;

        public string ErrorMessage
        {
            set => MessageBox.Show(value, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DisplayCustomers(List<CustomerModel> customers)
        {
            comboBox_CustomerList.DataSource = customers;
            comboBox_CustomerList.DisplayMember = "CustomerName";
            comboBox_CustomerList.ValueMember = "CustomerID";
            comboBox_CustomerList.SelectedValue = loan.customerID;
        }

        private void LoadLoanDetails()
        {
            comboBox_CustomerList.SelectedValue = loan.customerID;
            txtBox_LoanAmount.Text = loan.loanAmount.ToString();
            txtBox_InterestRate.Text = loan.interestRate.ToString();
            txtBox_Term.Text = loan.terms.ToString();
            dateTimepick_LoanDate.Value = loan.loanDate;
        }

        public void AddOrUpdateLoan()
        {
            if (editPresenter.UpdateLoan())
            {
                OnLoanAdded?.Invoke();
                this.Close();
            }
        }

        private void LoadCustomerList()
        {
            editPresenter.LoadCustomers();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            AddOrUpdateLoan();
        }
    }
}
