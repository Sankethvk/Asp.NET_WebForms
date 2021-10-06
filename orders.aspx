<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orders.aspx.cs" Inherits="FirstWeb.orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order details</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                <td> Order number : </td><td>
                <asp:TextBox ID="txtordernumber" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td> Purchase Amount : </td><td>
                <asp:TextBox ID="txtpurchaseamt" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                    <td> Order Date : </td><td>
                        <asp:TextBox ID="txtOrderdate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> Customer Id : </td><td>
                        <asp:TextBox ID="txtcustid" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> Salesman Id : </td><td>
                        <asp:TextBox ID="txtsalesmanid" runat="server"></asp:TextBox></td>
                </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click"  />
                    <asp:Button ID="Button2" runat="server" Text="Reset"  />

                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />

                </td>
            </tr>
                
        </table>
            <div>
                    <asp:GridView ID="gridvieworder" runat="server" AutoGenerateColumns="False" OnRowCommand="gridvieworder_RowCommand" OnRowDeleting="gridvieworder_RowDeleting" OnRowEditing="gridvieworder_RowEditing" OnSelectedIndexChanged="gridvieworder_SelectedIndexChanged" >
                        <Columns>
                            <asp:BoundField DataField="ord_no" HeaderText="order number" />
                            <asp:BoundField DataField="purch_amt" HeaderText="purchase amount" />
                            <asp:BoundField DataField="ord_date" HeaderText="order date" />
                            <asp:BoundField DataField="customer_id" HeaderText="customer id" />
                            <asp:BoundField DataField="salesman_id" HeaderText="salesman id" />
                            <asp:TemplateField HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnedit" runat="server" CommandArgument='<%# Eval("ord_no") %>' CommandName="Edit">Edit</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Delete">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnDelete" runat="server" CommandArgument='<%# Eval("ord_no") %>' CommandName="Delete">Delete</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            <%--<table>
                <thead>
                    <tr>
                        <th>Order Number
                        </th>
                        <td></td>
                        <th>Purchase Amount
                        </th>
                        <th>Order Date
                        </th>
                        <th>Customer id
                        </th>
                        <th>
                            Salesman id
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td></td>
                        <td>25000</td>
                        
                        <td>04/09/2021</td>
                        <td>11</td>
                        <td>21</td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td></td>
                        <td>30000</td>
                        <td>09/09/2021</td>
                        <td>12</td>
                        <td>22</td>
                    </tr>
                    <tr>
                        <td>3</td>
                        <td></td>
                        <td>50000</td>
                        <td>11/09/2021</td>
                        <td>13</td>
                        <td>23</td>
                    </tr>

                </tbody>
            </table>--%>
        </div>
    </form>
</body>
</html>
