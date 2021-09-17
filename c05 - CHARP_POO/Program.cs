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
            LoginController loginController = new LoginController();

            List<Veiculo> listaVeiculo = new List<Veiculo>();
            List<Login> listLogin = new List<Login>();


            string opcao;


            do
            {
                Console.WriteLine($"[ 1 ] - CADASTRAR VEICULOS");
                Console.WriteLine($"[ 2 ] - LISTAR VEICULOS");
                Console.WriteLine($"[ 3 ] - CADASTRAR USUÁRIO");
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
                    case "3":
                        //CADASTRAR USUARIO
                        listLogin.Add(loginController.CadastrarUsusario());
                        break;

                    case "4":
                        //Pesquisa chassi
                        Console.WriteLine($"Digite o chassi do veiculo");
                        string chassiPesquisado = Console.ReadLine();
                        Veiculo veiculoPesquisado = VeiculoController.BuscarVeiculo(chassiPesquisado, listaVeiculo);
                        if (veiculoPesquisado == null)
                        {
                            Console.WriteLine($"Veiculo não encontrado");

                        }
                        else
                        {
                            Console.WriteLine($"Veiculo retornado {veiculoPesquisado.Modelo}");
                        }

                        break;

                    default:
                        Console.WriteLine($"opção invalida, digite novamente!");

                        break;
                }
            } while (opcao != "0");
        }
    }
}



// Cadastro de pessoas

// Loggin


// ID e Senha
