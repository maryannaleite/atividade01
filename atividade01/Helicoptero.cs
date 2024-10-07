using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Helicoptero : IPairador, IMaquina
    {
        public void Decolar() => Console.WriteLine("O helicóptero decolou.");
        public void Planar() => Console.WriteLine("O helicóptero está planando.");
        public void Pousar() => Console.WriteLine("O helicóptero pousou.");
        public void Cair() => Console.WriteLine("O helicóptero caiu.");
        public void Pairar() => Console.WriteLine("O helicóptero está pairando.");

        public void Ligar() => Console.WriteLine("O helicóptero está ligado.");
        public void Desligar() => Console.WriteLine("O helicóptero está desligado.");
        public void Abastecer() => Console.WriteLine("O helicóptero está sendo abastecido.");
        public void Alerta() => Console.WriteLine("Alerta do helicóptero acionado.");
    }
}
