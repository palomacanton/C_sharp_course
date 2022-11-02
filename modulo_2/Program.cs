using System;

namespace modulo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-) Exemplos: operadores aritméticos, operadores relacionais, operadores lógicos.

            //operadores aritméticos

            /*não executar
            Math.pow(X,2) -> variável 'X' é elevada ao '2', ou seja, primeiramente a base e depois o expoente
            25 % 2 -> Retorna 1, ou seja, o resto da divisão por 2 é '1'.
            24 % 2 ->Retorna 0, ou seja, o resto da divisão por 2 é '0'. */

            //operadores relacionais (verdadeiro ou falso)
            /*double nota1 = 8.0;
            double nota2 = 9.0;

            Console.WriteLine("Nota maior que 7? {0}", nota1 > 7.0);
            Console.WriteLine("Tirou 10? {0}", nota2 == 10.0);*/

            /*Console.WriteLine("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);//out-> é uma forma de dar saída para um valor, indica que o argumento a ser passado(input) receberá um valor dentro do método(TryParse)
                //TryParse -> string de um número em um inteiro
            Console.WriteLine("Nota maior que 7? {0} ", nota > 7.0);
            Console.WriteLine("Tirou 10? {0} ", nota == 10.0);*/

            /*operadores lógicos:
            &&-"E", ||="OU", !-"NÃo"
            */

            //2-) Exemplos: operadores unários, estruturas de controle, estruturas de controle.

            //operadores unários
            /*
            var X = false;
            var n1 = 6;
            var n2 = 5;
            var n3 = 7;
            var n4 = 8;

            Console.WriteLine(!X);
            n3++;
            Console.WriteLine(n3);
            n4--;
            Console.WriteLine(n4);
 
            Console.WriteLine(n2 == --n1);
            Console.WriteLine(n2-- == ++n1);
            */

            //estruturas de controle (if/else)
            /*
            var n1 = 5;
            var n2 = 9;
            var n3 = 10;

            if(n1 < n2){
                Console.WriteLine("Condição 1 é satisfeita!!");
                Console.WriteLine("Resultado da soma é {0}", n1 + n2);
            }
            if(n3 < n2){
                Console.WriteLine(n3 + n2);
            }
            else{
                Console.WriteLine("Condição 2 não é satisfeita!!!");
            }
            */

            //estruturas de controle (Switch) -> não funciona
            /*
            Console.WriteLine("Qual a nota você da para o prato? 0, 5 ou 10");
            int.TryParse(Console.ReadLine(), out int nota);

            Switch(nota){
                case 0:
                    Console.WriteLine("Comida muito ruim!");
                break;
                case 5:
                    Console.WriteLine("Comida razoável.");
                break;
                case 10:
                    Console.WriteLine("Comida muito boa!");
                break;
                default:
                    Console.WriteLine("Nota inexistente");
                break;
            }
            */

            //3-) Exemplos: estruturas de controle(while), estruturas de controle(for).

            //estruturas de controle (While)
            /*
            var n1 = 1;

            while(n1 <= 15){
                Console.WriteLine(n1);
                n1++;
            }
            */

            //Estruturas de controle (For)

            for(int n1 = 1; n1 <= 10; n1++){
                Console.WriteLine(n1);
            }
        }
    }
}
