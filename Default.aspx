<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="idTexto" runat="server"></asp:TextBox>
            <input id="telefone" name="telfone" type="text"  runat="server"/>
            <asp:Button ID="btnmostrar" runat="server" OnClick="btnmostrar_Click" Text="Mostrar Mensagem" />
        </div>
        <br />
        <br />
        <br />
        <asp:DropDownList ID="ddlContatos" runat="server"></asp:DropDownList>
        <br />
        <br />
        <br />
        <select id="selectManual">
            <% foreach (var item in contatos) { %>
                <option value="<%=item%>"> <%=item%></option>
                    
              <% } %>

        </select>
         <br />
        <br />
        <br />
           <div id="selectManual1" runat="server">

               <asp:GridView ID="GridView1" runat="server">
               </asp:GridView>

               </div>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
