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
    public partial class GUIVentanaPrincipal : Form
    {

        public static String ruta;

        public GUIVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAgregarEquipo gui = new GUIAgregarEquipo();
            gui.Show();
        }

        private void GUIVentanaPrincipal_Load(object sender, EventArgs e)
        {
            ruta = "C:/Users/Usuario/Desktop/prueba.txt";
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListarEquipos gui = new GUIListarEquipos();
            gui.Show();
        }
    }
}
