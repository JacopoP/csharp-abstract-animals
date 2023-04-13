using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Delfino : Animale, INuotante
    {
        public override void Verso()
        {
            Console.WriteLine("Delfino!");
        }

        public override void Mangia()
        {
            Console.WriteLine("Il delfino mangia pesce");
        }
    }
}
