using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Piterodaptero : IServivo, IPairador
    {
        public void Decolar() => Console.WriteLine("O piterodaptero decolou.");
        public void Pairar() => Console.WriteLine(" O piterodaptero está pairando");
        public void Planar() => Console.WriteLine("O piterodaptero está planando.");
        public void Pousar() => Console.WriteLine("O piterodaptero pousou.");
        public void Cair() => Console.WriteLine("O piterodaptero caiu.");

        public void nascer() => Console.WriteLine("O piterodaptero nasceu.");
        public void Comer() => Console.WriteLine("O piterodaptero está comendo.");
        public void Dormir() => Console.WriteLine("O piterodaptero está dormindo.");
        public void Respirar() => Console.WriteLine("O piterodaptero está respirando.");
        public void Morrer() => Console.WriteLine("O piterodaptero morreu.");
    }
}
