using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public class Trem : IMaquina
    {
        public void Ligar() => Console.WriteLine("O trem está ligado.");
        public void Desligar() => Console.WriteLine("O trem está desligado.");
        public void Abastecer() => Console.WriteLine("O trem está sendo abastecido.");
        public void Alerta() => Console.WriteLine("Alerta do trem acionado.");
    }
}
