<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebForms.Cadastro" %>

<%@ Register src="Login.ascx" tagname="Login" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        img{
            width:100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br/><br/>
            <uc1:Login ID="Login1" runat="server" />
            <br/><br/><br/><br/><br/><br/>
            <asp:Panel ID="pnlCampoCadastro" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <br />

                <asp:Label ID="Label2" runat="server" Text="Telefone"></asp:Label>
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Foto: "></asp:Label>
                <asp:FileUpload ID="fileFoto" runat="server" />
                <br />
                <hr />
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </asp:Panel>
            <asp:Panel ID="pnlResultado" runat="server">
                <asp:Button ID="btnNovoCadastro" runat="server" Text="Novo cadastro" OnClick="btnNovoCadastro_Click" />
                <asp:GridView ID="gridResultado" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                        <asp:ImageField DataImageUrlField="Foto" HeaderText="Foto">
                        </asp:ImageField>
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
