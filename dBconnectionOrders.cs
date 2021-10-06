using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace FirstWeb
{
    public class dBconnectionOrders
    {
        public void InsertOrders(string ord_no, string purch_amt, string ord_date, string customer_id,string salesman_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("insert into orders values('" + ord_no + "'," + purch_amt + ",'" + ord_date + "','" + customer_id +"','" +salesman_id+ "')", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable getOrders()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from orders", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;

        }
        public void UpdateOrders(string ord_no, string purch_amt, string ord_date, string customer_id, string salesman_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("update orders set ord_no = '" + ord_no + "',purch_amt='" + purch_amt + "' , ord_date='" + ord_date + "' , customer_id='" + customer_id + "',salesman_id="+salesman_id+" where ord_no =" + ord_no + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetOrdersByord_no(int ord_no)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from orders where ord_no=" + ord_no+ "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
    }
}