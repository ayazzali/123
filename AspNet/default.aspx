<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="AspNet.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label9" runat="server" Text="Добавить сотрудника"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Имя"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Фамилия"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Отчетсво"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Должность"></asp:Label>
        <asp:ListBox ID="ListBox2" runat="server" style="margin-top: 0px" Height="42px"></asp:ListBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Отдел"></asp:Label>
        <asp:ListBox ID="ListBox3" runat="server" style="margin-top: 0px" Height="38px"></asp:ListBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Телефон"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Его руководитель"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server" style="margin-top: 0px" Height="43px"></asp:ListBox>
        <asp:TextBox ID="TextBox9" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" Visible="False" />

        <br />
        <br />
        
        Добавить должность
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Добавить должность" />

        <br />
        Добавить отдел
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Добавить отдел" />

        <br />
        <br />


        <%//моb сотрудникb 
          //foreach
          //Eval(myKadry.sotrudniki.ToString());
                            
      %>

        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>

        <br />
        <br />

    </form>
</body>
</html>
