
using System;
using BusManagement.Entities;
using BusManagement.Repository;
using BusManagement.Interfaces;

namespace BusManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<Asiento> asientoRepo = new Repository<Asiento>();

            var asiento1 = new Asiento
            {
                AsientoId = 1,
                BusId = 101,
                NumeroPiso = 1,
                NumeroAsiento = 5,
                FechaCreacion = DateTime.Now
            };

            var asiento2 = new Asiento
            {
                AsientoId = 2,
                BusId = 101,
                NumeroPiso = 2,
                NumeroAsiento = 10,
                FechaCreacion = DateTime.Now
            };

            asientoRepo.Agregar(asiento1);
            asientoRepo.Agregar(asiento2);

            Console.WriteLine("Asientos en el sistema:");
            foreach (var a in asientoRepo.TraerTodos())
            {
                Console.WriteLine($"Asiento #{a.AsientoId}, Bus {a.BusId}, Piso {a.NumeroPiso}, Nº {a.NumeroAsiento}");
            }

            var asientoBuscado = asientoRepo.ObtenerPorId(2);
            Console.WriteLine($"
🔎 Encontrado: AsientoId {asientoBuscado.AsientoId}, Nº {asientoBuscado.NumeroAsiento}");

            asientoBuscado.NumeroAsiento = 99;
            asientoRepo.Actualizar(asientoBuscado);

            var actualizado = asientoRepo.ObtenerPorId(2);
            Console.WriteLine($"
 Actualizado: AsientoId {actualizado.AsientoId}, Nº {actualizado.NumeroAsiento}");

            asientoRepo.Remover(asiento1);
            Console.WriteLine("\n Asiento 1 removido.");

            Console.WriteLine("\n Asientos actuales:");
            foreach (var a in asientoRepo.TraerTodos())
            {
                Console.WriteLine($" Asiento #{a.AsientoId}, Bus {a.BusId}");
            }
        }
    }
}
