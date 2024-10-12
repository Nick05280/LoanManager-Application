using LoanManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManager.View
{
    public interface IEditView
    {
        int LoanID { get; }
        string LoanAmount { get; }
        string InterestRate { get; }
        string Terms { get; }
        DateTime LoanDate { get; }

        int CustomerID { get; }
        string ErrorMessage { set; }
        void DisplayCustomers(List<CustomerModel> customers);
        void ShowSuccessMessage(string message);
        void AddOrUpdateLoan();
    }
}
