using System;
using c05___CHARP_POO.Controller;


namespace c05___CHARP_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
                        VeiculoController VeiculoController  = new VeiculoController();
            do
            {
                Console.WriteLine($"[ 1 ] - CADASTRAR VEICULOS");
                Console.WriteLine($"[ 2 ] - LISTAR VEICULOS");
                Console.WriteLine($"\n[ 0 ] - SAIR");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //cadastrar
                        VeiculoController.CadastrarVeiculo();
                        break;

                    case "2":
                        //Listar
                        VeiculoController.ListarVeiculo();
                        break;

                    case "0":
                        //Sair
                        Console.WriteLine($"Obrigado por utilizar o nosso sistema.");
                        
                        break;

                    default:
                        Console.WriteLine($"opção invalida, digite novamente!");

                        break;
                }
            } while (opcao != "0");
        }
    }
}
