using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public interface IMaquina
    {
        void Ligar();
        void Desligar();
        void Abastecer();
        void Alerta();
    }
}
