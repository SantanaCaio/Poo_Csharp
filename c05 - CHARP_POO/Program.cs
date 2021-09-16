using System;
using System.Collections.Generic;
using c05___CHARP_POO.Controller;
using c05___CHARP_POO.Models;

namespace c05___CHARP_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoController VeiculoController = new VeiculoController();
            List<Veiculo> listaVeiculo = new List<Veiculo>();

            string opcao;
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
                        listaVeiculo.Add(VeiculoController.CadastrarVeiculo());

                        break;

                    case "2":
                        //Listar
                        VeiculoController.ListarVeiculo(listaVeiculo);
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
