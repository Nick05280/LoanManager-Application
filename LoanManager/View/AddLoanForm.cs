
using LoanManager.Models;
using LoanManager.Presenter;
using LoanManager.Services;
using LoanManager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManager
{
    public partial class AddLoanForm : Form, IAddLoanView
    {
        public event Action OnLoanAdded;
        private AddLoanPresenter loanPresenter;
        public AddLoanForm()
        {
            InitializeComponent();
            var loanService = new LoanService();
            var customerService = new CustomerService();
            loanPresenter = new AddLoanPresenter(this, loanService, customerService);
            comboBox_CustomerList.KeyUp += comboBox_CustomerList_KeyUp;
            LoadCustomers();
        }

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
            comboBox_CustomerList.DisplayMember = "CustomerName";
            comboBox_CustomerList.ValueMember = "CustomerID";
            comboBox_CustomerList.DataSource = customers;
        }

        private void LoadCustomers()
        {
            loanPresenter.LoadCustomers();
        }

        public void AddOrUpdateLoan()
        {
            if (loanPresenter.SaveLoan())
            {
                OnLoanAdded?.Invoke();
                this.Close();
            }
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            AddOrUpdateLoan();
        }

        private void comboBox_CustomerList_KeyUp(object sender, KeyEventArgs e)
        {
            string searchTerm = comboBox_CustomerList.Text;


            loanPresenter.LoadCustomers(searchTerm);


            comboBox_CustomerList.Text = searchTerm;


            comboBox_CustomerList.SelectionStart = searchTerm.Length;
        }
    }
}
