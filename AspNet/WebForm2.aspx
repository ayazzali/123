<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="AspNet.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        Изменить сотрудника<br />
        <asp:Label ID="Label1" runat="server" Text="Имя"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
        <br /><% %>
        <asp:Label ID="Label2" runat="server" Text="Фамилия"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Отчетсво"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Должность"></asp:Label>
        <asp:ListBox ID="ListBox2" runat="server" style="margin-top: 0px" Height="20px"></asp:ListBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Отдел"></asp:Label>
        <asp:ListBox ID="ListBox3" runat="server" style="margin-top: 0px" Height="21px"></asp:ListBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Телефон"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Его руководитель"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Сохранить" />

    </form>
</body>
</html>
