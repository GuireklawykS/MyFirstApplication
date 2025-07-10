using System;
using System.ComponentModel.Design;
using System.Net;
using System.Reflection.Metadata;
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
                        human[] lista = { new human("Guilherme"), new human("Gabriel") }; // Lista de objetos

                        foreach (human humanos in lista)
                        {
                            Console.WriteLine(humanos.nome);
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
                        
                        aluno aluno1 = new aluno(true);

                        Console.WriteLine($"O aluno estuda? {aluno1.estuda}");
                        
                        Thread.Sleep(2000);
                        continue;

                    case "4":
                        carro carro1 = new carro("Chevrolet", "Camaro", 4);

                        carro1.velocidade = 200;

                        Console.WriteLine($"Velocidade = {carro1.velocidade}Km/h");
                        Console.WriteLine($"Quantidade de rodas = {carro1.rodas}");
                        Console.WriteLine($"Marca = {carro1.marca}");

                        Thread.Sleep(3000);
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

        