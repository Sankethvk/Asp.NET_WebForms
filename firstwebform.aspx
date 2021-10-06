<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firstwebform.aspx.cs" Inherits="FirstWeb.firstwebform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Salesman details</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table>
             <tr>
                <td> Salesman id : </td><td>
                <asp:TextBox ID="txtsalesmanid" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td> Salesman name : </td><td>
                <asp:TextBox ID="txtsalesmanname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                    <td>Salesman city : </td><td>
                        <asp:TextBox ID="txtSalesmancity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman commission : </td><td>
                        <asp:TextBox ID="txtSalesmancommision" runat="server"></asp:TextBox></td>
                </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" />

                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />

                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="Label1" runat="server" ></asp:Label></td>
            </tr>
        </table>
            <div>
                <asp:GridView ID="gvSalesmanDetails" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvSalesmanDetails_RowDeleting" OnRowEditing="gvSalesmanDetails_RowEditing" OnRowCommand="gvSalesmanDetails_RowCommand" >
                    <Columns>
                        <asp:BoundField DataField="salesman_id" HeaderText="salesman id" />
                        <asp:BoundField DataField="name" HeaderText="Name" />
                        <asp:BoundField DataField="city" HeaderText="City" />
                        <asp:BoundField DataField="commission" HeaderText="Commission" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" CommandArgument='<%# Eval("salesman_id") %>' CommandName="Edit">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" CommandArgument='<%# Eval("salesman_id") %>' CommandName="Delete">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            <%-- <table>
                <thead>
                    <tr>
                        <th>Salesman Id
                        </th>
                        <td></td>
                        <th>Salesman name
                        </th>
                        <th>Salesman city
                        </th>
                        <th>Salesman commission
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td></td>
                        <td>abc</td>
                        
                        <td>Blr</td>
                        <td>100</td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td></td>
                        <td>def</td>
                        <td>Blr</td>
                        <td>150</td>
                    </tr>
                    <tr>
                        <td>3</td>
                        <td></td>
                        <td>ghi</td>
                        <td>Blr</td>
                        <td>200</td>
                    </tr>
                </tbody>
            </table>--%>
      </div>
    </form>
</body>
</html>
