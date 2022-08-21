<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebForms.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:Panel ID="pnlCampoCadastro" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <br />
            
                 <asp:Label ID="Label2" runat="server" Text="Telefone"></asp:Label>
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                  <br />
                    <hr />
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </asp:Panel>
            <asp:Panel ID="pnlResultado" runat="server">
                   <asp:Button ID="btnNovoCadastro" runat="server" Text="Novo cadastro" OnClick="btnNovoCadastro_Click" />
                <asp:GridView ID="gridResultado" runat="server"></asp:GridView>


            </asp:Panel>

        </div>
    </form>
</body>
</html>
