namespace OCP;

public class CalculadoraImpuestos
{
    private readonly ICalculoImpuesto _estrategia;

    public CalculadoraImpuestos(ICalculoImpuesto estrategia)
    {
        _estrategia = estrategia;
    }

    public decimal Calcular(decimal ingreso, decimal deduccion)
    {
        return _estrategia.CalcularImpuesto(ingreso, deduccion);
    }
}