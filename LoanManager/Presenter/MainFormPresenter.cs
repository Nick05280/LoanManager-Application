using LoanManager.Models;
using LoanManager.Services;
using LoanManager.View;
using System.Collections.Generic;

namespace LoanManager.Presenter
{
    public class MainFormPresenter
    {
        private readonly IMainFormView mainFormView;
        private readonly LoanService loanService;
        private readonly CustomerService customerService;

        public MainFormPresenter(IMainFormView view, LoanService loanService, CustomerService customerService)
        {
            mainFormView = view;
            this.loanService = loanService;
            this.customerService = customerService;
        }

        public void LoadLoans()
        {
            var loans = loanService.GetLoans(ShowMessage);
            mainFormView.DisplayLoans(loans);
        }

        public void LoadCustomers(string searchTerm = null)
        {
            var customers = customerService.GetCustomers(ShowMessage, searchTerm);
            mainFormView.DisplayCustomers(customers);
        }

        public bool DeleteSelectedLoan(int loanID)
        {
            return loanService.DeleteLoan(loanID, ShowMessage);
        }


        private void ShowMessage(string message)
        {
            mainFormView.ShowMessage(message);
        }

        public void LoadLoansByCustomerId(int customerID)
        {
            var loans = loanService.GetLoansByCustomerId(customerID, ShowMessage);
            mainFormView.DisplayLoans(loans);
        }

       





    }
}
