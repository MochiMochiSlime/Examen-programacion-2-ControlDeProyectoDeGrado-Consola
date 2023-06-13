using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeProyectoDeGrado
{
    public class Proyectos
    {

        int IDProyecto, Matricula, Calificacion;
        string NombreDelProyecto;
        DateTime FechaInicio, FechaEntrega;

        public Proyectos()
        {

        }

        public Proyectos(String nombredelproyecto, DateTime fechainicio, DateTime fechaentrega, int idproyecto, int matricula, int calificacion)
        {
            this.NombreDelProyecto = nombredelproyecto;
            this.FechaInicio = fechainicio;
            this.FechaEntrega = fechaentrega;
            this.IDProyecto = idproyecto;
            this.Matricula = matricula;
            this.Calificacion = calificacion;

        }




        public string getNombreDelProyecto()
        {
            return NombreDelProyecto;
        }

        public DateTime getFechaInicio()
        {
            return FechaInicio;
        }

        public DateTime getFechaEntrega()
        {
            return FechaEntrega;
        }
        public int getIDProyecto()
        {
            return IDProyecto;
        }
        public int getMatricula()
        {
            return Matricula;
        }

        public int getCalificacion()
        {
            return Calificacion;
        }

        public void setCalificacion(int calificacion)
        {
            this.Calificacion = calificacion;
        }



    }
}
