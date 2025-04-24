using POO;

class Program
{
    static void Main() {
        Estudiante estudiante = new Estudiante("Rhandal De la Rosa", 21,
            "La Descubierta", "Ingenieria en Sistemas", 20211219);

        estudiante.MostrarInfoCompleta();

        Estudiante estudiante2 = new Estudiante("Ronny De la Rosa", 18, "Santo Domingo",
            "Lic. En Informatica", 20250000);

        estudiante2.MostrarInfoCompleta();
    }

}