using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 5];
            Random r = new Random();
            int x, y;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = r.Next(0, 90);
                }
            }
            Console.Write("Qual a linha ?");
            x = int.Parse(Console.ReadLine());
            Console.Write("Qual a coluna ?");
            y = int.Parse(Console.ReadLine());
            try
            {
                Console.Write("\nO elemento da linha e {0} e o da coluna {1} e{2} ", x, y, matriz[x - 1, y - 1]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("O elemento da linha {0} e coluna {1} e invalido !!! \n Insira um numero de linha entre 1 e 3 e de coluna entre 1 e 5 !!!", x, y);
            }

            Console.ReadKey();
        }
    }
}
