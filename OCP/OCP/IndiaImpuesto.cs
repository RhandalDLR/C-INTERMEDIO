namespace OCP;

public class IndiaImpuesto: ICalculoImpuesto
{
    public decimal CalcularImpuesto(decimal ingreso, decimal deduccion)
    {
        decimal ingresoGravable = ingreso - deduccion;
        return ingresoGravable * 0.15m;
        
    }
    
    
}