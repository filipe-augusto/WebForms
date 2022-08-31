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
            ctrLogin.Mensagem = "Este é o form principal";
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
            string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + System.Configuration.ConfigurationManager
                .AppSettings["caminhoArquivo"] +@"/" +fileFoto.FileName;
            if (caminhoArquivo != null)
            fileFoto.SaveAs(caminhoArquivo);

            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Telefone = txtTelefone.Text;
            usuario.Foto = System.Configuration.ConfigurationManager
                .AppSettings["caminhoArquivo"].Replace(@"\", "/") +@"/" + fileFoto.FileName;

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