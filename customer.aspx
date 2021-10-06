<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="FirstWeb.customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                <td> Customer Id : </td><td>
                <asp:TextBox ID="txtcustid" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td> Customer Name : </td><td>
                <asp:TextBox ID="txtcust_name" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                    <td> City : </td><td>
                        <asp:TextBox ID="txtcity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> Grade : </td><td>
                        <asp:TextBox ID="txtgrade" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td> Salesman Id : </td><td>
                        <asp:TextBox ID="txtsalesman_id" runat="server"></asp:TextBox></td>
                </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Reset" />

                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />

                </td>
            </tr>
        </table>
            <div>
                <asp:GridView ID="gridviewCustomer" runat="server" AutoGenerateColumns="False" OnRowCommand="gridviewCustomer_RowCommand" OnRowDeleting="gridviewCustomer_RowDeleting" OnRowEditing="gridviewCustomer_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="customer_id" HeaderText="customer id" />
                        <asp:BoundField DataField="cust_name" HeaderText="customer name" />
                        <asp:BoundField DataField="city" HeaderText="city" />
                        <asp:BoundField DataField="grade" HeaderText="grade" />
                        <asp:BoundField DataField="salesman_id" HeaderText="salesman id" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" CommandArgument='<%# Eval("customer_id") %>' CommandName="Edit">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" CommandArgument='<%# Eval("customer_id") %>' CommandName="Delete">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            <%-- <table>
                <thead>
                    <tr>
                        <th>Customer id
                        </th>
                        <td></td>
                        <th>Customer name
                        </th>
                        <th>City
                        </th>
                        <th>Grade
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
                        <td>jkl</td>
                        
                        <td>Blr</td>
                        <td>200</td>
                        <td>31</td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td></td>
                        <td>mno</td>
                        <td>Blr</td>
                        <td>300</td>
                        <td>32</td>
                    </tr>
                    <tr>
                        <td>3</td>
                        <td></td>
                        <td>pqr</td>
                        <td>Blr</td>
                        <td>375</td>
                        <td>33</td>
                    </tr>

                </tbody>
            </table>--%>
        </div>
    </form>
</body>
</html>
