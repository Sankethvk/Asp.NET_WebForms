using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace FirstWeb
{
    public class dbconnectionSalesman
    {
        public void InsertSalesman(string salesman_id,string name,string city,string commission)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("insert into salesman values('" + salesman_id + "','" + name + "','" + city + "'," + commission + ")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetSalesman()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from salesman", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr =  sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;

        }
        public void UpdateSalesman(string salesman_id, string name, string city, string commission)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("update salesman set salesman_id = '" + salesman_id + "',name='" + name + "' , city='" + city + "' , commission=" + commission + " where salesman_id=" + salesman_id + "", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetSalesmanById(int salesman_id)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from salesman where salesman_id=" + salesman_id + "", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
    }
}