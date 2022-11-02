using System;

namespace C_Sharp_course
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-) Exemplos: comentário, variáveis e concatenação.
            /* int x = 4;
            double y = 3.3;
            //const faz com que a variável nunca mude de valor
            const double frequencia = 60;

            double area = x * y;
            Console.WriteLine("Aárea do quadrado é " + area);*/

            //2-) Exemplos: conversão implícita(não funciona!!!), conversão explicita, uso da classe ‘convert’.

            //conversão implícita
            /*int x = 4;
            double x = y; 
            Console.WriteLine(y);*/
            
            //conversão explícita
            /*double nota = 8.6;
            int noteconvertida = (int)nota; 
            Console.WriteLine(noteconvertida);*/

            //uso da classe convert
            /*Console.WriteLine("Qual número é sua casa: ");
            string nmrCasa = Console.ReadLine();
            int numero = int.Parse(nmrCasa);
            Console.WriteLine("O número é sua casa {0}", numero);

            numero = Convert.ToInt32(nmrCasa);

            Console.WriteLine(numero);*/

            //3-) Exemplos: formatação, leitura de dados, inferência.

            //formatação (o número depois da letra indica as casas decimais)
            /*double x = 20.232;
            Console.WriteLine(x.ToString("F1")); //' xx,x '
            Console.WriteLine(x.ToString("C2")); //' R$ xx,xx '
            Console.WriteLine(x.ToString("P3")); //' x.xxx,xxx% ' */

            //leitura de dados
            /*Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos anos você tem?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é {0} e sua idade é de {1}", nome, idade);*/

            //inferência(utilizando 'var')
            var idade = 25;
            var salario = 1285.76;

            Console.WriteLine("Idade {0}, Salário {1}", idade, salario);
        }
    }
}
