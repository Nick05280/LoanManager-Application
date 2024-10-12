using LoanManager.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace LoanManager.Services
{
    public class CustomerService
    {
        private string connectionString;

        public CustomerService()
        {
            var connectionStringSettings = ConfigurationManager.ConnectionStrings["LoanManager_Connection"];
            if (connectionStringSettings == null)
            {
                throw new Exception("Connection string 'LoanManager_Connection' not found in App.config.");
            }
            connectionString = connectionStringSettings.ConnectionString;
        }

        public List<CustomerModel> GetCustomers(Action<string> showMessage, string searchTerm = null)
        {
            var customers = new List<CustomerModel>();
            string query = "SELECT CustomerID, CustomerName FROM Customers";

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " WHERE CustomerName LIKE @searchTerm";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");
                    }

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var customer = new CustomerModel
                            {
                                CustomerID = reader.GetInt32(0),
                                CustomerName = reader.GetString(1)
                            };
                            customers.Add(customer);
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

            return customers;
        }

        public bool AddCustomer(CustomerModel customer, Action<string> showMessage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Customers (CustomerName, CustomerBirthDay, Email) " +
                                   "VALUES (@CustomerName, @CustomerBirthday, @Email)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", customer.customerName);
                        cmd.Parameters.AddWithValue("@CustomerBirthday", customer.customerBirthday);
                        cmd.Parameters.AddWithValue("@Email", customer.email);

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
    }

}

