using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO0604
{
    class Circulo
    {
        public double Raio { get; set; }

        protected double CalculaArea()
        {
            return (Math.PI * Math.Pow(Raio, 2));
        }
    }

    class Cilindro : Circulo
    {
        public double Altura { get; set; }

        public double CalculaVolume()
        {
            return CalculaArea() * Altura;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            double volumeCilindro;
            double raio;
            double altura;


            Console.WriteLine("Raio da Base Do Cilindro");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura do cilindro .....");
            altura = double.Parse(Console.ReadLine());

            Cilindro MeuCilindro = new Cilindro();

            MeuCilindro.Raio = raio;
            MeuCilindro.Altura = altura;

            volumeCilindro = MeuCilindro.CalculaVolume();

            Console.WriteLine("\n Volume do Cilindro........:{0:F2}", volumeCilindro);

            Console.ReadKey();
        }
    }
}
