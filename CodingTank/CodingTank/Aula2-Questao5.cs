using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank
{
    class Aula2_Questao5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salário do colaborador:");
            decimal salario = decimal.Parse(Console.ReadLine());
            decimal aliquota = 0;

            if (salario <= 1212M)
            {
                aliquota = 7.5M;
            }
            else if (salario <= 2427.35M)
            {
                aliquota = 9;
            }
            else if (salario <= 3641.03M)
            {
                aliquota = 12;
            }
            else
            {
                aliquota = 14;
            }

            decimal valorINSS = salario * aliquota / 100;

            Console.WriteLine($"O valor do INSS corresponde a R${valorINSS}");
        }
    }
}
