using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace POO
{
    public class Persona
    {
        #region PROPIEDADES
        string Nombre { get; set; }
        int Edad { get; set; }
        string Ciudad { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Persona(string nombre, int edad, string ciudad) {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }
        #endregion

        #region METODO PARA MOSTRAR LA INFORMACION
        public void MostrarInfo() {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }
        #endregion
    }
}
