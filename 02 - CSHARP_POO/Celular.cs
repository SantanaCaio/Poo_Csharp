using System;

namespace ex_01
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public string tamanho;

        public bool ligado = false;

        public void Ligar()
        {
                ligado = true;

        }

        public void Desligar()
        {
            ligado = false;
        }

        public void FazerLigacao()
        {
                        
        }
        public void EnviarMensagem()
        {
           
        }



    }
}