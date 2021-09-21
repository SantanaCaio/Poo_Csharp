namespace CadastroDeProdutos.Models
{
    public class Produtos
    {

        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public string CadastradoPor { get; set; }
        public string DataCadastro { get; set; }

        public Produtos(int codigo, string nomeproduto, double preco, string cadastradoPor, string dataCadastro)
        {
            Codigo = codigo;
            NomeProduto = nomeproduto;
            Preco = preco;
            CadastradoPor = cadastradoPor;
            DataCadastro = dataCadastro;
        } 
    }
}