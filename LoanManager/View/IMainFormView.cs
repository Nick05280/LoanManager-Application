using LoanManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManager.View
{
    public interface IMainFormView 
    {
        void DisplayLoans(List<LoanModel> loans);
        void ShowMessage(string message);

        bool ConfirmLoanDeletion();

        void DisplayCustomers(List<CustomerModel> customers);
    }
}
