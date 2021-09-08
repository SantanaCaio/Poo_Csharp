using System;

namespace CSHARP_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem perso1 = new Personagem();

            perso1.nome = "Batman";
            perso1.idade = 46;
            perso1.armadura = "Bat roupa seda";
            perso1.ia = "Alfred";


            Personagem perso2 = new Personagem();

            perso2.nome = "Wonder Woman";
            perso2.idade = 100;
            perso2.armadura = "Master Titanium";
            perso2.ia = "Amazon Prime";

            // Console.WriteLine($"{perso1.nome} Vs {perso2.nome}");

            // perso2.Defender(30);

            // Console.WriteLine($"Personagem {perso2.nome} recebeu um ataque sua vida restou = {perso2.ExibirVida()}");

            // perso2.Defender(30);

            // Console.WriteLine($"Personagem {perso2.nome} recebeu um ataque sua vida restou = {perso2.ExibirVida()}");

            string opcao, ataque, defesa;

            do
            {
                Console.WriteLine($"{perso1.nome} Vs {perso2.nome}");
                Console.WriteLine($"Selecione o Personagem");
                Console.WriteLine($" [1] - {perso1.nome}");
                Console.WriteLine($" [2] - {perso2.nome}");
                Console.WriteLine($" [0] - Desistir");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //Atacar personagem 2
                        Console.WriteLine("Selecione o ataque");
                        Console.WriteLine(" [1] - Soco Alto");
                        Console.WriteLine(" [2] - Chute Baixo");
                        ataque = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {perso2.nome} Qual sera sua defesa");
                        Console.WriteLine(" [1] - Defesa Alta");
                        Console.WriteLine(" [2] - Defesa Baixa");
                        defesa = Console.ReadLine();

                        if (ataque == defesa)
                        {
                            Console.WriteLine($"O {perso2.nome} defendeu");
                        }
                        else
                        {
                            Console.WriteLine($"O {perso2.nome} defendeu!");
                            perso2.Defender(25);
                            Console.WriteLine($"Vida Restante = {perso2.ExibirVida()}");
                        }

                        break;
                    case "2":
                        //Atacar personagem 2
                        Console.WriteLine("Selecione o ataque");
                        Console.WriteLine(" [1] - Soco Alto");
                        Console.WriteLine(" [2] - Chute Baixo");
                        ataque = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {perso1.nome} Qual sera sua defesa");
                        Console.WriteLine(" [1] - Defesa Alta");
                        Console.WriteLine(" [2] - Defesa Baixa");
                        defesa = Console.ReadLine();

                        if (ataque == defesa)
                        {
                            Console.WriteLine($"O {perso1.nome} defendeu!");
                        }
                        else
                        {
                            Console.WriteLine($"O {perso2.nome}Recebeu um dano de 25");
                            perso1.Defender(25);
                            Console.WriteLine($"Vida Restante = {perso1.ExibirVida()}");
                        }

                        break;
                    default:
                        Console.WriteLine($"Opção invalida");
                        break;
                }

            } while (opcao != "0");



        }
    }
}
