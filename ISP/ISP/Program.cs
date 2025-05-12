
using ISP;

public class Programa
{
    public static void Main()
    {
        IAve gallina = new Gallina();
        gallina.Cantar();
        gallina.PonerHuevos();
        gallina.Volar();

        IAve pato = new Pato();
        pato.Cantar();
        ((IAveNadadora)pato).Nadar();

        IAve aguila = new Aguila();
        aguila.Volar();
        ((IAveCazadora)aguila).Cazar();
    }
}