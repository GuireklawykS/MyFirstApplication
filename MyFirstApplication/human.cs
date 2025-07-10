using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    public class Humano
    {
        public String nome;
        public int idade;
        public double altura;
        public double peso;
        public static int numero_de_humanos; //Static permite que o valor seja imutável, ou seja, se transformarmos
                                             //       a classe em static ela não podera gerar objetos.

        public Humano()
        {
            numero_de_humanos++;
        }

        public Humano(string nome)
        {
            this.nome = nome;
            numero_de_humanos++;
        }
        public Humano(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            numero_de_humanos++;
        }
        public Humano(string nome, int idade, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            numero_de_humanos++;
        }
        public Humano(string nome, int idade, double altura, double peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
            numero_de_humanos++;
        }

        public override string ToString()
        {
            return nome;
        }
        
        public void Comer()
        {
            Console.WriteLine($"O/A {nome} está comendo");
        }
        public void Dormir()
        {
            Console.WriteLine($"O/A {nome} está dormindo");
        }

        public void Altura()
        {
            Console.WriteLine($"A altura de {nome} é {altura}");
        }

        public void Peso()
        {
            Console.WriteLine($"O peso de {nome} é {peso}");
        }
    }
    public class Aluno : Humano
    {
        public bool estuda = true;

        public Aluno(bool estuda)
        {
            this.estuda = estuda;
        }
    }
}
