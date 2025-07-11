using System;
using System.ComponentModel.Design;
using System.Net;
using System.Reflection.Metadata;
using System.Collections.Generic;
using MyFirstApplication;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {Menu();}

        static void Menu()
        {
            String escolha = "";

            while (escolha != "0")
            {
                Console.Clear();
                Console.WriteLine("Escolha o jogo:");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Advinhe o número");
                Console.WriteLine("2 - Pedra, Papel e Tesoura");
                Console.WriteLine("3 - Humanos");
                Console.WriteLine("4 - Carros");
                escolha = Console.ReadLine();



                switch (escolha)
                {
                    case "0":
                        Console.WriteLine("Adeus!");
                        continue;

                    case "1":
                        jogo1.JogoAdvinheONumero();
                        continue;

                    case "2":
                        PedraPapelTesoura.JogoPedraPapelTesoura();
                        continue;

                    case "3":

                        Humano[] array = { new Humano("Guilherme"), new Humano("Gabriel") }; // Lista de objetos

                        foreach (Humano humano in array)
                        {
                            Console.WriteLine(humano.nome);
                        }

                        //human humano1 = new human("Guilherme", 20, 1.73, 60);
                        //human humano2 = new human("Gabriel", 30, 1.90, 80);
                        /*
                        humano1.Dormir();
                        humano2.Dormir();

                        humano1.Altura();
                        humano2.Altura();

                        humano1.Peso();
                        humano2.Peso();
                        */
                        //Console.WriteLine($"{humano1.nome}\n{humano2.nome}");
                        //Console.WriteLine(human.numero_de_humanos);

                        Aluno aluno1 = new Aluno(true);

                        Console.WriteLine($"O aluno estuda? {aluno1.estuda}");

                        Thread.Sleep(2000);
                        continue;

                    case "4":
                        Carro carro1 = new Carro("Chevrolet", "Camaro", 4);
                        Bicicleta bicicleta1 = new Bicicleta("Adidas", "GTS", 2);

                        Veiculo[] veiculos = { carro1, bicicleta1 };

                        Console.WriteLine(carro1);

                        //foreach (Veiculo veiculo in veiculos)
                        //{
                        //    Console.WriteLine(veiculo);
                        //}

                        carro1.Velocidade = 2000;
                        carro1.VelocidadeV();
                        /*
                        Console.WriteLine($"{carro1}");
                        Console.WriteLine($"Quantidade de rodas = {carro1.rodas}");
                        Console.WriteLine($"Marca = {carro1.marca}");
                        */
                        Thread.Sleep(3000);
                        continue;

                    case "5":
                        Raposa raposa = new Raposa();
                        raposa.Cacando();
                        Thread.Sleep(3000);

                        continue;

                    case "6":
                        List<Humano> humanos = new List<Humano>();

                        Humano humano3 = new Humano("Fabricio", 24);
                        Humano humano4 = new Humano("Felipe");

                        humanos.Add(humano3);
                        humanos.Add(humano4);
                        humanos.Add(new Humano("Guilherme", 20));

                        foreach (Humano humano in humanos)
                        {
                            Console.Write("Nome: " + humano);
                            Console.Write(" Idade:");
                            if (humano.idade == 0)
                            {
                                Console.WriteLine("Idade não inserida.");
                            }
                            else
                            {
                                Console.WriteLine(humano.idade);
                            }
                        }



                        /*
                        List<String> comidas = new List<String>();
                        
                        comidas.Add("Pizza");
                        comidas.Add("Sushi");
                        //comidas.Remove("Pizza");
                        comidas.Insert(0, "Hamburguer");
                        Console.WriteLine(comidas.Count);
                        Console.WriteLine(comidas.IndexOf("Pizza"));
                        Console.WriteLine(comidas.LastIndexOf("Pizza"));
                        Console.WriteLine(comidas.Contains("Pizza"));
                        
                        //comidas.Clear();
                        //comidas.Sort();
                        //comidas.Reverse();




                        foreach (String comida in comidas)
                        {
                            Console.WriteLine(comida);
                        }*/



                        Thread.Sleep(2000);
                        continue;

                    case "7":

                        String nome_planeta = Planetas.Terra.ToString();
                        int raio_planeta = (int)RaioPlanetas.Terra;

                        Console.WriteLine($"Posição do Planeta: {(int)Planetas.Terra}");
                        Console.WriteLine($"Planeta: {nome_planeta}");
                        Console.WriteLine($"Raio do Planeta: {raio_planeta}");

                        Thread.Sleep(2000);
                        continue;

                    case "8":

                        String[] palavras = { "Cabeça", "Ombro", "Joelho" };
                        int[] palavras2 = { 1, 2, 3 };
                        double[] palavras3 = { 4.1, 3.2, 2.7 };

                        Display.DisplayElements(palavras);
                        Display.DisplayElements(palavras2);
                        Display.DisplayElements(palavras3);

                        Thread.Sleep(2000);
                        continue;
                    default:
                        Console.WriteLine("Opção inválida");
                        Thread.Sleep(2000);
                        continue;
                }
            }
        }
    }
}

        