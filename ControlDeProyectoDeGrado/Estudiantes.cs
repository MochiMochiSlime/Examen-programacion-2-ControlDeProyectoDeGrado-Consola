using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeProyectoDeGrado
{
    public class Estudiantes
    {

        int Matricula;
        string NombreApellido, Carrera;
        bool Activo;


        public Estudiantes()
        {

        }

        public Estudiantes(int matricula, String nombreapellido, String carrera, bool activo)
        {
            this.Matricula = matricula;
            this.NombreApellido = nombreapellido;
            this.Carrera = carrera;
            this.Activo = activo;
        }


        public int getMatricula()
        {
            return Matricula;
        }

        public string getNombreApellido()
        {
            return NombreApellido;
        }
        public string getCarrera()
        {
            return Carrera;
        }
        public bool getActivo()
        {
            return Activo;
        }

    }
}
