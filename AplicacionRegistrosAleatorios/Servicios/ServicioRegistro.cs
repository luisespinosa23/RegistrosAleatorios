using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AplicacionRegistrosAleatorios.Estructura;

namespace AplicacionRegistrosAleatorios.Servicios
{
    class ServicioRegistro
    {

        private static FileStream archivo;
        private static BinaryReader br;
        private static BinaryWriter bw;

        public static void agregarEquipo(Equipo nuevo, String rutaArchivo)
        {
            archivo = new FileStream(rutaArchivo, FileMode.Append);
            bw = new BinaryWriter(archivo, Encoding.UTF8);

            bw.Write(llenarCadena(nuevo.getNombre()));
            bw.Write(nuevo.getJugadores());
            bw.Write(llenarCadena(nuevo.getCodigo()));
            bw.Write(llenarCadena(nuevo.getColor()));
            bw.Write(llenarCadena(nuevo.getFechaCreacion().ToString()));
            bw.Write(llenarCadena(nuevo.getEstado()));

            bw.Close();
            archivo.Close();
        }

        public static String llenarCadena(String cadena)
        {
            int cont = cadena.Length;
            while(cont < 10)
            {
                cadena = cadena + " ";
                cont++;
            }
            return cadena;
        }

        public static String listarEquipos(String rutaArchivo)
        {
            String cad = "";
            String nombre;
            String color;
            int jugadores;
            String codigo;
            String fecha;
            String estado;
            archivo = new FileStream(rutaArchivo, FileMode.Open);
            br = new BinaryReader(archivo, Encoding.UTF8);
            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                nombre =  br.ReadString();
                jugadores = br.ReadInt32();
                codigo = br.ReadString();
                color = br.ReadString();
                fecha = br.ReadString();
                estado = br.ReadString().Trim();
                if (estado.Equals(Equipo.ACTIVO))
                {
                    cad = cad + Environment.NewLine + codigo + " , " + nombre + " , " + jugadores + " , " +
                        color + " , " + fecha;
                }
            }
            br.Close();
            archivo.Close();
            return cad;
        }


    }
}
