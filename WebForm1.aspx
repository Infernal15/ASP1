<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_1.WebForm1" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="StyleSheet1.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Ім'я</label>
            <input id="Name" type="text" runat="server"/>
        </div>
        <div>
            <label>Дата народження</label>
            <input id="date" type="date" runat="server"/>
        </div>
        <div>
            <label>Адреса</label>
            <input id="address" type="text" runat="server"/>
        </div>
        <div>
            <label>Стать</label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Чоловіча</asp:ListItem>
                <asp:ListItem>Жіноча</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <label>Провесія</label>
            <input id="profession" type="text" runat="server"/>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Save" />
    </form>
    <div id="content" runat="server">

    </div>
</body>
</html>
