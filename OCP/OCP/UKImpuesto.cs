namespace OCP;

public class UKImpuesto:ICalculoImpuesto
{
    public decimal CalcularImpuesto(decimal ingreso, decimal deduccion)
    {
        decimal ingresoGravable = ingreso - deduccion;
        return ingresoGravable * 0.20m;
    }
}