using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1G2
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Vehículo:");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Anio);
        }

        public virtual void Encender()
        {
            Console.WriteLine("El vehículo se está encendiendo...");
        }
    }

    // --- AGREGAMOS LAS CLASES HIJAS AQUÍ ---

    public class Carro : Vehiculo
    {
        // El constructor recibe los datos y los pasa al padre (base)
        public Carro(string marca, string modelo, int anio) : base(marca, modelo, anio) { }

        public override void Encender()
        {
            Console.WriteLine($"El carro {Marca} ha encendido el motor con éxito.");
        }
    }

    public class Moto : Vehiculo
    {
        public Moto(string marca, string modelo, int anio) : base(marca, modelo, anio) { }

        public override void Encender()
        {
            Console.WriteLine($"La moto {Marca} ha encendido (arranque eléctrico).");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("   SISTEMA DE VEHICULOS - PARCIAL   ");
            Console.WriteLine("====================================");
            Console.WriteLine();

            // TODO: Crear una lista de tipo Vehiculo
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            // TODO: Crear al menos DOS objetos de clases hijas
            Carro miCarro = new Carro("Toyota", "Corolla", 2024);
            Moto miMoto = new Moto("Yamaha", "MT-09", 2023);

            // TODO: Agregar los objetos a la lista
            vehiculos.Add(miCarro);
            vehiculos.Add(miMoto);

            // TODO: Recorrer la lista usando foreach
            foreach (Vehiculo v in vehiculos)
            {
                // TODO: Llamar a los métodos
                v.MostrarInformacion();
                v.Encender();
                Console.WriteLine("------------------------------------");
            }

            // Pausa para ver los resultados
            Console.ReadKey();
        }
    }
}