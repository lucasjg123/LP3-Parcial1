<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vista.aspx.cs" Inherits="Parcial1.Ver" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Index.aspx">Volver al Home</asp:HyperLink>
        </div>
        <p>
            <asp:Label ID="lblVista" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
