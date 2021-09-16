namespace c05___CHARP_POO.Models
{
    public class Veiculo
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Chassi { get; set; }
        
        public Veiculo(string tipo, string marca, string model, int ano, string chassi){
            Tipo = tipo;
            Marca = marca;
            Modelo =  model;
            Ano = ano;
            Chassi = chassi;
        }
    }
}