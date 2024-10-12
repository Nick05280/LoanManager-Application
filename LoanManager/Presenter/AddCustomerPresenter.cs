using LoanManager.Models;
using LoanManager.Services;
using LoanManager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LoanManager.Presenter
{
    public class AddCustomerPresenter
    {
        private readonly IAddCustomerView customerView;
        private readonly CustomerService customerService;

        public AddCustomerPresenter(IAddCustomerView view, CustomerService service)
        {
            customerView = view;
            customerService = service;
        }

        public bool AddCustomer()
        {
            var customer = new CustomerModel
            {
                customerName = customerView.CustomerName,
                email = customerView.Email,
                customerBirthday = customerView.CustomerBirthday,
            };

            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(customer);

            if (!Validator.TryValidateObject(customer, validationContext, validationResults, true))
            {
                var errorMessage = string.Join(Environment.NewLine, validationResults.Select(r => r.ErrorMessage));
                customerView.ErrorMessage = errorMessage;
                return false;
            }

            bool isCustomerAdded = customerService.AddCustomer(customer, ShowMessage);
            if (isCustomerAdded)
            {
                customerView.ShowSuccessMessage("Customer added successfully!");
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
