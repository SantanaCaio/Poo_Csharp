using System;
using System.Collections.Generic;
using c05___CHARP_POO.Models;

namespace c05___CHARP_POO.Controller
{
    public class VeiculoController
    {
        public Veiculo CadastrarVeiculo()
        {

            Console.WriteLine($"Digite o tipo do Veiculo");
            string tipo = Console.ReadLine();

            Console.WriteLine($"Digite o modelo do Veiculo");
            string modelo = Console.ReadLine();

            Console.WriteLine($"Digite o marca do Veiculo");
            string marca = Console.ReadLine();

            Console.WriteLine($"Digite o ano do Veiculo");
            int ano = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(tipo, marca, modelo, ano);

            return veiculo; 
        }

        public void ListarVeiculo(List<Veiculo> listaVeiculo){
            foreach (var item in listaVeiculo)
            {
                Console.WriteLine($" Modelo : {item.Modelo} \n Marca : {item.Marca} \n Tipo : {item.Tipo} \n Ano :{item.Ano}");   
            }
        }

    }
}

// cadastro de usuarios

