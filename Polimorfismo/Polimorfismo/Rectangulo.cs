using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Rectangulo : Figura
    {
        #region PROPIEDADES
        public double Base { get; set; }
        public double Altura { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Rectangulo(double B, double A) {
            Base = B;
            Altura = A;
        }
        #endregion

        #region METODO PARA CALCULAR AREA
        public override double CalcularArea() {
            return Base * Altura;
        }
        #endregion
    }
}
