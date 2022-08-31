<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="WebForms.Login" %>

<div class="login">
    <asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label>
    <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>

</div>
<div>
    <asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label>
    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>

</div>
<div>
<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />

</div>

    <asp:Label ID="lblMensagem" runat="server" Text="Mensagem"></asp:Label>

