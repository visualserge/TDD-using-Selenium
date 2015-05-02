<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebMain.LogIn" %>
<form id="form1" runat="server">
    <asp:Label ID="lblUserName" runat="server" Text="UserName:"></asp:Label>
    <asp:textbox id="txtUserName" runat="server"></asp:textbox>
    <p>
        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" Width="133px" TextMode="Password"></asp:TextBox>
    </p>
    <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
    <br />
    <br />
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
</form>

