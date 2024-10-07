using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Passaro : IVoador, IServivo
    {
        public void Decolar() => Console.WriteLine("O pássaro decolou.");
        public void Planar() => Console.WriteLine("O pássaro está planando.");
        public void Pousar() => Console.WriteLine("O pássaro pousou.");
        public void Cair() => Console.WriteLine("O pássaro caiu.");

        public void nascer() => Console.WriteLine("O pássaro nasceu.");
        public void Comer() => Console.WriteLine("O pássaro está comendo.");
        public void Dormir() => Console.WriteLine("O pássaro está dormindo.");
        public void Respirar() => Console.WriteLine("O pássaro está respirando.");
        public void Morrer() => Console.WriteLine("O pássaro morreu.");
    }
}
