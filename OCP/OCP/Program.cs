
using OCP;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el país (India, USA, UK):");
        string pais = Console.ReadLine();

        Console.WriteLine("Ingrese el ingreso total:");
        decimal ingreso = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Ingrese la deducción:");
        decimal deduccion = Convert.ToDecimal(Console.ReadLine());

        ICalculoImpuesto estrategia = pais switch
        {
            "India" => new IndiaImpuesto(),
            "USA" => new USAImpuesto(),
            "UK" => new UKImpuesto(),
            _ => throw new NotSupportedException("País no soportado.")
        };

        var calculadora = new CalculadoraImpuestos(estrategia);
        decimal impuesto = calculadora.Calcular(ingreso, deduccion);

        Console.WriteLine($"El impuesto a pagar es: {impuesto}");
    }
}