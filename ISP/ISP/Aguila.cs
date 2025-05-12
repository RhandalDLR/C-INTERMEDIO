
using ISP;

public class Aguila : IAve, IAveCazadora
{
    public void Volar()
    {
        Console.WriteLine("El águila vuela alto.");
    }

    public void Cantar()
    {
        Console.WriteLine("El águila emite chillidos.");
    }

    public void PonerHuevos()
    {
        Console.WriteLine("El águila pone huevos.");
    }

    public void Cazar()
    {
        Console.WriteLine("El águila caza con sus garras.");
    }
}