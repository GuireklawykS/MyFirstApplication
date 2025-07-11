using MyFirstApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    abstract class Veiculo // Abstract = Significa que a classe está incompleta e não pode ser chamada.
    {
        private int velocidade = 0; // Private torna a váriavel acessível apenas com Get e Set


        public virtual void VelocidadeV() // virtual = torna o método sobreescrevivel.
        {
            Console.WriteLine($"Velocidade do veiculo = {Velocidade}");
        }

        

        public int Velocidade { 
            get { return velocidade; } 
        
            set { 
                if (value > 500)
                {
                    velocidade = 500;
                }
                else
                {
                    velocidade = value;
                }
            }
        }


    }

    class Carro : Veiculo
    {
        public String marca;
        public String modelo;
        public int rodas = 4;


        public String Marca {  get; set; }

        public override void VelocidadeV() // override = sobreescreve um método da classe pai.
        {
            Console.WriteLine($"Velocidade do carro = {Velocidade}");

        }
        public Carro(String Marca, String modelo, int rodas) {
            Marca = Marca;
            this.modelo = modelo;
            this.rodas = rodas;

            }
        public override string ToString() // Método com definição string pq o return é um string.
        {
            return $"Modelo = {modelo}\nMarca = {Marca}";
        }

    }
}

    class Bicicleta : Veiculo
    {
        public String marca;
        public String modelo;
        public int rodas = 2;

        public Bicicleta(string marca, string modelo, int rodas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.rodas = rodas;
        }
        public override string ToString()
        {
            return $"Marca: {marca}\nModelo: {modelo}";
        }
    }
