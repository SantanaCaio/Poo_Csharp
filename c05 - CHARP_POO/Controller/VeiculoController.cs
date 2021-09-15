using System;
using System.Collections.Generic;
using c05___CHARP_POO.Models;

namespace c05___CHARP_POO.Controller
{
    public class VeiculoController
    {
        public List<veiculo> listaVeiculo = new List<veiculo>();
        public void CadastrarVeiculo()
        {
            Console.WriteLine($"Digite o tipo do Veiculo");
            string tipo = Console.ReadLine();

            Console.WriteLine($"Digite o modelo do Veiculo");
            string modelo = Console.ReadLine();

            Console.WriteLine($"Digite o marca do Veiculo");
            string marca = Console.ReadLine();

            Console.WriteLine($"Digite o ano do Veiculo");
            int ano = int.Parse(Console.ReadLine());

            veiculo veiculo = new veiculo(tipo, marca, modelo, ano);

            listaVeiculo.Add(veiculo);   
        }

        public void ListarVeiculo(){
            foreach (var item in listaVeiculo)
            {
                Console.WriteLine($"{item.Modelo} {item.Marca} {item.Tipo} {item.Ano}");   
            }
        }
    }
}