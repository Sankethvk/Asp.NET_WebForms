using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace FirstWeb
{
    public class dBconnectionCustomer
    {
        public void InsertCustomer(string customer_id, string cust_name, string city, string grade, string salesman_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("insert into customer values('" + customer_id + "','" + cust_name + "','" + city + "','" + grade + "','" + salesman_id + "')", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable getCustomer()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from customer", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;

        }
        public void UpdateCustomer(string customer_id, string cust_name, string city, string grade, string salesman_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("update customer set customer_id = '" + customer_id + "',cust_name='" + cust_name + "' , city='" + city + "' , grade='" + grade + "',salesman_id=" + salesman_id + " where customer_id =" + customer_id + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetCustomerBYcustomer_id(int customer_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from customer where customer_id=" + customer_id+ "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }


    }
}