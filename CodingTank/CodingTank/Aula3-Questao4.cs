using System;

namespace CodingTank
{
    class Aula3_Questao4
    {
		public static void Main()
        {
            //Declaração de variáveis
            int qtdPatos = 0;
            do
            {
                Console.WriteLine("Quantos patinhos foram passear com sua mamãe pata?");
                int.TryParse(Console.ReadLine(), out qtdPatos);
                if (qtdPatos < 1)
                {
                    Console.WriteLine("Digite um valor inteiro válido maior que zero");
                }
            } while (qtdPatos <= 0);

            int totalPatos = qtdPatos;

            while (qtdPatos > 1)
            {
                Console.WriteLine($"{qtdPatos} patinhos foram passear \nAlém das montanhas \nPara brincar \nA mamãe gritou: Quá, quá, quá, quá");
                if (qtdPatos > 2)
                {
                    Console.WriteLine($"Mas só {--qtdPatos} patinhos voltaram de lá.\n");
                }
                else
                {
                    Console.WriteLine($"Mas só {--qtdPatos} patinho voltou de lá.\n");
                }
            }

            Console.WriteLine($"{qtdPatos} patinho foi passear " +
                                "Além das montanhas \nPara brincar \n" +
                                "A mamãe gritou: Quá, quá, quá, quá \n" +
                                "Mas nenhum patinho voltou de lá.\n");

            Console.WriteLine($"A mamãe patinha foi procurar \nAlém das montanhas \nNa beira do mar \nA mamãe gritou: Quá, quá, quá, quá");

            if (totalPatos == 1)
            {
                Console.WriteLine($"E {totalPatos} patinho voltou de lá.");
            }
            else
            {
                Console.WriteLine($"E os {totalPatos} patinhos voltaram de lá.");
            }
        }
	}
}
