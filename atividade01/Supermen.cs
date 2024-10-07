using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Superman : IVoador, IPairador, IServivo
    {
        public void Decolar() => Console.WriteLine("Superman começou a voar.");
        public void Planar() => Console.WriteLine("Superman está parado no ar.");
        public void Pousar() => Console.WriteLine("Superman pousou.");
        public void Cair() => Console.WriteLine("Superman caiu, pluft.");
        public void Pairar() => Console.WriteLine("Superman está pairando.");

        public void nascer() => Console.WriteLine("Superman nasceu.");
        public void Comer() => Console.WriteLine("Superman está comendo, nhanha.");
        public void Dormir() => Console.WriteLine("Superman está dormindo, zzzzz.");
        public void Respirar() => Console.WriteLine("Superman está respirando, uhmmm.");
        public void Morrer() => Console.WriteLine("Superman ele é imortal.");
    }
}
