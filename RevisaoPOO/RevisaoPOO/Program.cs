using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(25, 0);
            Console.Write("Escolha um exercício para executar: (0 para sair)");

            Console.Write("\n1 - Lê um número e fornece o resultado das séries A (n - 1 /n) e B (100 - 1 + 2 ......n)");
            Console.Write("\n2 - Calcula e mostra a altura mínima, a altura máxima, média da altura das Mulheres e o numero de Homens");
            Console.Write("\n3 - Exibe os números perfeitos de 1 a 1000");
            Console.Write("\n4 - Soma dois vetores de 10 posições cada");
            Console.Write("\n5 - Faz a soma e diferença de duas matrizes de ordem 3 de valores aleatórios");
            Console.Write("\n6 - Faz a união de valores de dois vetores de 10 posições em um outro vetor");
            Console.Write("\n7 - Realiza o cálculo para definir o ano em que a árvore A crescerá mais que a arvore B");
            Console.Write("\n8 - Realiza o cálculo para descobrir se um número é palíndromo");
            Console.Write("\n9 - Lê um vetor de 10 posições, conta e mostra quantos desses valores são múltiplos de 3");
            Console.Write("\n10 -Le uma matriz quadrada de ordem 3 e retorna um vetor resultante com os valores acima e abaixo de sua diagonal principal\n ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                #region saida
                case 0:
                    Console.Clear();
                    Console.Write("Tem certeza que deseja sair? Pressione ESC para sair, ou qualquer tecla para escolher outro exercício");
                    if (Console.ReadKey().Key != ConsoleKey.Escape)
                    {
                        goto Inicio;
                    }
                    Console.Clear();
                    break;
                #endregion
                #region Exercicio1
                case 1:
                    Console.Clear();
                    double soma = 0;
                    Console.Write("\nInforme um número inteiro: ");
                    int n = int.Parse(Console.ReadLine());

                    

                    for (int i = 2; i <= n; i++)
                    {
                        double numerador = i - 1;
                        double denominador = i;
                        double fracao = numerador / denominador;
                        Console.Write("\n\t{0:F2} é resultado de {1}/{2}", fracao, numerador, denominador);
                        soma = soma + fracao;
                    }

                    int somador = 100;
                    for (int j = 1; j <= n; j++)
                    {
                        if (j % 2 == 0)
                        {
                            somador = somador + j;
                        }
                        else
                        {
                            somador = somador - j;
                        }
                    }

                    Console.Write("\n{0:F2} é a soma das frações", soma);
                    Console.Write("\n{0} é o resultado da segunda operação", somador);
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                #endregion
                #region Exercicio 2
                case 2:
                    Console.Clear();
                    double[] alturas = { 1.80, 1.65, 2.00, 1.45, 1.50, 1.70, 1.88, 1.42, 1.97, 1.66, 2.10, 1.51, 1.56, 1.78, 1.30 };
                    int[] sexo = {0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0};// 0 = Homem e 1 = Mulher//

                    double somaF = 0;
                    double mediaF;
                    int contador = 0;

                    for (int i = 0; i < sexo.Length; i++)
                    {
                        if (sexo[i] == 1)
                        {
                            somaF = somaF + alturas[i];
                            contador++;
                        }
                    }

                    mediaF = somaF / contador;
                    int numeroHomens = 15 - contador;
                    Console.Write("\nA menor altura é {0}\nE a maior altura é {1}", alturas.Min(), alturas.Max());
                    Console.Write("\nA media  das alturas das Mulheres e {0:F2}", mediaF);
                    Console.Write("\n{0} é o numero de Homens", numeroHomens);
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                #endregion
                #region Exercicio 3
                case 3:
                    Console.Clear();
                    for (int i = 1; i < 1000; i++)
                    {
                        int num = 1;
                        int somas = 0;
                        while (num < i)
                        {
                            if (i % num == 0)
                                somas = somas + num;
                            num++;
                        }
                        if (somas == i)
                            Console.Write("\n{0}", i);
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                #endregion
                #region Exercicio 4
                case 4:
                    Console.Clear();
                    int[] vetor1 = new int[10];
                    int[] vetor2 = new int[10];

                    Console.WriteLine("Vamos prencher 2 vetores de 10 valores cada");

                    int contador1 = 1;
                    int contador2 = 1;

                    for (int i = 0; i < vetor1.Length; i++)
                    {
                        Console.WriteLine("{0}º Valor do vetor 1 ", contador1);
                        vetor1[i] = int.Parse(Console.ReadLine());
                        contador1++;
                        Console.Clear();
                    }

                    for (int i = 0; i < vetor2.Length; i++)
                    {
                        Console.WriteLine("{0}º Valor do vetor 2 ", contador2);
                        vetor2[i] = int.Parse(Console.ReadLine());
                        contador2++;
                        Console.Clear();
                    }

                    int somavetor1 = vetor1.Sum();
                    int somavetor2 = vetor2.Sum();
                    int somavetores = somavetor1 + somavetor2;

                    Console.WriteLine("{0} É o resultado da soma dos 2 vetores", somavetores);
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                #endregion
                #region Exercicio 5
                case 5:
                    int[,] matriz1 = new int[3, 3];
                    int[,] matriz2 = new int[3, 3];
                    Random numero1 = new Random();
                    Random numero2 = new Random();

                    for (int i = 0; i <= matriz1.Length; i++)
                    {
                        for (int j = 0; j < matriz1.Length; j++)
                        {
                            numero1.Next(0, 100);
                        }
                    }

                    for (int k = 0; k < matriz2.Length; k++)
                    {
                        for (int l = 0; l < matriz2.Length; l++)
                        {
                            numero2.Next(0, 100);
                        }
                    }                    
                    Console.Clear();
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                #endregion
                #region Exercicio 6
                case 6:
                    Console.Clear();
                    int[] r = new int[10];
                    int[] s = new int[10];
                    int[] v = new int[20];

                    Console.WriteLine("Vamos preencher 2 vetores de 10 valores cada");

                    int cont = 1;
                    int cont2 = 1;
                    int cont3 = 0;

                    for (int i = 0; i < r.Length; i++)
                    {
                        Console.WriteLine("Digite o {0}º Valor do primeiro Vetor", cont);
                        r[i] = int.Parse(Console.ReadLine());
                        cont++;
                        Console.Clear();
                    }
                    for (int i = 0; i < s.Length; i++)
                    {
                        Console.WriteLine("Digite o {0}º Valor do segundo vetor", cont2);
                        s[i] = int.Parse(Console.ReadLine());
                        cont2++;
                        Console.Clear();
                    }

                    for (int i = 0; i < r.Length; i++)
                    {
                        v[i] = r[i];
                    }
                    for (int i = 10; i < v.Length; i++)
                    {
                        v[i] = s[cont3];
                        cont3++;
                    }

                    Console.WriteLine("Vetor V");

                    foreach (int x in v)
                    {
                        Console.WriteLine(x);  
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                #endregion
                #region Exercicio 7
                case 7:
                    Console.Clear();

                    double arvoreA = 0.80, arvoreB = 1.30;
                    int ano = 2018;                    
                    double crescimentoA = 0.12, crescimentoB = 0.08;
                    Console.WriteLine("Temos 2 arvores (A com 0.8m de altura e crescimento de 0.12m ao ano)");
                    Console.WriteLine("e (B com 1.30m de altura e crescimento de 0.08m ao ano)");
                    do
                    {
                        arvoreA = arvoreA + crescimentoA;
                        arvoreB = arvoreB + crescimentoB;
                        ano++;

                    } while(arvoreA < arvoreB );

                    Console.WriteLine("Em {0} arvore A sera maior que a arvore B ", ano);
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                #endregion
                #region Exercicio 8
                case 8:
                    Console.Write("Digite um número inteiro de 4 algarismos: ");
                    int palin = int.Parse(Console.ReadLine());
                    if (palin / 100 == palin % 100)
                    {
                        Console.Write("o número é palíndromo");
                        break;
                    }
                    else
                    {
                        Console.Write("o número não é palíndromo");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                #endregion
                default:
                    Console.Clear();
                    Console.Write("\n\tEscolha uma opção válida!!");
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
            }

        }
    }
}
