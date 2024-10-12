using LoanManager.Models;
using LoanManager.Services;
using LoanManager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManager.Presenter
{
    public class EditPresenter
    {
        private readonly IEditView editView;
        private readonly LoanService loanService;
        private readonly CustomerService customerService;

        public EditPresenter(IEditView view, LoanService loanService, CustomerService customerService)
        {
            this.editView = view;
            this.loanService = loanService;
            this.customerService = customerService;
        }

        public void LoadCustomers(string searchTerm = null)
        {
            var customers = customerService.GetCustomers(ShowMessage, searchTerm);
            editView.DisplayCustomers(customers);
        }

        public bool UpdateLoan()
        {
            if (!decimal.TryParse(editView.LoanAmount, out decimal loanAmount))
            {
                editView.ErrorMessage = "Loan amount must be a valid number.";
                return false;
            }

            if (!decimal.TryParse(editView.InterestRate, out decimal interestRate))
            {
                editView.ErrorMessage = "Interest rate must be a valid number.";
                return false;
            }

            if (!int.TryParse(editView.Terms, out int terms))
            {
                editView.ErrorMessage = "Terms must be a valid integer.";
                return false;
            }

            var loan = new LoanModel
            {
                loanID = editView.LoanID,
                loanAmount = loanAmount,
                interestRate = interestRate,
                terms = terms,
                loanDate = editView.LoanDate,
                customerID = editView.CustomerID,
            };

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(loan);

            if (!Validator.TryValidateObject(loan, validationContext, validationResults, true))
            {
                var errorMessage = string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
                editView.ErrorMessage = errorMessage;
                return false;
            }


            bool isLoanAdded = loanService.AddOrUpdateLoan(loan, ShowMessage);
            if (isLoanAdded)
            {
                editView.ShowSuccessMessage("Loan updated successfully!");
                return true;
            }

            return false;
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       
    }
}
