using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class OVNI : IVoador, IMaquina
    {
        public void Decolar() => Console.WriteLine("O OVNI decolou.");
        public void Planar() => Console.WriteLine("O OVNI está planando.");
        public void Pousar() => Console.WriteLine("O OVNI pousou.");
        public void Cair() => Console.WriteLine("O OVNI caiu.");

        public void Ligar() => Console.WriteLine("O OVNI está ligado.");
        public void Desligar() => Console.WriteLine("O OVNI está desligado.");
        public void Abastecer() => Console.WriteLine("O OVNI está sendo abastecido.");
        public void Alerta() => Console.WriteLine("Alerta do OVNI acionado.");
    }
}
