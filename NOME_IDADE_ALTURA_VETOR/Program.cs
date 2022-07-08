using System;
using System.Globalization;

namespace NOME_IDADE_ALTURA_VETOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            string[] n;
            int[] idade;
            double[] alt;
            double soma = 0;

            Console.Write("Quantas pessoas serão inseridas? ");
            x = int.Parse(Console.ReadLine());

            n = new string[x];
            idade = new int[x];
            alt = new double[x];

            Console.WriteLine("Entre com o nome, idade e altura separados por espaço:");
            for (int i = 0; i < x; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                n[i] = s[0];
                idade[i] = int.Parse(s[1]);
                alt[i] = double.Parse(s[2]);
                soma += alt[i];
            }

            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                Console.Write(n[i] + " ");
                Console.Write(idade[i] + " ");
                Console.WriteLine(alt[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"A média de altura é {(soma / x).ToString("F2", CultureInfo.InvariantCulture)}.");

            int cont = 0;
            for (int i = 0;i < x; i++)
            {
                if (idade[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double)cont / x * 100;
            Console.WriteLine($"As pessoas com menos de 16 anos correspondem à {porcentagem}%.");





        }
    }
}
