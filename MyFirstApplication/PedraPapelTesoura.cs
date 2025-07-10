using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    static class PedraPapelTesoura
    {
        public static void JogoPedraPapelTesoura()
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
    }
}
