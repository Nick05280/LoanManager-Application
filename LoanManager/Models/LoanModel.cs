using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LoanManager.Models
{
    public class LoanModel
    {
        private int LoanID;
        private decimal LoanAmount;
        private decimal InterestRate;
        private int Terms;
        private DateTime LoanDate;
        private int CustomerID;
        public string CustomerName { get; set; }
        public decimal totalPayable { get; set; }

        [Key]
        [DisplayName("Loan ID")]
        public int loanID
        {
            get { return LoanID; } 
            set { LoanID = value; }
        }

        [DisplayName("Loan Amount")]
        [Required(ErrorMessage = "Loan amount is required.")]
        [Range(0.01, 9999999999999999.99, ErrorMessage = "Loan amount must be a positive value.")]

        public decimal loanAmount
        {
            get { return LoanAmount; }
            set { LoanAmount = value; }
        }

        [DisplayName("Interest Rate")]
        [Required(ErrorMessage = "Interest rate is required.")]
        [Range(0.01, 999.99, ErrorMessage = "Interest rate must be a positive value between 0.01 and 999.99.")]
        public decimal interestRate
        {
            get { return InterestRate; }
            set { InterestRate = value; }
        }

        [DisplayName("Terms")]
        [Required(ErrorMessage = "Terms are required.")]
        [Range(1, 999, ErrorMessage = "Terms must be between 1 and 999.")]
        public int terms
        {
            get { return Terms; }
            set { Terms = value; }
        }

        [DisplayName("Loan Date")]
        [Required(ErrorMessage = "Loan date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Loan date must be a valid date.")]
        public DateTime loanDate
        {
            get { return LoanDate; }
            set { LoanDate = value; }
        }

        [DisplayName("Customer ID")]
        [Required(ErrorMessage = "CustomerID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "CustomerID must be a positive integer.")]
        public int customerID
        {
            get { return CustomerID; }
            set { CustomerID = value; }
        }

       
       




    }
}
