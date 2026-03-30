<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Insert User</h2>

        <asp:Label ID="lblmsg" runat="server"></asp:Label><br /><br />

        Username:
        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox><br /><br />

        Password:
        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox><br /><br />

        <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" />

        <hr />

        <h2>User List</h2>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>

    </form>
</body>
</html>
