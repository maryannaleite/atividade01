using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Beijaflor : IServivo, IPairador
    {
        public void Decolar() => Console.WriteLine("O beija-for decolou.");
        public void Pairar() => Console.WriteLine(" O beija-flor está pairando");
        public void Planar() => Console.WriteLine("O beija-flor está planando.");
        public void Pousar() => Console.WriteLine("O beija-flor pousou.");
        public void Cair() => Console.WriteLine("O beija-flor caiu.");

        public void nascer() => Console.WriteLine("O beija-flor nasceu.");
        public void Comer() => Console.WriteLine("O beija-flor está comendo.");
        public void Dormir() => Console.WriteLine("O beija-flor está dormindo.");
        public void Respirar() => Console.WriteLine("O beija-flor está respirando.");
        public void Morrer() => Console.WriteLine("O beija-flor morreu.");
    }
}
