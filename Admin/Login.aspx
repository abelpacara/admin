<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Admin.Login" %>
<

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
            <tr>
                <td>User Name</td>
                <td><input type="text" id="txtUsername"/></td>
            </tr>            
            <tr>
                <td>Pasword</td>
                <td>
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="chkPassword" runat="server" ErrorMessage="Must enter a Password" ControlToValidate="txtPassword" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>...</td>
                <td>
                    <asp:Button CssClass="boton_formulario" ID="btnLogin" runat="server" Text="LOGIN" Width="86px"></asp:Button>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
