using System;
using System.Net;
using System.Reflection.Metadata;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String escolha = "";

            while (escolha != "0")
            {
                Console.Clear();
                System.Console.WriteLine("Escolha o jogo:");
                System.Console.WriteLine("0 - Sair");
                System.Console.WriteLine("1 - Advinhe o número");
                System.Console.WriteLine("2 - Pedra, Papel e Tesoura");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "0":
                        System.Console.WriteLine("Adeus!");
                        return;

                    case "1":
                        AdvinheONumero();
                        return;

                    case "2":
                        PedraPapelTesoura();
                        return;

                    default:
                        System.Console.WriteLine();
                        return;
                }




            }
        }
        static void PedraPapelTesoura()
        {
            Random random = new Random();
            bool again = true;
            int player;
            int Computer;

            //double temperature = 20;
            //String message;

            //message = (temperature >= 20) ? "Está quente lá fora" : "Está frio lá fora";


            while (again)
            {
                Thread.Sleep(3000);
                Console.Clear();
                System.Console.WriteLine("Escolha:\n1 - Pedra\n2 - Papel\n3 - Tesoura");
                player = Convert.ToInt32(Console.ReadLine());
                Computer = random.Next(1, 4);

                Dictionary<int, String> armas = new Dictionary<int, string>();

                //String[] armas = { "Pedra", "Papel", "Tesoura" };
                /*String[] armas = new string[3];
                armas[0] = "Pedra";
                armas[1] = "Papel";
                armas[2] = "Tesoura";
                */
                armas.Add(1, "Pedra");
                armas.Add(2, "Papel");
                armas.Add(3, "Tesoura");

                String escolha;
                String escolhaC = armas[Computer];

                if (player == 1)
                {
                    escolha = "pedra";
                }
                else if (player == 2)
                {
                    escolha = "papel";
                }
                else
                {
                    escolha = "Tesoura";
                }

                if (player == Computer)
                {
                    System.Console.WriteLine("Os dois escolheram " + escolha);
                    System.Console.WriteLine("Empate!");
                }
                else if (player == 1 && Computer == 2 || player == 2 && Computer == 3 || player == 3 && Computer == 1)
                {
                    System.Console.WriteLine("Você perdeu!");
                    System.Console.WriteLine("Sua escolha: " + escolha + "\nEscolha do computador: " + escolhaC);

                }
                else
                {
                    System.Console.WriteLine("Você venceu!");
                    System.Console.WriteLine("Sua escolha: " + escolha + "\nEscolha do computador: " + escolhaC);

                }
                System.Console.WriteLine("Jogar de novo? S/N");
                String novo = Console.ReadLine();
                novo = novo.ToUpper();

                if (novo == "N")
                {
                    again = false;
                    return;
                }
            }



        }

        static void AdvinheONumero()
        {
            Random random = new Random();

            bool again = true;
            int number = random.Next(0, 101);


            while (again)
            {
                System.Console.WriteLine("Os números vão de 0 a 100");
                Thread.Sleep(3000);
                for (int i = 7; i > 0; i--)
                {
                    Console.Clear();
                    System.Console.WriteLine("Você tem " + i + " tentativas sobrando.");
                    System.Console.Write("Adivinhe o número: ");
                    int chute = Convert.ToInt32(Console.ReadLine());
                    if (chute == number)
                    {
                        System.Console.WriteLine("Correto!");
                        break;
                    }
                    else if (chute < number)
                    {
                        System.Console.WriteLine("O número é maior!");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        System.Console.WriteLine("O número é menor!");
                        Thread.Sleep(2000);
                    }
                }


                System.Console.WriteLine("Jogar novamente? S/N");
                String novo = Console.ReadLine();
                novo = novo.ToUpper();

                if (novo == "N")
                {
                    System.Console.WriteLine("Adeus!");
                    again = false;
                    return;

                }
                else
                {
                    System.Console.WriteLine("Vamos lá!");
                    AdvinheONumero();
                }
            }

        }
    }
}