using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank
{
    class Questao4
    {
        //Para executar renomeie para Main
        static void MainQuestao4(string[] args)
        {
            int respostasPositivas = 0;

            Console.WriteLine("Responda o questionário abaixo");
            Console.WriteLine("As opções são S - Sim ou N - Não");

            Console.WriteLine("Telefonou para a vítima?");
            if (Console.ReadLine() == "S") respostasPositivas++;

            Console.WriteLine("Esteve no local do crime?");
            if (Console.ReadLine() == "S") respostasPositivas++;

            Console.WriteLine("Mora perto da vítima?");
            if (Console.ReadLine() == "S") respostasPositivas++;

            Console.WriteLine("Devia para a vítima?");
            if (Console.ReadLine() == "S") respostasPositivas++;

            Console.WriteLine("Já trabalhou com a vítima?");
            if (Console.ReadLine() == "S") respostasPositivas++;

            switch (respostasPositivas)
            {
                case 2:
                    Console.WriteLine("Suspeita");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Cúmplice");
                    break;
                case 5:
                    Console.WriteLine("Assassino");
                    break;
                default:
                    Console.WriteLine("Inocente");
                    break;
            }

        }
    }
}
