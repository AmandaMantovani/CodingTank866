using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank
{
    class Aula3
    {
        static void Aula3Main(string[] args)
        {
            /*
            int[] vetorInteiro;
            int[] vetorInteiro2 = new int[5];
            int[] vetorInteiro3 = new int[5] { 1, 2, 3, 4, 5 };
            int[] vetorInteiro4 = { 1, 2, 3, 4, 5 };

            vetorInteiro2[0] = 10;
            vetorInteiro2[1] = 15;
            vetorInteiro2[2] = 20;
            vetorInteiro2[3] = 25;
            vetorInteiro2[4] = 30;

            Console.WriteLine(vetorInteiro2[0]);
            Console.WriteLine(vetorInteiro2[1]);
            Console.WriteLine(vetorInteiro2[2]);
            Console.WriteLine(vetorInteiro2[3]);
            Console.WriteLine(vetorInteiro2[4]);
            */
            /*
            decimal[] notasAluno = new decimal[4];

            Console.WriteLine("Digite a nota do exercicio 1: ");
            notasAluno[0] = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do exercicio 2: ");
            notasAluno[1] = decimal.Parse(Console.ReadLine());

            decimal media = (notasAluno[0] + notasAluno[1] + notasAluno[2] + notasAluno[3]) / 4;

            Console.WriteLine($"A média do aluno é {media}");
            */
            //Exercicio prático
            // Faça um programa que recebe os três lados de um triângulo e diz se
            // é Equilátero:  todos os lados são iguais
            //  Isósceles: apenas dois lados são iguais
            //  Escaleno: todos os lados são diferentes.
            // notasAluno[0] == notasAluno[1] == notasAluno[2]
            /*
            int tamanho = 10;
            int[] idades = new int[tamanho];

            Console.WriteLine(idades.Length);
            */
            /*
            decimal i = 0;
            while(i < 5)
            {
                Console.WriteLine($"Valor do i dentro while {i}");
                i++;
            }

            Console.WriteLine($"Valor do i fora do loop while: {i}");

            i = 0;
            do
            {
                Console.WriteLine($"Valor do i dentro do while {i}");
                i++;
            } while (i < 5);

            Console.WriteLine($"Valor do i fora do loop do while: {i}");

            */

            /*
            Console.WriteLine($"Tamanho do array: {notas.Length}");

            while (i < notas.Length)
            {
                Console.WriteLine($"Informe a nota do exercício { i + 1 }");
                notas[i] = decimal.Parse(Console.ReadLine());
                soma += notas[i];
                i++;
                Console.WriteLine($"Valor do i: {i}");
            }
            Console.WriteLine($"A média do aluno foi { soma / qtdNotas }");
            
            */
            /*
            int qtdNotas = 4;
            decimal[] notas = new decimal[qtdNotas];
            int i = 0;
            decimal soma = 0;
            do
            {
                Console.WriteLine("Informe a nota do exercício " + (i + 1));
                notas[i] = decimal.Parse(Console.ReadLine());
                soma += notas[i];
                i++;

                Console.WriteLine($"Valor do i: {i}");

            } while (i < notas.Length);

            Console.WriteLine($"A média do aluno foi { soma / qtdNotas }");
            */
            /*
            string entrada = "";
            int[] triangulo = new int[3];

            do
            {
                Console.WriteLine($"Digite o lado do triângulo: ");
                entrada = Console.ReadLine();
            }
            while (!int.TryParse(entrada, out triangulo[0]));
            */
            /*
            decimal[] notas = new decimal[4];
            decimal soma = 0;

            for (int i = 0; i < notas.Length ; i++)
            {
                Console.WriteLine($"Informe a nota do exercicio {i + 1}");
                notas[i] = decimal.Parse(Console.ReadLine());
                soma += notas[i];
            }

            Console.WriteLine("Média do aluno é: " + (soma / 4));
            */
            /*
            decimal[] notas = new decimal[4];
            decimal soma = 0;

            int i = 0;

            for ( ; ; )
            {
                Console.WriteLine($"Informe a nota do exercicio {i + 1}");
                notas[i] = decimal.Parse(Console.ReadLine());
                soma += notas[i];
                i++;
                if (i == notas.Length)
                {
                    break;
                }
            }

            Console.WriteLine("Média do aluno é: " + (soma / 4));

            decimal[] notas = new decimal[4];
            decimal soma = 0;

            int i = 0;

            for ( ; ; )
            {
                Console.WriteLine($"Informe a nota do exercicio {i + 1}");
                notas[i] = decimal.Parse(Console.ReadLine());
                soma += notas[i];
                i++;

                if (i == notas.Length)
                {
                    break;
                }

                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine("Nota registrada");
            }

            Console.WriteLine("Média do aluno é: " + (soma / 4));
            */

            /*
             * 
             * 
             * Faça um programa que leia um número e
             * mostre a tabuada de multiplicação dele.
             * 
             * 
             * 
             * Ler um vetor com 10 inteiros e 
             * descubra o maior e o menor elemento do vetor.
             * 
             * 
             * */
            /*
            int valorMaior = int.MaxValue;
            int i = 1;

            int[] vetor = new int[i + 1];

            int valor = vetor[i + 1];
            */
            /*
            int x = 5;
            int y = 18;
            int z = 7;

            for (int i = 0; i <= 3; i++)
            {
                if ((x - 1) > 2)
                    y = y + 1;
                else
                    y = y - 1;
                z = z + x + y;
                x--;
            }*/
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            /*
            decimal a = 15;
            decimal b = 7;
            decimal c = 8;
            decimal d = 11;

            a = b;
            b = c;
            c = d;
            d = a;

            b = c + a;
            c = d - b;
            d = d + a * 2 - b;
            a = b / 2;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            */


        }
    }
}
