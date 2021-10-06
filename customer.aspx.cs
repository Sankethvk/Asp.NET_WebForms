using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace FirstWeb
{
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dBconnectionCustomer dbConnection = new dBconnectionCustomer();
            DataTable dtSalesmanResult = dbConnection.getCustomer();
            gridviewCustomer.DataSource = dtSalesmanResult;
            gridviewCustomer.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string customer_id = "";
            string cust_name = "";
            string city = "";
            string grade = "";
            string salesman_id = "";
            customer_id = txtcustid.Text;
            cust_name = txtcust_name.Text;
            city = txtcity.Text;
            grade = txtgrade.Text;
            salesman_id = txtsalesman_id.Text;
            dBconnectionCustomer obj = new dBconnectionCustomer();
            obj.InsertCustomer(customer_id, cust_name, city, grade, salesman_id);

            DataTable dtCustomerResult = obj.getCustomer();
            gridviewCustomer.DataSource = dtCustomerResult;
            gridviewCustomer.DataBind();


        }

        protected void gridviewCustomer_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int customer_id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                dBconnectionCustomer dbConnection = new dBconnectionCustomer();
                DataTable dt = dbConnection.GetCustomerBYcustomer_id(customer_id);
                txtcust_name.Text = dt.Rows[0][1].ToString();
                txtcity.Text = dt.Rows[0][2].ToString();
                txtgrade.Text = dt.Rows[0][3].ToString();
                txtsalesman_id.Text = dt.Rows[0][4].ToString();
                txtcustid.Text = dt.Rows[0][0].ToString();
            }
            else if (e.CommandName == "Delete")
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand("delete from customer where customer_id =" + customer_id + "", sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                dBconnectionOrders dbObj = new dBconnectionOrders();
                DataTable dtCustomerResult = dbObj.getOrders();
                gridviewCustomer.DataSource = dtCustomerResult;
                gridviewCustomer.DataBind();


            }
        }

        protected void gridviewCustomer_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gridviewCustomer_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dBconnectionCustomer dbConnection = new dBconnectionCustomer();
            dbConnection.UpdateCustomer(txtcustid.Text, txtcust_name.Text, txtcity.Text, txtgrade.Text, txtsalesman_id.Text);
            DataTable dtSalesmanResult = dbConnection.getCustomer();
            gridviewCustomer.DataSource = dtSalesmanResult;
            gridviewCustomer.DataBind();
        }
    }
}