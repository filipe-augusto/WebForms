using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlCampoCadastro.Visible = false;
            pnlResultado.Visible = true;
            mostrarLista();
        }

        public void mostrarLista()
        {
            pnlResultado.Visible = true;
            pnlCampoCadastro.Visible = false;

            gridResultado.DataSource = Usuario.List;
            gridResultado.DataBind();
        }

        public void mostrarCadastro()
        {
            pnlResultado.Visible = false;
            pnlCampoCadastro.Visible = true;

     
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Telefone = txtTelefone.Text;

            txtTelefone.Text = "";
            txtNome.Text = "";
            usuario.Salvar();

            mostrarLista();
        }

        protected void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            mostrarCadastro();
        }
    }
}