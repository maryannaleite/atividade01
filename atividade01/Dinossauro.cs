using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Dinossauro : IServivo
    {
        public void nascer() => Console.WriteLine("O dinossauro nasceu.");
        public void Comer() => Console.WriteLine("O dinossauro está comendo, nhanha.");
        public void Dormir() => Console.WriteLine("O dinossauro foi dormi, zzzzzzzzzzz.");
        public void Respirar() => Console.WriteLine("O dinossauro ainda está respirando, uhhhhn .");
        public void Morrer() => Console.WriteLine("O dinossauro morreu, bixinho dele, culpa daquele meteoro.");
    }
}
