
using ISP;

public class Pato : IAve, IAveNadadora
{
    public void Volar()
    {
        Console.WriteLine("El pato vuela.");
    }

    public void Cantar()
    {
        Console.WriteLine("CUAC CUAC CUAC CUAC.");
    }

    public void PonerHuevos()
    {
        Console.WriteLine("La Pata Ponedora.");
    }

    public void Nadar()
    {
        Console.WriteLine("El pato nada en el agua.");
    }
}