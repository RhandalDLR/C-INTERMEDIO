using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Triangulo : Figura
    {
        #region PROPIEDADES
        public double Base { get; set; }
        public double Altura { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Triangulo(double b, double a) {
            Base = b;
            Altura = a;
        }
        #endregion

        #region METODO CALCULAR AREA
        public override double CalcularArea() {
            return (Base * Altura) / 2;
        }
        #endregion

    }
}
