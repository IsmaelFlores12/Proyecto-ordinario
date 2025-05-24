using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ordinario
{
    internal class Acciones : Iacciones
    {
        correo Corre = new correo();
        List<Auto> ListaAutos = new List<Auto>();
        Auto Au = new Auto();
        public bool Actualizar(int Id, string Marca, string Modelo, int Anio, string Color, double Precio, string estado)
        {
            try
            {
                var objetotoAcctualizar = ListaAutos.Find(x => x.Id == Id);
                if (objetotoAcctualizar != null)
                {
                    objetotoAcctualizar.Id = Id;
                    objetotoAcctualizar.Marca = Marca;
                    objetotoAcctualizar.Modelo = Modelo;
                    objetotoAcctualizar.Anio = Anio;
                    objetotoAcctualizar.Precio = Precio;
                    objetotoAcctualizar.Estado = estado;
                    return true;
                }
                return true;
            }
            catch (Exception ex)
            {
                Corre.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public List<Auto> Consultar()
        {
            try
            {
                return ListaAutos;

            }
            catch (Exception ex)
            {
                Corre.EnviarCorreo(ex.ToString());
                throw;
            }
        }

        public bool Eliminar(int Id)
        {
            try
            {
                var objetoEliminar = ListaAutos.Find(x => x.Id == Id);
                if (objetoEliminar != null)
                {
                    ListaAutos.Remove(objetoEliminar);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Corre.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public bool exportar()
        {
            try
            {
                string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Autos_Importacion.xlsx");

                if (!File.Exists(rutaArchivo))
                    return false;

                using (var workbook = new XLWorkbook(rutaArchivo))
                {
                    var hoja = workbook.Worksheets.First();
                    var filas = hoja.RowsUsed().Skip(1);

                    foreach (var fila in filas)
                    {
                        Auto auto = new Auto()
                        {
                            Id = int.Parse(fila.Cell(1).GetValue<string>()),
                            Marca = fila.Cell(2).GetValue<string>(),
                            Modelo = fila.Cell(3).GetValue<string>(),
                            Anio = int.Parse(fila.Cell(4).GetValue<string>()),
                            Color = fila.Cell(5).GetValue<string>(),
                            Precio = double.Parse(fila.Cell(6).GetValue<string>()),
                            Estado = fila.Cell(7).GetValue<string>()
                        };

                        ListaAutos.Add(auto);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Corre.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public bool importar()
        {
            try
            {
                string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Autos_Importacion.xlsx");

                if (!File.Exists(rutaArchivo))
                    return false;

                using (var workbook = new XLWorkbook(rutaArchivo))
                {
                    var hoja = workbook.Worksheets.First();
                    var filas = hoja.RowsUsed().Skip(1);

                    foreach (var fila in filas)
                    {
                        Auto auto = new Auto()
                        {
                            Id = int.Parse(fila.Cell(1).GetValue<string>()),
                            Marca = fila.Cell(2).GetValue<string>(),
                            Modelo = fila.Cell(3).GetValue<string>(),
                            Anio = int.Parse(fila.Cell(4).GetValue<string>()),
                            Color = fila.Cell(5).GetValue<string>(),
                            Precio = double.Parse(fila.Cell(6).GetValue<string>()),
                            Estado = fila.Cell(7).GetValue<string>()
                        };

                        ListaAutos.Add(auto);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Corre.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public bool Insertar(int Id, string Marca, string Modelo, int Anio, string Color, double Precio, string Estsdo)
        {
            try
            {
                ListaAutos.Add (new Auto(Au.Id = Id, Au.Marca = Marca, Au.Modelo = Modelo, Au.Anio = Anio, Au.Color = Color, Au.Precio = Precio, Au.Estado = Estsdo));
                return true;
            }
            catch (Exception ex)
            {
                Corre.EnviarCorreo(ex.ToString());
                return false;
            }
        }
    }
}
