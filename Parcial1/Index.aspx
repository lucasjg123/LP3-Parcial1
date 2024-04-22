<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Parcial1.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Plan de Cuentas Contables"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Menu"></asp:Label>
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Carga.aspx">- Cargar cuenta</asp:HyperLink>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Vista.aspx">- Ver cuentas</asp:HyperLink>
        </p>
    </form>
</body>
</html>
