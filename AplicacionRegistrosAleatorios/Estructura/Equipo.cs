using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionRegistrosAleatorios.Estructura
{
    class Equipo
    {

        //constantes de estado del equipo
        public const String ELIMINADO = "EL";
        public const String ACTIVO = "AC";

        //datos del equipo
        private String nombre;
        private String color;        
        private String codigo;
        private String estado;
        private int jugadores;
        private DateTime fechaCreacion;
        private Equipo sgte;


        public Equipo(String nombre, int jugadores, String codigo, DateTime fecha, String color)
        {
            if (nombre == null || nombre == "" || codigo == "" || codigo == null || color == null || color == "" || jugadores <= 0)
            {
                throw new Exception();
            }
            else
            {
                this.nombre = nombre;
                this.jugadores = jugadores;
                this.codigo = codigo;
                this.fechaCreacion = fecha;
                this.color = color;
                estado = ACTIVO;
            }
        }

        public void setNombre(String nNombre)
        {
            nombre = nNombre;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setJugadores(int nJugadores)
        {
            jugadores = nJugadores;
        }

        public int getJugadores()
        {
            return jugadores;
        }

        public void setCodigo(String nCodigo)
        {
            codigo = nCodigo;
        }

        public String getCodigo()
        {
            return codigo;
        }

        public void setFechaCreacion(DateTime nFecha)
        {
            fechaCreacion = nFecha;
        }

        public DateTime getFechaCreacion()
        {
            return fechaCreacion;
        }

        public void setColor(String nColor)
        {
            color = nColor;
        }

        public string getColor()
        {
            return color;
        }

        public void setSgte(Equipo nuevo)
        {
            sgte = nuevo;
        }

        public Equipo getSgte()
        {
            return sgte;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setEstado(String nEstado)
        {
            estado = nEstado;
        }


    }
}
