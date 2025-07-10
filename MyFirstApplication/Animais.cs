using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    internal class Animais
    {
        public string nomeCientifico;
        public string sexo;

        public Animais()
        {

        }

        public Animais(string nomeCientifico)
        {
            this.nomeCientifico = nomeCientifico;
        
        }
        public Animais(string nomeCientifico, string sexo)
        {
            this.nomeCientifico = nomeCientifico;
            this.sexo = sexo;
        }

    }
    interface Predador
    {
        void Cacando();
    }

    interface Presa
    {
        void Fugindo();
    }

    class Raposa : Animais, Predador, Presa
    {
        public void Cacando() {
            Console.WriteLine("A raposa está caçando!");
        }
        public void Fugindo() {
            Console.WriteLine("A raposa está fugindo!");
        }

    }
}
