using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank
{
    class Aula2
    {
        static void Main(string[] args)
        {

            int valor50;
            //Cast implicito
            double valor1 = 1;

            //Cast explicito
            int valor2 = (int)1.67;

            Console.WriteLine(valor2);

            Console.WriteLine("informe sua idade");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine(i);

            //int valor3 = int.Parse(null);

            //Console.WriteLine(valor3);

            int valor4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(valor4);

            valor4 = Convert.ToInt32("5");

            Console.WriteLine(valor4);
            Console.WriteLine("Digite uma data");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Data convertida:");
            Console.WriteLine(data);
            
            Console.WriteLine("Soma:");
            double soma = 1.67 + 1.98;
            Console.WriteLine(soma);

            Console.WriteLine("Subtração:");
            double subtracao = 1.67 - 1.98;
            Console.WriteLine(subtracao);

            Console.WriteLine("Multiplicação:");
            double multi = 1.67 * 1.98;
            Console.WriteLine(multi);

            Console.WriteLine("Divisão:");
            double div = 2 / 1;
            Console.WriteLine(div);

            double valor1 = 2;
            double valor2 = 0;

            double divZero = valor1 / valor2;

            Console.WriteLine("Divisão por zero:");
            Console.WriteLine(divZero);

            int valor4 = 2;
            double valor5 = 1.67;
            int valor3 = valor4 * (int)valor5;
            double valor6 = valor4 * valor5;
            Console.WriteLine(valor3);
            Console.WriteLine(valor6);

            int valor8 = 3;
            valor4 = 7;
            int valor7 = valor4 / valor8;
            Console.WriteLine(valor7);
            
            Console.WriteLine("Digite um numero");
            double numero1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite outro numero");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Soma:");
            double soma = numero1 + numero2;
            Console.WriteLine(soma);

            Console.WriteLine("Subtração:");
            double subtracao = numero1 - numero2;
            Console.WriteLine(Math.Round(subtracao, 4));

            Console.WriteLine("Multiplicação:");
            double multi = numero1 * numero2;
            Console.WriteLine(multi);

            Console.WriteLine("Divisão:");
            double div = numero1 / numero2;
            Console.WriteLine(Math.Round(div, 4));
            
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá" + nome);
            Console.WriteLine("Bem vinda " + nome + " ao curso de C#");
            
            Console.WriteLine("Digite valor :");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero digitado: " + valor1);


            Console.WriteLine("Digite outro valor :");
            int valor2 = int.Parse(Console.ReadLine());

            int valor3 = valor1 + valor2;
            Console.WriteLine("Numero digitado: " + valor1 + " " + valor2);
            Console.WriteLine("Numeros somados: " + (valor1 + valor2));
            Console.WriteLine("Numeros somados: " + valor3);
            
            Console.WriteLine("Digite valor :");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor :");
            int valor2 = int.Parse(Console.ReadLine());

            //Concatenar
            Console.WriteLine("Numero digitado: " + valor1);
            Console.WriteLine("Numero digitado: " + valor1 + " Segundo numero " + valor2);

            //Interpolar
            Console.WriteLine(@$"Numero digitado: {valor1}
            Segundo numero {valor2}");


            Console.WriteLine("Ler dois numeros, realizar os 4 calculos matematicos\n e exibir os valores na tela concatenados ou interpolados");
            Console.ReadLine();
            
            Console.WriteLine("Digite numero 1:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite numero 2:");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valores somados: {valor1 + valor2}");
            Console.WriteLine($"Valores subtraidos: {valor1 - valor2}");
            Console.WriteLine("Valores multiplicados: " + Math.Round(valor1 * valor2, 2));
            Console.WriteLine($"Valor divididos: {Math.Round(valor1 / valor2, 2)}\nFim das contas");

            Console.WriteLine(@$"A soma é {valor1 + valor2}
                A subtração é {valor1 - valor2} 
                A multiplicação é {valor1 * valor2}
                A divisão é {valor1 / valor2}");
            
            /*
             * > maior
             * < menor
             * >= maior ou igual
             * <= menor ou igual
             * == igual
             * != diferente
             */
            if (!(numero1 != numero2))
            {
                Console.WriteLine("Valores diferentes");
            }
            else
            {
                Console.WriteLine("Numeros iguais");
            }

            string nome = "Amanda";
            if (!(nome == "Amanda"))
            {
                Console.WriteLine("Nome diferente de Amanda");
            }
            else
            {
                Console.WriteLine("Nome igual a Amanda");
            }

            Console.WriteLine("Digite um numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero:");
            int numero2 = int.Parse(Console.ReadLine());

            //if ternário
            string texto = (numero1 > numero2) ? "Numero 1 maior" : "Numero 2 maior";

            Console.WriteLine(texto);

            string nome = "Amanda";
            if (nome == "Amanda")
            {

            }
            else
            {
                texto = "diferente";
                Console.WriteLine(texto);
            }

            Console.WriteLine("Digite o horario atual:");
            DateTime horaDoDia = DateTime.Parse(Console.ReadLine());

            if (horaDoDia.Hour >= 0 && horaDoDia.Hour < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horaDoDia.Hour >= 12 && horaDoDia.Minute < 30)
            {
                Console.WriteLine("Bom almoço!");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }

            Console.WriteLine(horaDoDia);
            
            Console.WriteLine("Descubra se você paga meia ou inteira");
            Console.WriteLine("Digite S - Sim ou N - Não");

            Console.WriteLine("É estudante?");
            string estudante = Console.ReadLine();

            Console.WriteLine("É doador de sangue?");
            string doadorDeSangue = Console.ReadLine();

            Console.WriteLine("É trabalhador da prefeitura?");
            string trabalhadorPrefeitura = Console.ReadLine();

            Console.WriteLine("Prefeitura tem contrato com cinema?");
            string contratoPrefeitura = Console.ReadLine();

            if (estudante == "S" ||
                doadorDeSangue == "S" ||
                (trabalhadorPrefeitura == "S" && contratoPrefeitura == "S"))
            {
                Console.WriteLine("Uhuu, paga meia!");
            }
            else
            {
                Console.WriteLine("Infelizmente paga inteira!");
            }

            Console.WriteLine("Infelizmente paga inteira!");

            Console.WriteLine("Descubra se você paga meia ou inteira");
            Console.WriteLine("Digite S - Sim ou N - Não");

            Console.WriteLine("É estudante?");
            bool estudante = Console.ReadLine() == "S" ? true : false;

            Console.WriteLine("É doador de sangue?");
            bool doadorDeSangue = Console.ReadLine() == "S" || Console.ReadLine() == "s";

            Console.WriteLine("É trabalhador da prefeitura?");
            bool trabalhadorPrefeitura = Console.ReadLine() == "S";

            Console.WriteLine("Prefeitura tem contrato com cinema?");
            bool contratoPrefeitura = Console.ReadLine() == "S";

            if (estudante ||
                doadorDeSangue ||
                (trabalhadorPrefeitura && contratoPrefeitura))
            {
                Console.WriteLine("Uhuu, paga meia!");
            }
            else
            {
                Console.WriteLine("Infelizmente paga inteira!");
            }

            Console.WriteLine("Digite um numero para dia da semana:");
            int diaDaSemana = int.Parse(Console.ReadLine());

            switch (diaDaSemana)
            {
                case 1:
                    Console.WriteLine("Segunda");
                    break;
                case 2:
                    Console.WriteLine("Terça");
                    break;
                case 3:
                    Console.WriteLine("Quarta");
                    break;
                case 4:
                    Console.WriteLine("Quinta");
                    break;
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Fim-de-semana!");
                    break;
                default:
                    Console.WriteLine("Numero inválido");
                    break;
            }

            int valors1 = 2;

            const int valors2 = 2;
            switch(valor1)
            {
                case > 1:
                    Console.WriteLine("Numero inválido");
                    break;
                case > 2:
                    Console.WriteLine("Numero inválido");
                    break;
            }

            if (valor1 > 1)
            {

            }
            else if (valor1 > 2)
            {

            }
            
        }

    }
}

