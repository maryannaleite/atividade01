using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Gato : IServivo
    {
        public void nascer() => Console.WriteLine("O gato nasceu.");
        public void Comer() => Console.WriteLine("O gato está comendo, nhanha.");
        public void Dormir() => Console.WriteLine("O gato está dormindo, zzzz.");
        public void Respirar() => Console.WriteLine("O gato está respirando, uhmmm.");
        public void Morrer() => Console.WriteLine("O gato morreu, tadinho dele.");
    }
}
