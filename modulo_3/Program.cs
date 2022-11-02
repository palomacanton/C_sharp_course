using System;

namespace modulo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-) Exemplos: leitura de notas, calculadora soma,

            //leitura de notas
            /*
            float media = 0;

            Console.WriteLine("Olá, bem vindo ao programa de cálculo de média!");
            Console.WriteLine("Ieri auxiliar você a calcular a média do seu aluno!");
            
            Console.WriteLine("Digite a primeira nota: ");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Digite a segunda nota: ");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Digite a terceira nota: ");
            int.TryParse(Console.ReadLine(), out int nota3);

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média do aluno é: {0}", media);

            if(media < 7){
                Console.WriteLine("Aluno está em recuperação");
            }
            else{
                Console.WriteLine("Aluno aprovado");
            }
            */

            //calculadora soma

            bool opcao = true;

            Console.WriteLine("Olá, irei realizar a soma de números que você deseja até você desejar parar");
            Console.WriteLine("Digite o valor inicial");
            float.TryParse(Console.ReadLine(), out float inicial);

            while(opcao == true){
                Console.WriteLine("Digite o número que deseja somar ao número inicial");
                float.TryParse(Console.ReadLine(), out float n1);
                inicial = inicial + n1;
                Console.WriteLine("A soma até o momento é {0}", inicial);
                Console.WriteLine("Deseja sair do programa? \n 1->sim \n 2->não");
                int.TryParse(Console.ReadLine(), out int saida);

                switch(saida){
                    case 1:
                        Console.WriteLine("Saindo do programa...");
                        opcao = false;
                        break;
                    case 2:
                        Console.WriteLine("Continue a Soma.");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Retornando para Soma.");
                        break;    

                }
            }
        }
    }
}
