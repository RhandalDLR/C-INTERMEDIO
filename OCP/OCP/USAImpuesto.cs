namespace OCP;

public class USAImpuesto: ICalculoImpuesto
{ 
    public decimal CalcularImpuesto(decimal ingreso, decimal deduccion)
    {
            decimal ingresoGravable = ingreso - deduccion;
            return ingresoGravable * 0.25m; 
    }
    
}

