namespace PreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person gigi = new Person();
            Animale Cane = new Animale();
            
            gigi.Visualizza();
            Cane.Visualizza();

        }
    }

    class Person
    {
        public string Name = "Gigi";
        public string Cognome = "Proietti";
        public int Eta = 50;
   
    public void Visualizza()
    {
        Console.WriteLine($"Ciao sono {Name}, {Cognome} ho {Eta}");
    }
 }
    class Animale
    {
        public string AniNome = "Lea";
        public string AniRazza = "Siberian Husky";
        public int AniEta = 9;
        public string AniCaratteristica = "Distruttore di Mondi";
            
            public void Visualizza()
        {
            Console.WriteLine($"il nome é: {AniNome} é un {AniRazza} di {AniEta} anni la sua caratteristica principale? {AniCaratteristica} ");
        }

    }
}
