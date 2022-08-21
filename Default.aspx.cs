using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class Default : System.Web.UI.Page
    {

        public List<string> contatos = new List<string>();
        public List<Contato> listaContatos = new List<Contato>();
        protected void Page_Load(object sender, EventArgs e)
        {

            listaContatos.Add(new Contato() { Nome = "Filipe", ID = 1 });
            listaContatos.Add(new Contato() { Nome = "Cassila", ID = 2 });
            listaContatos.Add(new Contato() { Nome = "Nice", ID = 3 });
            listaContatos.Add(new Contato() { Nome = "Isaac", ID = 4 });
            listaContatos.Add(new Contato() { Nome = "Mathias", ID = 5 });

            GridView2.DataSource = listaContatos;
            GridView2.DataBind();

            contatos.Add("danilo");
            contatos.Add("Sheila");
            contatos.Add("Filipe");
            contatos.Add("mathias");
            contatos.Add("billy");
            contatos.Add("pedro");
            contatos.Add("augusto");
            //jeito 1
            //   ddlContatos.DataSource = contatos;
            // ddlContatos.DataBind();
            //jeito 2
            ddlContatos.DataSource = listaContatos;
            ddlContatos.DataValueField = "ID";
            ddlContatos.DataTextField = "Nome";
            ddlContatos.DataBind();


            //jeito 3
            //selectManual1.InnerHtml += "<select>";
            //foreach (var item in contatos)
            //{
            //    selectManual1.InnerHtml += "<option value='" + item + "' >" + item + "</option>";
            //}
            //selectManual1.InnerHtml += "</select>";

            GridView1.DataSource = contatos;
            GridView1.DataBind();
        }

        protected void btnmostrar_Click(object sender, EventArgs e)
        {
            Response.Write("Olá " + idTexto.Text);
            Response.Write("Olá" + Request["idTexto"]);
            //Response.Write("TE")

            Response.Write("<script> alert('" + idTexto.Text + "')</script> ");
        }
    }

   public class Contato
    {
        public int ID { get; set; }

        public string Nome { get; set; }
    }
}