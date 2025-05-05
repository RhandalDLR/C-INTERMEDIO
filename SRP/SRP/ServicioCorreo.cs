namespace POO;

public class ServicioCorreo
{
    public void EnviarCorreoElectronico(Persona persona, string mensaje)
    {
        Console.WriteLine($"Correo Electronico Enviado con exito a {persona.CorreoElectronico} ");
        
    }
}