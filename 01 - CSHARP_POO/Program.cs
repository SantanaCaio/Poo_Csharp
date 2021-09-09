using System;
using System.Threading;

namespace CSHARP_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem perso1 = new Personagem();
            perso1.nome = "Batman";
            perso1.idade = 46;
            perso1.armadura = "Bat Roupa seda";
            perso1.iA = "Alfred";
            perso1.soco = 25;
            perso1.chute = 30;

            Personagem perso2 = new Personagem();
            perso2.nome = "Wonder Woman";
            perso2.idade = 100;
            perso2.armadura = "Master Tinium";
            perso2.iA = "Amazon Prime";
            perso2.soco = 30;
            perso2.chute = 25;



            Console.WriteLine($"{perso1.nome} Vs {perso2.nome}");

            string opcao, ataque, defesa;
            do
            {

                Console.WriteLine("Selecione qual personagem você quer jogar:");
                Console.WriteLine($"1 - {perso1.nome} vida = {perso1.ExibirVida()}");
                Console.WriteLine($"2 - {perso2.nome} vida = {perso2.ExibirVida()}");
                Console.WriteLine($"0 - Desistir");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        //Atacar personagem 2
                        Console.WriteLine("Selecione o ataque");
                        Console.WriteLine("1 - Soco Alto");
                        Console.WriteLine("2 - Chute Baixo");
                        ataque = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {perso2.nome} qual será sua defesa?");
                        Console.WriteLine($"1 - Defesa de soco");
                        Console.WriteLine($"2 - Defesa de chute");
                        defesa = Console.ReadLine();
                        if (ataque == defesa)
                        {
                            Console.WriteLine($"O {perso2.nome} defendeu!");
                        }
                        else
                        {
                            if (ataque == "1")
                            {
                                Console.WriteLine($"O {perso2.nome} recebeu um dado de {perso1.nome}");
                                perso2.Receber(perso1.soco);
                            }
                            else
                            {
                                Console.WriteLine($"O {perso2.nome} recebeu um dano de 25");
                                perso2.Receber(perso1.soco);
                            }
                            Console.WriteLine($"Vida restante = {perso2.ExibirVida()}");
                            if (perso1.ExibirVida() > 0)
                            {
                                Console.WriteLine($"Vida restante = {perso1.ExibirVida()}");
                            }
                            else
                            {
                                Console.WriteLine($"KO!!!!");
                            }

                            Thread.Sleep(3000);
                        }
                        break;
                    case "2":
                        //Atacar personagem 1
                        Console.WriteLine("Selecione o ataque");
                        Console.WriteLine("1 - Soco Alto");
                        Console.WriteLine("2 - Chute Baixo");
                        ataque = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Personagem {perso1.nome} qual será sua defesa?");
                        Console.WriteLine($"1 - Defesa de soco");
                        Console.WriteLine($"2 - Defesa de chute");
                        defesa = Console.ReadLine();
                        if (ataque == defesa)
                        {
                            Console.WriteLine($"O {perso1.nome} defendeu!");
                        }
                        else
                        {
                            if (ataque == "1")
                            {
                                Console.WriteLine($"O {perso1.nome} recebeu um dado de {perso2.nome}");
                                perso1.Receber(perso2.soco);
                            }
                            else
                            {
                                Console.WriteLine($"O {perso1.nome} recebeu um dano de 25");
                                perso2.Receber(perso2.soco);
                            }

                            if (perso2.ExibirVida() > 0)
                            {
                                Console.WriteLine($"Vida restante = {perso2.ExibirVida()}");
                            }
                            else
                            {
                                Console.WriteLine($"KO!!!!");
                            }
                            Thread.Sleep(3000);
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }//fim while

                if (perso1.ExibirVida() <= 0)
                {
                    Console.WriteLine($"Vitória do jogador {perso2.nome}");
                    break;
                }
                else if (perso2.ExibirVida() <= 0)
                {
                    Console.WriteLine($"Vitória do jogador {perso1.nome}");
                    break;
                }
                else
                {
                    Console.WriteLine("Preparece para o proximo ROUND");
                    Thread.Sleep(2000);
                }

            } while (opcao != "0");

        }//fim Main
    }
}
