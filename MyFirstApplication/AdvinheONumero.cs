using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    static class jogo1
    {
        public static void JogoAdvinheONumero()
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
                    continue;

                }
                else
                {
                    System.Console.WriteLine("Vamos lá!");
                    continue;
                }
            }
            again = false;
            return;

        }

    }
}
