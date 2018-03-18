<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePhunWithStrings.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &lt;Mission 1&gt;<br />
            <br />
            <asp:Label ID="resultLabel1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            -------------------------------<br />
            &lt;Mission 2&gt;<br />
            <br />
            <asp:Label ID="resultLabel2" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            -------------------------------<br />
            &lt;Mission 3&gt;<br />
            <br />
            <asp:Label ID="resultLabel3" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            <br />
            -------------------------------<br />
            &lt;Mission 4&gt;<br />
            <br />
            <asp:Label ID="resultLabel4" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
            <br />
            -------------------------------</div>
    </form>
</body>
</html>
