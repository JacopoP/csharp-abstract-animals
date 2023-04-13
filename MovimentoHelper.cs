using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal static class MovimentoHelper
    {
        public static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }
        public static void FaiNuotare(INuotante animale)
        {
            animale.Nuota();
        }
    }
}
