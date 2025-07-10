using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    abstract class veiculo // Abstract = Significa que a classe está incompleta e não pode ser chamada.
    {
        public int velocidade = 0;

        public void VelocidadeV()
        {
            Console.WriteLine($"Velocidade do veiculo = {velocidade}");

        }
    }

    class Carro : Veiculo
    {
        public String marca;
        public String modelo;
        public int rodas = 4;

        public carro(String marca, String modelo, int rodas) {
            this.marca = marca;
            this.modelo = modelo;
            this.rodas = rodas;

            }
    }

    class bicicleta : veiculo
    {
        public String marca;
        public String modelo;
        public int rodas = 2;
    }
}
