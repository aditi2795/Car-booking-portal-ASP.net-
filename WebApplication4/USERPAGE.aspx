<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="USERPAGE.aspx.vb" Inherits="WebApplication4.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-weight: 700">
    <form id="form1" runat="server">
        <p style="font-family: &quot;Comic Sans MS&quot;; font-size: x-large; color: #FF0000; text-decoration: blink; background-color: #FFFFCC;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ONLINE CAR BOOKING SYSTEM</p>
        <p style="font-family: &quot;Comic Sans MS&quot;; font-size: x-large; color: #FF0000; text-decoration: blink; background-color: #FFFFCC;">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; WELCOME&nbsp; GUEST!!!</p>
        <p style="font-style: italic">
            Please fill the following details :-</p>
        <p style="background-color: #CCFFFF; font-family: Aparajita; font-size: large; color: #660066;">
            Type of travel :&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="LOCAL" Height="16px" style="margin-left: 17px" Width="123px">
                <asp:ListItem>--Select--</asp:ListItem>
                <asp:ListItem>Within city</asp:ListItem>
                <asp:ListItem>Sightseeing</asp:ListItem>
                <asp:ListItem>Inter city</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="color: #660066; font-size: large; background-color: #CCFFFF; font-family: Aparajita;">
            Vehicle category:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="122px">
                <asp:ListItem>--Select--</asp:ListItem>
                <asp:ListItem>Mini</asp:ListItem>
                <asp:ListItem>Sedan</asp:ListItem>
                <asp:ListItem>SUV</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="font-family: Aparajita; font-size: large; color: #660066; background-color: #CCFFFF">
            Purpose of&nbsp; travel:<asp:DropDownList ID="DropDownList3" runat="server" DataTextField="LOCAL" Height="16px" style="margin-left: 17px" Width="123px">
                <asp:ListItem>--Select--</asp:ListItem>
                <asp:ListItem>Casual</asp:ListItem>
                <asp:ListItem>Holidaying</asp:ListItem>
                <asp:ListItem>Business/Work</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="font-weight: 700; font-family: Aparajita; color: #660066; background-color: #CCFFFF; font-size: large;">
            Location:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList4" runat="server" DataTextField="LOCAL" Height="16px" style="margin-left: 17px" Width="123px">
                <asp:ListItem>---Select---</asp:ListItem>
                <asp:ListItem>Delhi</asp:ListItem>
                <asp:ListItem>Mumbai</asp:ListItem>
                <asp:ListItem>Chennai</asp:ListItem>
                <asp:ListItem>Bangalore</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="font-weight: 700; font-family: Aparajita; color: #660066; background-color: #CCFFFF; font-size: large;">
&nbsp;Dates:&nbsp;
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" style="margin-left: 107px; margin-top: 12px" Width="200px">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
        </p>
        <p style="font-weight: 700; font-family: Aparajita; color: #660066; background-color: #CCFFFF; font-size: large;">
            Selected date :<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 24px" Width="143px"></asp:TextBox>
&nbsp;</p>
        <p style="font-weight: 700; font-family: Aparajita; color: #660066; background-color: #CCFFFF; font-size: large;">
            <asp:Button ID="Button1" runat="server" ForeColor="Maroon" style="margin-left: 239px; margin-bottom: 0px; font-weight: 700;" Text="SUBMIT" Width="89px" />
        </p>
    </form>
</body>
</html>
