using System;
using System.Collections.Generic;
using _04___CSHARP_POO.Models;

namespace _04___CSHARP_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pessoa p = new Pessoa("Carlos","Tsukamoto","190", 33);
            // Console.WriteLine($"nome: {p.nome} {p.sobrenome} {p.idade} {p.telefone}");
            // Pessoa p2 = new Pessoa("Caio","santana", 33);
            // Console.WriteLine($"nome: {p2.nome} {p2.sobrenome} {p2.idade} ");
            // Criar uma aplicação para cadastrar e listar 5 pessoas

            // Pessoa p1 = new Pessoa("Bianca", "sadf", "741852", 32);
            // Pessoa p2 = new Pessoa("Carlos", "asdff", "159221", 32);
            // Pessoa p3 = new Pessoa("Roberto", "adfs", "196350", 37);
            // Pessoa p4 = new Pessoa("Rogerio", "vcxz", "195350", 24);
            // Pessoa p5 = new Pessoa("marcelo", "fgj", "191310", 18);

            List<Pessoa> listaDePessoas = new List<Pessoa>();

            // listaDePessoas.Add(p1);
            // listaDePessoas.Add(p2);
            // listaDePessoas.Add(p3);
            // listaDePessoas.Add(p4);
            // listaDePessoas.Add(p5);


            Console.WriteLine($"digite um nome a ser cadastrado");
            string n = Console.ReadLine();

            Console.WriteLine($"digite um sobrenome a ser cadastrado");
            string s = Console.ReadLine();

            Console.WriteLine($"digite uma idade a ser cadastrada");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine($"digite um telefone a ser cadastrado");
            string t = Console.ReadLine();

            listaDePessoas.Add(new Pessoa(n, s, i));

  
        }
    }
}
