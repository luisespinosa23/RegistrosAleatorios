using AplicacionRegistrosAleatorios.Estructura;
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
    public partial class GUIAgregarEquipo : Form
    {
        public GUIAgregarEquipo()
        {
            InitializeComponent();
        }

        private void btnGrabarEquipo_Click(object sender, EventArgs e)
        {
            String nombre = txtBoxNombre.Text;
            String color = txtBoxColor.Text;
            int jugadores = Int16.Parse(txtBoxJugadores.Text);
            String codigo = txtCodigo.Text;
            DateTime fecha = Convert.ToDateTime(dateTimeFecha.Text);
            

            Equipo nuevo = new Equipo(nombre, jugadores, codigo, fecha, color);

            Servicios.ServicioRegistro.agregarEquipo(nuevo, GUIVentanaPrincipal.ruta);
        }
    }
}
