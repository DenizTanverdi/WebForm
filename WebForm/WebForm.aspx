<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebForm.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bu Benim İlk Web Formum</title>
    <style type="text/css">
        #form1 {
            width: 920px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            Adınızı Giriniz&nbsp; :&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Parola Giriniz&nbsp; :&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
           
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş" 
            Width="83px" />
        <button type="button" class="btn btn-warning">Warning</button>
    </form>
</body>
</html>
