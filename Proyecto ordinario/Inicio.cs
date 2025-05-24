using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ordinario
{
    public partial class Inicio : Form
    {
        Acciones A = new Acciones();
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {
            if (A.importar())
            {
                MessageBox.Show("Importado con exito...");
            }
            else
            {
                MessageBox.Show("Fallo importando...");
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            dgDatos.DataSource = null;
            dgDatos.DataSource = A.Consultar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (A.Eliminar(Convert.ToInt32(txbEliminar.Text)))
                MessageBox.Show("Eliminada con exito");
            else
                MessageBox.Show("Fallo");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (A.Insertar(Convert.ToInt32(txbId.Text), txbMarca.Text, txbModel.Text, Convert.ToInt32(txbAnio.Text), txbColor.Text, Convert.ToDouble(txbPrecio.Text), txbEstado.Text))
                MessageBox.Show("Agregado con exito");
            else MessageBox.Show("Fallo al agregar");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (A.Insertar(Convert.ToInt32(tbxIDactualizar.Text),txbMarca.Text, txbModel.Text, Convert.ToInt32(txbAnio.Text), txbColor.Text, Convert.ToDouble(txbPrecio.Text), txbEstado.Text))
                MessageBox.Show("Actualizado con exito");
            else MessageBox.Show("Fallo al actualizar");
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (A.exportar())
                MessageBox.Show("Exportado con exito");
            else
                MessageBox.Show("fallo al exportar");
        }
    }
}
