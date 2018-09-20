using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO_2702
{
    #region Class circulo
    class Circulo
    {
        private double _raio;

        public double raio
        {
            get { return _raio; }
            set { _raio = value; }
        }


        private double _area;

        public double Area
        {
            get { return _area; }
            private set { _area = value; }
        }


        private double _perimetro;

        public double Perimetro
        {
            get { return _perimetro; }
            private set { _perimetro = value; }
        }

        public void CalcArea()
        {
            _area = Math.PI * Math.Pow(raio, 2);
        }

        public void CalcPerimetro()
        {
            _perimetro = 2 * Math.PI * raio;
        }
    }
    #endregion  

    class Program
    {
        static void Main(string[] args)
        {
            Circulo meucirculo = new Circulo();

            Console.WriteLine("Raio do Circulo:");
            meucirculo.raio = double.Parse(Console.ReadLine());

            meucirculo.CalcArea();
            meucirculo.CalcPerimetro();

            Console.WriteLine("\nArea = {0:F2}", meucirculo.Area);
            Console.WriteLine("Perimetro = {0:F2}", meucirculo.Perimetro);

            Console.ReadKey();


        }


    }
}
