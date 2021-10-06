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
    public partial class firstwebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbconnectionSalesman dbConnection = new dbconnectionSalesman();
            DataTable dtSalesmanResult = dbConnection.GetSalesman();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string salesmanid = "";
            string salesmanname = "";
            string salesmancity = "";
            string commission = "";
            salesmanid = txtsalesmanid.Text;
            salesmanname = txtsalesmanname.Text;
            salesmancity = txtSalesmancity.Text;
            commission = txtSalesmancommision.Text;
            dbconnectionSalesman dbObj = new dbconnectionSalesman();
            dbObj.InsertSalesman(salesmanid, salesmanname, salesmancity, commission);

            DataTable dtSalesmanResult = dbObj.GetSalesman();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();

            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
        protected void gvSalesmanDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int salesmanid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                dbconnectionSalesman dbConnection = new dbconnectionSalesman();
                DataTable dt = dbConnection.GetSalesmanById(salesmanid);
                txtsalesmanname.Text = dt.Rows[0][1].ToString();
                txtSalesmancity.Text = dt.Rows[0][2].ToString();
                txtSalesmancommision.Text = dt.Rows[0][3].ToString();
                txtsalesmanid.Text = dt.Rows[0][0].ToString();
            }
            else if(e.CommandName == "Delete")
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source = LAPTOP-TG0AKH7V\SQLEXPRESS; Initial Catalog = sales; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand("delete from salesman where salesman_id =" + salesmanid +"", sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                dbconnectionSalesman dbObj = new dbconnectionSalesman();
                DataTable dtSalesmanResult = dbObj.GetSalesman();
                gvSalesmanDetails.DataSource = dtSalesmanResult;
                gvSalesmanDetails.DataBind();


            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dbconnectionSalesman dbConnection = new dbconnectionSalesman();
            dbConnection.UpdateSalesman(txtsalesmanid.Text, txtsalesmanname.Text, txtSalesmancity.Text, txtSalesmancommision.Text);
            DataTable dtSalesmanResult = dbConnection.GetSalesman();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();
        }

        protected void gvSalesmanDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvSalesmanDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}