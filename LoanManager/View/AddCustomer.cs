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
    public partial class AddCustomer : Form, IAddCustomerView
    {
        public event Action OnLoanAdded;
        private AddCustomerPresenter addCustomerPresenter;
        public AddCustomer()
        {
            InitializeComponent();
            var customerService = new CustomerService();
            addCustomerPresenter = new AddCustomerPresenter(this, customerService);
            dateTimepick_Bday.MaxDate = DateTime.Now;
        }

        public string CustomerName => txtBox_CustomerName.Text;
        public string Email => txtBox_Email.Text;
        public DateTime CustomerBirthday => dateTimepick_Bday.Value.Date;

        public string ErrorMessage
        {
            set => MessageBox.Show(value, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (addCustomerPresenter.AddCustomer())
            {
                OnLoanAdded.Invoke();
                this.Close();
            }
        }

        private void dateTimepick_Bday_ValueChanged(object sender, EventArgs e)
        {
            // int Age = DateTime.Today.Year - dateTimepick_Bday.Value.Year;
            int age = DateTime.Now.Year - dateTimepick_Bday.Value.Year - (DateTime.Now.DayOfYear < dateTimepick_Bday.Value.DayOfYear ? 1 : 0);

            lbl_age.Text = age.ToString();
        }
    }
}
