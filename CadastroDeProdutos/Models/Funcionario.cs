namespace CadastroDeProdutos.Models
{
    public class Funcionario
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string DataCadastro { get; set; }

        public Funcionario(string codigo, string nome, string email, string senha, string dataCadastro)
        {
            Codigo = codigo;
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCadastro = dataCadastro;
        }

    }
}