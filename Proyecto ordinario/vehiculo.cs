using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ordinario
{
    internal class vehiculo
    {
        public vehiculo() { }
        public vehiculo(double precio, string estado)
        {
            Precio = precio;
            Estado = estado;
        }

        public double Precio { get; set; }
        public string Estado { get; set; }
    }
}
