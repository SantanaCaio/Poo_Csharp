namespace CSHARP_POO
{
    public class Personagem
    {
        public string nome;

        public int idade;

        public string armadura;

        public string ia;

        private int vida = 100;

        public void Defender(int ataque){
            this.vida = this.vida - ataque;
        }
        public int ExibirVida(){
            return vida;
        }
    }
}