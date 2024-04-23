<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carga.aspx.cs" Inherits="Parcial1.FormularioCarga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Index.aspx">Volver al home</asp:HyperLink>
        <br />
        <br />
        Formulario de Carga<br />
        <asp:Label ID="Label1" runat="server" Text="Nombre:  "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Tipo: "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Codigo: "></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="1"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Guardar" />
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="La carga fue exitosa"></asp:Label>
        </p>
    </form>
</body>
</html>
