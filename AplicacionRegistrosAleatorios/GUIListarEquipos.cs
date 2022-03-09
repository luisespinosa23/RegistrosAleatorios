using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionRegistrosAleatorios
{
    public partial class GUIListarEquipos : Form
    {
        public GUIListarEquipos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtBoxListar.Text = Servicios.ServicioRegistro.listarEquipos(GUIVentanaPrincipal.ruta);
        }
    }
}
