using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Aviao : IVoador, IMaquina
    {
        public void Decolar() => Console.WriteLine("O avião decolou.");
        public void Planar() => Console.WriteLine("O avião está planando.");
        public void Pousar() => Console.WriteLine("O avião pousou.");
        public void Cair() => Console.WriteLine("O avião caiu.");
        public void Pairar() => Console.WriteLine("O avião está pairando.");

        public void Ligar() => Console.WriteLine("O avião está ligado.");
        public void Desligar() => Console.WriteLine("O avião está desligado.");
        public void Abastecer() => Console.WriteLine("O avião está sendo abastecido.");
        public void Alerta() => Console.WriteLine("Alerta do avião acionado.");
    }
}
