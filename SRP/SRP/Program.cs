using POO;

class Program
{
    static void Main()
    {
        Persona persona = new Persona
        {
            Nombre = "Rhandal De la Rosa",
            Edad = 21,
            Direccion = "Calle Cristo Viene #40, La Descubierta",
            CorreoElectronico = "rhandaldlr@gmail.com"
        };
        
        ImprimirInfo imprimir = new ImprimirInfo();
        imprimir.ImprimirDatos(persona);
        
        ServicioCorreo correo = new ServicioCorreo();
        correo.EnviarCorreoElectronico(persona, "Hola, estas invidato a mi cumpleanos");
        
    
    
    
    
    
    
    


    }
        
    }


    