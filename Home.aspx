<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoginApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:Label ID="lblUserDetails" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnHome" runat="server" Text="Logout" OnClick="btnHome_Click" />
        </div>
    </form>
</body>
</html>
