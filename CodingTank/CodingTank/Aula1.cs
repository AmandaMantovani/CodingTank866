using System;

namespace CodingTank
{
    class Aula1
    {
        //Para executar renomeie para Main
        static void MainAula1(string[] args)
        {

            // Comentar uma linha

            /*
             * Comentário em bloco
             * 
             */

            /*
            Comentário em bloco
            */

            // Variável do tipo inteiro, aceita valores inteiros sem casas decimais
            Console.WriteLine("Valores inteiros");
            int valor = 10;

            Console.WriteLine(valor);

            // Uma variável pode ter seu valor alterado em qualquer momento
            valor = 12;

            Console.WriteLine(valor);

            Console.WriteLine();
            Console.WriteLine("Valores com decimal");
            //Variável do tipo float, aceita valores com casas decimais
            //É identificado pelo caracter F após o decimal
            float valorFloat = 10.4F;

            //Variável do tipo decimal, aceita valores com casas decimais
            //É identificado pelo caracter M após o decimal
            decimal valor3 = 25.8M;

            //Variável do tipo double, aceita valores com casas decimais
            //É identificado sem caracter ou pelo caracter D após o decimal
            double valor4 = 10.6;

            double valor5 = 10.9D;

            //Console.WriteLine exibe valores ou textos para o usuário
            Console.WriteLine(valorFloat);

            Console.WriteLine(valor3);

            Console.WriteLine(valor4);

            Console.WriteLine(valor5);

            Console.WriteLine();
            Console.WriteLine("Variável de textos");
            //Variável do tipo string, aceita valores em texto
            string texto = "Coding tank";

            Console.WriteLine(texto);
            
            Console.WriteLine();
            Console.WriteLine("Variáveis lógicas");
            //Variável do tipo bool, aceita valores booleanos: true ou false
            bool logico = false;
            Console.WriteLine(logico);

            logico = true;
            Console.WriteLine("Alterando valor da variavel logica");
            Console.WriteLine(logico);

            //Variável do tipo DateTime é utilizada para registrar Data e Hora
            //Podemos declara-la de várias formas, abaixo alguns exemplos
            Console.WriteLine();
            Console.WriteLine("Variáveis de data e hora");

            //Variável iniciada com o valor padrão (default) '01/01/0001 00:00:00'
            DateTime data = new DateTime();
            Console.WriteLine(data);

            //Variável iniciada com o valor informado, seguindo ANO, MES, DIA
            DateTime data2 = new DateTime(2022, 04, 12);
            Console.WriteLine(data2);

            //Variável iniciada com o valor atual da máquina
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);

            //Variável iniciada com o valor informado, seguindo ANO, MES, DIA, HORA, MINUTOS, SEGUNDOS
            DateTime dataHora = new DateTime(2022, 04, 12, 20, 40, 40);
            Console.WriteLine(dataHora);

            //Funções prontas para utilização da data
            Console.WriteLine(dataAtual.Year);
            Console.WriteLine(dataAtual.Month);
            Console.WriteLine(dataAtual.Day);
            Console.WriteLine(dataAtual.Hour);
            Console.WriteLine(dataAtual.DayOfWeek);
            Console.WriteLine(dataAtual.DayOfYear);

            //Console.ReadLine() é utilizado para realizar a leitura de uma entrada do usuário
            Console.WriteLine();
            Console.WriteLine("Utilizando ReadLine");
            Console.WriteLine("Digite uma palavra:");
            string valorDigitado = Console.ReadLine();

            Console.WriteLine("A palavra digitada foi:");
            Console.WriteLine(valorDigitado);

            // Ao criar uma variável, não é necessário declarar o seu tipo
            // Porém é uma boa prática tipar uma variável quando:
            // Seu valor não está sendo atribuido na inicialização ou
            // Seu tipo não pode ser identificado claramente
            var texto2 = "Texto";

            Console.WriteLine(texto2);

            //Exercicio em sala para prática
            Console.WriteLine();
            Console.WriteLine("Exercício");
            string nome = "Amanda";
            int idade = 27;
            DateTime dataDeNascimento = new DateTime(1994, 5, 9);

            Console.WriteLine("Nome:");
            Console.WriteLine(nome);
            Console.WriteLine("Idade:");
            Console.WriteLine(idade);
            Console.WriteLine("Data de nascimento:");
            Console.WriteLine(dataDeNascimento.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Digite seu Nome");
            nome = Console.ReadLine();
            Console.WriteLine("Idade");
            string idadeStr = Console.ReadLine();
            Console.WriteLine("Data de nascimento");
            string dataNascimentoStr = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Seu Nome:");
            Console.WriteLine(nome);
            Console.WriteLine("Sua Idade:");
            Console.WriteLine(idadeStr);
            Console.WriteLine("Sua Data de nascimento:");
            Console.WriteLine(dataNascimentoStr);

        }
    }
}
