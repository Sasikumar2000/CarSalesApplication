<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CarSales.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CarSale</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        table{
            margin-left:auto;
            margin-right:auto;
        }

        td {
          padding: 15px;
          text-align: left;
        }
        h1{
            margin-left:550px;
           
        }
    </style>
</head>
<body>
    <form id="carform" runat="server" >
        <div>
            <h1>Car Details </h1>
            <table class="table-responsive tableform">
                <tr>
                    <td>
                        <asp:Label ID="lblCarModel" runat="server" Text="CarModel"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtCarModel" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox></td>
                </tr>
<tr>
                    <td>
                        <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
                </tr>
<tr>
                    <td>
                        <asp:Label ID="lblYearOfModel" runat="server" Text="Year Of Model"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:DropDownList ID="DDYearOfModel" runat="server">
                            <asp:ListItem>2019</asp:ListItem>
                            <asp:ListItem>2020</asp:ListItem>
                            <asp:ListItem>2021</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
<tr>
                    <td>
                        <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox></td>
                </tr>
                </table>
               <table>
                <tr>
                    <td><asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" /></td>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-info" OnClick="btnUpdate_Click" /></td>
                    <td>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btnDelete_Click" /></td>
                    <td>
                        <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-warning" OnClick="btnReset_Click" /></td>
                </tr>

            </table>
            <div>
            <asp:GridView ID="GvTable" runat="server" CssClass="table table-hover"></asp:GridView>
           </div>
        </div>
    </form>
</body>
</html>
