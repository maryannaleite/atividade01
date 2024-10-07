using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Cachorro : IServivo
    {
        public void nascer() => Console.WriteLine("O cachorro nasceu.");
        public void Comer() => Console.WriteLine("O cachorro está comendo, nhanha.");
        public void Dormir() => Console.WriteLine("O cachorro está dormindo, zzzzzzzzz.");
        public void Respirar() => Console.WriteLine("O cachorro está respirando, uhnnn.");
        public void Morrer() => Console.WriteLine("O cachorro morreu, tadimho dele.");
    }
}
