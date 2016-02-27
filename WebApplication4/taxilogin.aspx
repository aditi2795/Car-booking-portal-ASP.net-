<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="taxilogin.aspx.vb" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 315px;
            width: 662px;
        }
    </style>
</head>
<body style="height: 330px; width: 667px">
    <form id="form1" runat="server">
    <div style="height: 45px; width: 334px; margin-left: 120px; font-family: 'Comic Sans MS'; font-size: large; color: #FF0000; background-color: #FFFFCC;">
        ONLINE TAXI BOOKING SYSTEM<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
    
    </div>
        <p style="font-family: Aparajita; font-size: large; color: #990033; background-color: #FFFFCC">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DRIVER&nbsp; LOGIN!!!&nbsp;</p>
        <p style="Pl; font-style: italic; font-size: large; font-family: Aparajita;">
            Please enter your details :-</p>
        <p style="font-family: Aparajita; font-size: large; color: #660066; background-color: #CCFFFF">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; USERNAME<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 45px"></asp:TextBox>
        </p>
        <p style="font-family: Aparajita; font-size: large; color: #660066; background-color: #CCFFFF">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PASSWORD<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 45px"></asp:TextBox>
        </p>
        <asp:Button ID="Button3" runat="server" style="margin-left: 52px" Text="HOME" Width="103px" />
        <asp:Button ID="Button2" runat="server" style="margin-left: 77px" Text="CREATE" Width="117px" />
        <asp:Button ID="Button1" runat="server" style="margin-left: 113px" Text="LOG IN" Width="122px" />
    </form>
</body>
</html>
