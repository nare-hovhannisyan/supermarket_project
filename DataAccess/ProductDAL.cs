using System.Runtime.InteropServices;
using Thenewwebapi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Thenewwebapi.DataAccess
{
    public class ProductDAL
    {
        private int rowsAffected { get; set; }
        public string ResultText { get; set; }

        public void InsertPeople(People people)
        {
            Console.WriteLine(people.name + " " + people.age + "   " + people.ID);
            rowsAffected = 0;

            // Create SQL statement to submit
            string sql = "INSERT INTO People(name, age, ID)";
            sql += $" VALUES('{people.name}', {people.age}, {people.ID});";

            try
            {
                // Create SQL connection object in using block for automatic closing and disposing
                using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, cnn); 
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                    ResultText = "Rows Affected: " + rowsAffected.ToString();
                }
            }
            catch (Exception ex)
            {
                ResultText = ex.ToString();
            }
        }

        public string GetPeople() {
          
            
            string sql = "SELECT * FROM Products FOR JSON path , root ('people')";
            using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    // Open the connection
                    cnn.Open();
                    var jsonResult = new StringBuilder();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                    jsonResult.Append(reader.GetValue(0).ToString());
                    }
                    // Execute command
                     return jsonResult.ToString();
                    //Console.WriteLine(jsonResult.ToString());
                }
            }
         


        }
       

        public string GetProducts() {
             string sql = "SELECT * FROM Products FOR JSON path , root ('products')";
            using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
            {
                // Create command object
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    // Open the connection
                    cnn.Open();
                    var jsonResult = new StringBuilder();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                    jsonResult.Append(reader.GetValue(0).ToString());
                    }
                    // Execute command
                    return jsonResult.ToString();
                }
            }
        }
    }
}