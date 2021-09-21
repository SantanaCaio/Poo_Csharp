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

            LoginController loginController = new LoginController();
            List<Login> listLogin = new List<Login>();


            string opcao;



            {


            } while (true)




                do
                {

                    Console.WriteLine($"[ 1 ] - CADASTRAR VEICULOS");// <- OK - Cadastro de VEICULOS -------------------
                    Console.WriteLine($"[ 2 ] - LISTAR VEICULOS"); // < - (Listar usuario) -----------------------
                    Console.WriteLine($"[ 3 ] - CADASTRAR USUÁRIO");// <- OK - Cadastro de usuario 
                    Console.WriteLine($"[ 4 ] - CONSULTAR VEICULO");// < - (consulta veiculo) -------------------
                    Console.WriteLine($"[ 5 ] - REMOVER VEICULO"); //  < - (Remover veiculo) ----------------------
                    Console.WriteLine($"[ 6 ] - LISTAR USUARIO"); //  < - (consulta usuario) ---------------------
                    Console.WriteLine($"[ 7 ] - CONSULTAR USUARIO"); //  < - (consulta usuario) ------------
                    Console.WriteLine($"[ 8 ] - REMOVER USUARIO"); //  < - (remover usuario) -----------
                    Console.WriteLine($"\n[ 0 ] - SAIR");
                    opcao = Console.ReadLine();





                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine($"MEU LOGIN");
                            Console.WriteLine($"DIGITE O SEU EMAIL");
                            string email = Console.ReadLine();
                            Console.WriteLine($"DIGITE SUA SENHA");
                            string senha = Console.ReadLine();

                            Login emailEncontrado = loginController.ConsultaUsuario(email, listLogin);

                            if (emailEncontrado.Senha == senha)
                            {
                                listaVeiculo.Add(VeiculoController.CadastrarVeiculo());
                            }
                            else
                            {
                                Console.WriteLine($"Senha invalida");
                            }
                            break;
                        case "2":
                            //Listar
                            VeiculoController.ListarVeiculo(listaVeiculo);
                            break;

                        case "0":
                            //Sair
                            Console.WriteLine($"Obrigado por utilizar o nosso sistema.");

                            break;
                        case "3":// < ---------------------------------- 
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

                        case "5":
                            // Remover veiculo
                            Console.WriteLine($"Digite o chassi do veiculo");
                            string chassiParaRemover = Console.ReadLine();
                            VeiculoController.RemoverVeiculo(chassiParaRemover, listaVeiculo);

                            break;
                        case "6":
                            // LISTAR USUARIO
                            loginController.ListarLista(listLogin);
                            break;
                        case "7":
                            // CONSULTAR USUARIO

                            Console.WriteLine($"Digite o Email do usuario: ");
                            string usuarioPesquisado = Console.ReadLine();
                            Login emailPesquisado = loginController.BuscarUsuario(usuarioPesquisado, listLogin);
                            if (emailPesquisado == null)
                            {
                                Console.WriteLine($"Usuario não encontrado");

                            }
                            else
                            {
                                Console.WriteLine($"Usuario retornado {emailPesquisado.Email}");
                            }

                            break;

                        case "8":
                            // Remover USUARIO
                            Console.WriteLine($"Digite o Email do usuario a ser removido!");
                            string usuarioParaRemover = Console.ReadLine();
                            loginController.RemoverUsuario(usuarioParaRemover, listLogin);

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
