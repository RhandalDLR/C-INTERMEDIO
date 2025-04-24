using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Estudiante : Persona
    {
        #region PROPIEDADES
        string Carrera { get; set; }
        int Matricula { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Estudiante(string nombre, int edad, string ciudad, string carrera,
            int matricula) : base(nombre, edad, ciudad) {
            Carrera = carrera;
            Matricula = matricula;
        }
        #endregion

        #region METODO PARA MOSTRAR LA INFORMACION
        public void MostrarInfoCompleta() {
            base.MostrarInfo();
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matricula: {Matricula}");
        }
        #endregion
    }

}
