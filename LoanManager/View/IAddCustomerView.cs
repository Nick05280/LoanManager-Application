using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManager.View
{
    public interface IAddCustomerView
    {
        string CustomerName { get; }
        string Email { get; }
        DateTime CustomerBirthday { get; }

        string ErrorMessage { set; }
        void ShowSuccessMessage(string message);
    }
}
