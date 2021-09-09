using System;

namespace ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcoes = "";
            Celular motorola = new Celular();
            motorola.cor = "vermelho";
            motorola.modelo = "motoG";
            motorola.tamanho = "5";

            do
            {

                Console.WriteLine($"Escolha uma das opções abaixo \n");
                Console.WriteLine($"[ 1 ] - Ligar Celular:");
                Console.WriteLine($"[ 2 ] - Desligar Celular:");
                Console.WriteLine($"[ 3 ] - Fazer Liagação:");
                Console.WriteLine($"[ 4 ] - Enviar Mensagem:");

                opcoes = Console.ReadLine();



                switch (opcoes)
                {
                    case "1":
                        if (motorola.ligado == true)
                        {
                            Console.WriteLine($"O celular já está ligado");
                        }
                        else
                        {
                            Console.WriteLine($"Ligando o Celular");
                            motorola.Ligar();
                        }
                        break;
                    case "2":

                        if (motorola.ligado == true)
                        {
                            motorola.Desligar();
                        }
                        else
                        {
                            Console.WriteLine($"O telefone já está Desligado");
                        }
                        break;
                    case "3":
                        if (motorola.ligado == true)
                        {
                            Console.WriteLine($"Fazendo Ligação");
                            motorola.FazerLigacao();
                        }
                        else
                        {
                            Console.WriteLine($"Ligue o Celular");
                        }
                        break;
                    case "4":
                        if (motorola.ligado == true)
                        {
                            Console.WriteLine($"Enviando Mensagem");
                            motorola.EnviarMensagem();

                        }
                        else
                        {
                            Console.WriteLine($"Ligue o Celular");
                        }
                        break;
                    default:
                        Console.WriteLine($"Opção Inválida, tente Novamente!");
                        break;
                }
            } while (true);
        }
    }
}