using Polimorfismo;
using System;

class Program
{
    static void Main() {
        Figura rectangulo = new Rectangulo(24, 6);
        Figura circulo = new Circulo(12);
        Figura triangulo = new Triangulo(9, 5);

        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea()}");
    }
}
