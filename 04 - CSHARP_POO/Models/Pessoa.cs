using System;
using System.Collections.Generic;

namespace _04___CSHARP_POO.Models
{
    public class Pessoa
    {
        // definir os atributos

        public string nome;
        public string sobrenome;
        public string telefone;
        public int idade;

        public Pessoa(string nomeDigitado, string sobrenomeDigitado, string telefoneDigitado, int idadeDigitado)
        {
            this.nome = nomeDigitado;
            this.sobrenome = sobrenomeDigitado;
            this.telefone = telefoneDigitado;
            this.idade = idadeDigitado;

        }
        public Pessoa(string nomeDigitado, string sobrenomeDigitado, int idadeDigitado)
        {
            this.nome = nomeDigitado;
            this.sobrenome = sobrenomeDigitado;
            this.idade = idadeDigitado;
        }

        public void ExibirPessoas(List<Pessoa> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine($" nome : {item.nome} \n sobrenome : {item.sobrenome}  \n Idade : {item.idade}  \n Telefone : {item.telefone}\n\n\n");
            }
        }
    }
}