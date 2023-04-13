using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Aquila : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Aquila!");
        }

        public override void Mangia()
        {
            Console.WriteLine("L'aquila mangia roditori");
        }
    }
}
