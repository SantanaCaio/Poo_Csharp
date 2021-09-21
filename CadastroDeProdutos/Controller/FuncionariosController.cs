using System;
using System.Collections.Generic;
using CadastroDeProdutos.Models;

namespace CadastroDeProdutos.Controller
{
    public class FuncionariosController
    {
        public void CadastroDeFuncionarios(List<Funcionario> listaFuncionarios)
        {
            Console.WriteLine($"Digite um codigo para o Funcionario");
            string codigo = Console.ReadLine();

            Console.WriteLine($"Digite o nome do funcionario");
            string nome = Console.ReadLine();

            Console.WriteLine($"Digite o email do funcionario");
            string email = Console.ReadLine();

            Console.WriteLine($"Digite uma senha");
            string senha = Console.ReadLine();

            Console.WriteLine($"Digite a data atual");
            string dataCadastro = Console.ReadLine();

            Funcionario funcionario = new Funcionario(codigo, nome, email, senha, dataCadastro);

            listaFuncionarios.Add(funcionario);
            Console.Clear();
            Console.WriteLine($"Funcionario Cadastrado Com sucesso!!\n\n");

        }

        public bool LoginFuncionario(List<Funcionario> listaFuncionarios)
        {
            Console.WriteLine($"Digite o email");
            string email = Console.ReadLine();

            Console.WriteLine($"Digite a senha");
            string senha = Console.ReadLine();

            Funcionario funcionarioEncontrado = listaFuncionarios.Find(Funcionario => Funcionario.Email == email);
            do
            {
                if (funcionarioEncontrado.Senha != senha)
                {
                    Console.WriteLine($"Email ou senha incorreto");
                    return false;
                }
                return true;
                
            } while (true);
        }

    }
}