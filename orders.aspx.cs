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
    public partial class orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dBconnectionOrders dbConnection = new dBconnectionOrders();
            DataTable dtSalesmanResult = dbConnection.getOrders();
            gridvieworder.DataSource = dtSalesmanResult;
            gridvieworder.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ord_no = "";
            string purch_amt = "";
            string ord_date = "";
            string customer_id = "";
            string salesman_id = "";
            ord_no = txtordernumber.Text;
            purch_amt = txtpurchaseamt.Text;
            ord_date = txtOrderdate.Text;
            customer_id = txtcustid.Text;
            salesman_id = txtsalesmanid.Text;
            dBconnectionOrders obj = new dBconnectionOrders();
            obj.InsertOrders(ord_no, purch_amt, ord_date, customer_id, salesman_id);

            DataTable dtOrderResult = obj.getOrders();
            gridvieworder.DataSource = dtOrderResult;
            gridvieworder.DataBind();

        }

        protected void gridvieworder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gridvieworder_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int ord_no = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                dBconnectionOrders dbConnection = new dBconnectionOrders();
                DataTable dt = dbConnection.GetOrdersByord_no(ord_no);
                txtpurchaseamt.Text = dt.Rows[0][1].ToString();
                txtOrderdate.Text = dt.Rows[0][2].ToString();
                txtcustid.Text = dt.Rows[0][3].ToString();
                txtsalesmanid.Text = dt.Rows[0][4].ToString();
                txtordernumber.Text = dt.Rows[0][0].ToString();
            }
            else if (e.CommandName == "Delete")
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand("delete from orders where ord_no =" + ord_no + "", sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                dBconnectionOrders dbObj = new dBconnectionOrders();
                DataTable dtSalesmanResult = dbObj.getOrders();
                gridvieworder.DataSource = dtSalesmanResult;
                gridvieworder.DataBind();


            }

        }

        protected void gridvieworder_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gridvieworder_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dBconnectionOrders dbConnection = new dBconnectionOrders();
            dbConnection.UpdateOrders(txtordernumber.Text, txtpurchaseamt.Text, txtOrderdate.Text, txtcustid.Text,txtsalesmanid.Text);
            DataTable dtOrdersResult = dbConnection.getOrders();
            gridvieworder.DataSource = dtOrdersResult;
            gridvieworder.DataBind();
        }
    }
}