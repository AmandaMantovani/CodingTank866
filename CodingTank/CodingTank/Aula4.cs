using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank
{
    class Aula4
    {
        static void MainAula4(string[] args)
        {


            /*
            int[,] matriz2 = new int[4, 2]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 },
                { 7, 8 }
            };

            int[,] matriz3 = new int[,] { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 }, { 7, 8, 9 } };

            matriz[0, 0] = int.Parse(Console.ReadLine());
            matriz[0, 1] = 10;

            matriz[3, 0] = 15;

             * 
                { valor digitado, 10 },
                { 0, 0 },
                { 0, 0 },
                { 15, 0 }

            */
            /*
            //int[,] matriz = new int[linha, coluna];
            int[,] matriz = new int[3, 2];

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.WriteLine($"Insira o valor da linha {l} e da coluna {c}: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }
            /*
            matriz[0, 0];
            matriz[0, 1];
            matriz[1, 0];
            matriz[1, 1];
            matriz[2, 0];
            matriz[2, 1];
            */
            /*
            for (int l = 0; l < 3; l++)
            {
                Console.WriteLine($"Linha {l}");
                for (int c = 0; c < 2; c++)
                {
                    Console.WriteLine($"Coluna {c}");
                    Console.WriteLine($"Valor salvo: {matriz[l, c]} \n");
                }
            }
            */
            /*
            int[,] matriz = new int[3, 3];
            int cont = 0;


            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine("Digite um valor para salvar na matriz: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());

                    if (matriz[l, c] > 10)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine($"Sua matriz possui {cont} números maior que 10, que são:");

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (matriz[l, c] > 10)
                    {
                        Console.WriteLine(matriz[l, c]);
                    }
                }
            }
            */
            /*
            List<int> lista;
            //List<int> lista2 = new List<int>();
            List<int> lista3 = new List<int>() { 1, 2 };

            lista = new List<int>() { 1 };
            lista.Add(3);
            lista.Add(3);
            lista.Add(5);
            Console.WriteLine("Digite um valor para inserir na lista");
            lista.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("\n Valores da lista:");
            foreach(int numero in lista)
            {
                Console.WriteLine(numero);
            }

            lista.Remove(3);

            lista.RemoveAt(0);

            Console.WriteLine("\n Valores da lista após remoção:");
            foreach (int numero in lista)
            {
                Console.WriteLine(numero);
            }

            List<int> lista2 = new List<int>() { 50, 60, 70 };

            lista.AddRange(lista2);

            /*
            foreach (int numero2 in lista2)
            {
                lista.Add(numero2);
            }
            */
            /*
            Console.WriteLine("\n Valores da lista após inserção da lista 2:");
            foreach (int numero in lista)
            {
                Console.WriteLine(numero);
            }

            int valor1 = 55;

            lista.Insert(2, valor1);

            lista.Insert(10, valor1);

            Console.WriteLine("\n Valores da lista final:");
            foreach (int numero in lista)
            {
                Console.WriteLine(numero);
            }


            Console.WriteLine($"Tamanho da minha lista: {lista.Count}");
            Console.WriteLine($"Valor {valor1} contém na minha lista? {lista.Contains(valor1)}");
            */

            Dictionary<string, string> dicionarioEstados = new Dictionary<string, string>();

            dicionarioEstados.Add("SP", "São Paulo");
            dicionarioEstados.Add("PB", "Paraíba");

            Dictionary<decimal, decimal> faixaSalarial = new Dictionary<decimal, decimal>();
            faixaSalarial.Add(1300, 7.5M);
            faixaSalarial.Add(2500, 11);

            if (dicionarioEstados.ContainsKey("SP"))
            {
               Console.WriteLine(dicionarioEstados["SP"]);
            }

            if (!dicionarioEstados.ContainsValue("Rio de Janeiro"))
            {
                dicionarioEstados.Add("RJ", "Rio de Janeiro");
            }


            foreach(KeyValuePair<string, string> informacao in dicionarioEstados)
            {
                Console.WriteLine($"Chave {informacao.Key}, Valor: {informacao.Value}");
            }

        }
    }
}
