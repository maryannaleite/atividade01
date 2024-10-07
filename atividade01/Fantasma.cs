using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Fantasma : IPairador
    {
        public void Decolar() => Console.WriteLine("O fantasma começou a voar.");
        public void Planar() => Console.WriteLine("O fantasma está parado no ar nos observando.");
        public void Pousar() => Console.WriteLine("O fantasma voltou para o chão.");
        public void Cair() => Console.WriteLine("O fantasma caiu, HAHAHA.");
        public void Pairar() => Console.WriteLine("O fantasma está parado no ar, chega deu um medo vey.");
    }
}
