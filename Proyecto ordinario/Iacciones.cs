using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ordinario
{
    internal interface Iacciones
    {
        List<Auto> Consultar();
        bool importar();
        bool exportar();
        bool Insertar(int Id,string Marca,string Modelo,int Anio,string Color,Double Precio,string Estsdo);
        bool Eliminar(int Id);
        bool Actualizar(int Id, string Marca, string Modelo, int Anio, string Color, Double Precio, string Estsdo);
    }
}
