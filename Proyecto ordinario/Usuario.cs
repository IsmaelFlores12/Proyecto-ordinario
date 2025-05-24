using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ordinario
{
    internal class Usuario
    {
        public Usuario() { }
        private static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario{NomUsuario="Ismael Flores",ContraUsuario="1213"},
            new Usuario{NomUsuario="Wendy Plascencia",ContraUsuario="1234"},
        };
        public List<Usuario> obtenerUsuario()
        {
            return usuarios;

        }
        public string NomUsuario { get; set; }
        public string ContraUsuario { get; set; }
    }
}
