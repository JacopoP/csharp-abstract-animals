﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Cane : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Bau!");
        }

        public override void Mangia() 
        {
            Console.WriteLine("Il cane mangia carne");
        }
    }
}
