namespace POO;

public class ImprimirInfo
{
    public void ImprimirDatos(Persona persona)
    {
        Console.WriteLine($"Nombre: {persona.Nombre}");
        Console.WriteLine($"Edad: {persona.Edad}");
        Console.WriteLine($"Direccion: {persona.Direccion}");
        Console.WriteLine($"Correo Electronico: {persona.CorreoElectronico}"); 
        
    }
}