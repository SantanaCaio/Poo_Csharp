namespace CSHARP_POO
{
    public class Personagem
    {

        public string nome;
        public int idade;
        public int soco;
        public int chute;
        public string armadura;
        public string iA;

        private int vida = 100;

        public void Receber(int ataque)
        {
            this.vida = this.vida - ataque;
        }
        public int ExibirVida()
        {
            return vida;
        }


    }
}