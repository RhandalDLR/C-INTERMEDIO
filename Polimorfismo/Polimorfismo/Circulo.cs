using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Circulo : Figura
    {
        #region PROPIEDADES
        public double Radio { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Circulo(double radio) {
            Radio = radio;
        }
        #endregion

        #region METODO PARA CALCULAR AREA
        public override double CalcularArea() {
            return Math.PI * Radio * Radio;
        }
        #endregion
    }

}
