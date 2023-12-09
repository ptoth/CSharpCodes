using System.Collections;

namespace _10_Gyakorlas
{
    public class Auto
    {
        public string Marka;
        public string Tipus;
        public string Szin;
        public bool hasznaltE;
        private int loEro;

        public int LoEro { get => loEro; set => loEro = value; }
    }


    internal class Program
    {
        struct Tanulo
        {
            public int tanuloAzonosito;
            public String tanuloNev;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("START");

            Dictionary<int, string> SzamokSzoveggel = new Dictionary<int, string>();
            SzamokSzoveggel.Add(1, "Egy");
            SzamokSzoveggel.Add(2, "Kettő");
            SzamokSzoveggel.Add(3, "Három");

            foreach (KeyValuePair<int, string> elem in SzamokSzoveggel)
            {
                Console.WriteLine(elem.Key + " " + elem.Value);
            }

            SzamokSzoveggel.Remove(1);
            Console.WriteLine("\n");

            //----------------------------------------------------------------------------------------------------------------------------------
            Tanulo[] osztaly = new Tanulo[3];

            string[] input = new string[1] { "Kovacs Géza;19890101" };
            for (int i = 0; i < input.Length; i++)
            {
                string[] temp = input[i].Split(";");
                Tanulo tempTanulo;
                tempTanulo.tanuloNev = temp[0];
                tempTanulo.tanuloAzonosito = int.Parse(temp[1]);
            }

            Tanulo kovacsGeza;
            kovacsGeza.tanuloAzonosito = 19890101;
            kovacsGeza.tanuloNev = "Kovacs Géza";

            Tanulo kovacsAbel;
            kovacsAbel.tanuloAzonosito = 19890102;
            kovacsAbel.tanuloNev = "Kovacs Ábel";

            Tanulo kovacsBela;
            kovacsBela.tanuloAzonosito = 19890103;
            kovacsBela.tanuloNev = "Kovacs Béla";

            foreach (Tanulo elem in osztaly)
            {
                Console.WriteLine(elem.tanuloNev + " " + elem.tanuloAzonosito);
            }

            //----------------------------------------------------------------------------------------------------------------------------------

            Auto GyuriAutoja = new Auto();
            GyuriAutoja.Marka = "Toyota";
            GyuriAutoja.Tipus = "Corolla";
            GyuriAutoja.Szin = "Szürke";

            Auto BelaAutoja = new Auto();
            BelaAutoja.Marka = "Volkswagen";
            BelaAutoja.Tipus = "Transporter";

            Auto GezaAutoja = new Auto();
            GezaAutoja.hasznaltE = true;

            Console.WriteLine("Gyuri autója egy: " + GyuriAutoja.Marka + " " + GyuriAutoja.Tipus);
            
            if ( GezaAutoja.hasznaltE)
            {
                Console.WriteLine("Géza autója használt?: Igen");
            } else
            {
                Console.WriteLine("Géza autója használt?: Nem");
            }

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}