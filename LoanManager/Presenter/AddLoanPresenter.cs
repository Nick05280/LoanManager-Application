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
    public class AddLoanPresenter
    {
        private readonly IAddLoanView loanView;
        private readonly LoanService loanService;
        private readonly CustomerService customerService;

        public AddLoanPresenter(IAddLoanView view, LoanService service, CustomerService customerService) 
        {
            loanView = view;
            loanService = service;
            this.customerService = customerService;
        }

        public bool SaveLoan()
        {
            if (!decimal.TryParse(loanView.LoanAmount, out decimal loanAmount))
            {
                loanView.ErrorMessage = "Loan amount must be a valid number.";
                return false;
            }

            if (!decimal.TryParse(loanView.InterestRate, out decimal interestRate))
            {
                loanView.ErrorMessage = "Interest rate must be a valid number.";
                return false; 
            }

            if (!int.TryParse(loanView.Terms, out int terms))
            {
                loanView.ErrorMessage = "Terms must be a valid integer.";
                return false; 
            }

            var loan = new LoanModel
            {
                loanAmount = loanAmount,
                interestRate = interestRate,
                terms = terms,
                loanDate = loanView.LoanDate,
                customerID = loanView.CustomerID,
            };

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(loan);

            if (!Validator.TryValidateObject(loan, validationContext, validationResults, true))
            {
                var errorMessage = string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
                loanView.ErrorMessage = errorMessage;
                return false; 
            }

            
            bool isLoanAdded = loanService.AddOrUpdateLoan(loan, ShowMessage);
            if (isLoanAdded)
            {
                loanView.ShowSuccessMessage("Loan added successfully!");
                return true; 
            }

            return false; 
        }

        public void LoadCustomers(string searchTerm = null)
        {
            var customers = customerService.GetCustomers(ShowMessage, searchTerm);
            loanView.DisplayCustomers(customers);
        }
        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
