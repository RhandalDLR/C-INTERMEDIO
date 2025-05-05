namespace OCP;

public interface ICalculoImpuesto
{
    decimal CalcularImpuesto(decimal ingeso, decimal deduccion);
    
}