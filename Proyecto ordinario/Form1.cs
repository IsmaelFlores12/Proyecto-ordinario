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
    public partial class Form1 : Form
    {
        Usuario Usuario = new Usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            string user=txbUsuario.Text;
            string password=tbxContraseña.Text;

            var lista = Usuario.obtenerUsuario();
            var validar = lista.FirstOrDefault(u => u.NomUsuario==user && u.ContraUsuario==password);
            if (validar != null)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }

            
        }
    }
}
