﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal interface IVolante
    {
        public void Vola()
        {
            Console.WriteLine("Sto volando!");
        }
    }
}
