namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main()
        {
            List<Animale> animali = new List<Animale>
            {
                new Cane(),
                new Passerotto(),
                new Aquila(),
                new Delfino(),
            };
            foreach (Animale animale in animali)
            {
                animale.Verso();
                animale.Mangia();
                animale.Dormi();
            }
            Passerotto passerotto = new Passerotto();
            Aquila aquila = new Aquila();
            Delfino delfino = new Delfino();
            MovimentoHelper.FaiVolare(passerotto);
            MovimentoHelper.FaiVolare(aquila);
            MovimentoHelper.FaiNuotare(delfino);
        }
    }
}