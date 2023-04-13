namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main()
        {
            List<Animale> animals = new List<Animale>
            {
                new Cane(),
                new Passerotto(),
                new Aquila(),
                new Delfino(),
            };
            foreach (Animale animale in animals)
            {
                animale.Verso();
                animale.Mangia();
                animale.Dormi();
            }
        }
    }
}