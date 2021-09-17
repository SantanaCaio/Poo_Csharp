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

            Console.WriteLine($"Digite o ano do veiculo");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o numero do chassi");
            string chassi = Console.ReadLine();

            Veiculo veiculo = new Veiculo(tipo, marca, modelo, ano, chassi);

            return veiculo;
        }

        public void ListarVeiculo(List<Veiculo> listaVeiculo)
        {
            foreach (var item in listaVeiculo)
            {
                Console.WriteLine($" Modelo : {item.Modelo} \n Marca : {item.Marca} \n Tipo : {item.Tipo} \n Ano :{item.Ano}");
            }
        }

        // metodo para buscar veiculo

        public Veiculo BuscarVeiculo(string chassiPesquisado, List<Veiculo> lista)
        {
            Veiculo veiculoRetornado = lista.Find(Veiculo => Veiculo.Chassi == chassiPesquisado);
            return veiculoRetornado;
        }




        
        public void RemoverVeiculo(string chassiPesquisado, List<Veiculo> lista)
        {
            Veiculo removerVeiculo = lista.Find(Veiculo => Veiculo.Chassi == chassiPesquisado);
            
        }
    }
}

// cadastro de usuarios

