using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Zumbi : IServivo
    {
        public void nascer() => Console.WriteLine("Zumbi nasceu quano ainda eera humano.");
        public void Comer() => Console.WriteLine("Zumbi está comendo celebros.");
        public void Dormir() => Console.WriteLine("Zumbi não dorme.");
        public void Respirar() => Console.WriteLine("Zumbi não respira.");
        public void Morrer() => Console.WriteLine("Zumbi morreu.");
    }
}
