using LoanManager.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LoanManager.Services
{
    public class LoanService
    {
        private string connectionString;

        public LoanService()
        {
            var connectionStringSettings = ConfigurationManager.ConnectionStrings["LoanManager_Connection"];
            if (connectionStringSettings == null)
            {
                throw new Exception("Connection string 'LoanManager_Connection' not found in App.config.");
            }
            connectionString = connectionStringSettings.ConnectionString;
        }

        public bool AddOrUpdateLoan(LoanModel loan, Action<string> showMessage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AddOrUpdateLoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("@LoanID", loan.loanID == 0 ? (object)DBNull.Value : loan.loanID);
                        cmd.Parameters.AddWithValue("@LoanAmount", loan.loanAmount);
                        cmd.Parameters.AddWithValue("@InterestRate", loan.interestRate);
                        cmd.Parameters.AddWithValue("@Terms", loan.terms);
                        cmd.Parameters.AddWithValue("@LoanDate", loan.loanDate.Date);
                        cmd.Parameters.AddWithValue("@CustomerID", loan.customerID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                showMessage($"Database error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                showMessage($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public List<LoanModel> GetLoans(Action<string> showMessage)
        {
            var loans = new List<LoanModel>();
            string query = @"
    SELECT 
        l.LoanID, 
        l.LoanAmount, 
        l.InterestRate, 
        l.Terms, 
        l.LoanDate, 
        l.CustomerID, 
        c.CustomerName,
        dbo.fn_TotalPayable(l.LoanAmount, l.Terms, l.InterestRate) AS TotalPayable
    FROM 
        Loans l
    INNER JOIN 
        Customers c ON l.CustomerID = c.CustomerID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var loan = new LoanModel
                            {
                                loanID = reader.GetInt32(0),
                                loanAmount = reader.GetDecimal(1),
                                interestRate = reader.GetDecimal(2),
                                terms = reader.GetInt32(3),
                                loanDate = reader.GetDateTime(4),
                                customerID = reader.GetInt32(5),
                                CustomerName = reader.GetString(6),
                                totalPayable = reader.GetDecimal(7)
                            };
                            loans.Add(loan);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                showMessage($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                showMessage($"An error occurred: {ex.Message}");
            }

            return loans;
        }


        public bool DeleteLoan(int loanID, Action<string> showMessage)
        {
            string query = "DELETE FROM Loans WHERE LoanID = @LoanID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoanID", loanID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        showMessage("Loan not found or could not be deleted.");
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                showMessage($"Database error: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                showMessage($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public List<LoanModel> GetLoansByCustomerId(int customerID, Action<string> showMessage)
        {
            var loans = new List<LoanModel>();
            string query = @"
    SELECT 
        l.LoanID, 
        l.LoanAmount, 
        l.InterestRate, 
        l.Terms, 
        l.LoanDate, 
        l.CustomerID, 
        c.CustomerName,
        dbo.fn_TotalPayable(l.LoanAmount, l.Terms, l.InterestRate) AS TotalPayable
    FROM 
        Loans l
    LEFT JOIN 
        Customers c ON l.CustomerID = c.CustomerID
    WHERE 
        l.CustomerID = @CustomerID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var loan = new LoanModel
                            {
                                loanID = reader.GetInt32(0),
                                loanAmount = reader.GetDecimal(1),
                                interestRate = reader.GetDecimal(2),
                                terms = reader.GetInt32(3),
                                loanDate = reader.GetDateTime(4),
                                customerID = reader.GetInt32(5),
                                CustomerName = reader.IsDBNull(6) ? null : reader.GetString(6),
                                totalPayable = reader.GetDecimal(7)
                            };
                            loans.Add(loan);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                showMessage($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                showMessage($"An error occurred: {ex.Message}");
            }

            return loans;
        }



    }

}
