﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade01
{
    public interface IVoador
    {
        void Decolar();
        void Planar();
        void Pousar();
        void Cair();
    }
}