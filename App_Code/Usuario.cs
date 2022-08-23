using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms
{
    public class Usuario
    {
        public Usuario()
        {

        }

        public string Nome { get; set; }


        public string  Telefone { get; set; }

        public string Foto { get; set; }

        public static List<Usuario> List { get; set; } = new List<Usuario>();


        public List<Usuario> Todos()
        {
            return Usuario.List;
        }

        public void Salvar()
        {
            Usuario.List.Add(this);
        }

    }
}