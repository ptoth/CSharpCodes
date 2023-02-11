using System.Diagnostics.Contracts;

namespace _06_OOP
{
    internal class Program
    {
        public class Kutya
        {
            // tulajdonságok
            // legyen public, hogy más objektumok is lássák
            public string nev;
            public string szin;
            public string fajta;
            public bool neme; // false = lany, true = fiu
            public int kor;

            public string ugatas;

            public Kutya()
            {

            }

            public Kutya(string aKutyaNeve, string aKutyaSzine, string aKutyaFajtaja, bool aKutyaNeme, int aKutyaKora, string aKutyaEgyediUgatasa)
            {
                this.nev = aKutyaNeve;
                this.szin = aKutyaSzine;
                this.fajta = aKutyaFajtaja;
                this.neme = aKutyaNeme;
                this.kor = aKutyaKora;
                this.ugatas = aKutyaEgyediUgatasa;
            }

            // metodusok
            // public itt is fontos
            public string standardUgatas()
            {
                return "Vau-vau";
            }

            public string egyediUgatas()
            {
                return this.ugatas;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Kutya gyuriKutyaja = new Kutya();
            gyuriKutyaja.nev = "Bodri";
            gyuriKutyaja.szin = "tarka";

            // standard ugatas, mindig vau-vau
            Console.WriteLine(gyuriKutyaja.standardUgatas());

            // egyedi ugatás, én adom meg
            // tartalma tetszőleges, megléte kötelező
            Console.WriteLine(gyuriKutyaja.egyediUgatas());
            Console.WriteLine(gyuriKutyaja.egyediUgatas());

            // példa: objektum létrehozása "buta" kontruktorral
            Kutya kedvencKutya = new Kutya();
            kedvencKutya.nev = "Lassie";
            kedvencKutya.fajta = "Skót juhász";
            kedvencKutya.szin = "barna";
            kedvencKutya.kor = 5;
            kedvencKutya.neme = true;

            // példa: objektum létrehozása konstruktorral
            Kutya okosKutya = new Kutya("Pluto", "fekete", "terrier", true, 10, "Wuf-wuf");

            Console.WriteLine(kedvencKutya.nev);
            Console.WriteLine(okosKutya.nev);

            Console.ReadLine();


            //-----------------------------------------------------------------------
            Kutya[] kutyaim = new Kutya[5];

            kutyaim[0] = new Kutya("Pluto0", "fekete", "terrier", true, 10, "Vau1");
            kutyaim[1] = new Kutya("Pluto1", "fehér", "terrier", true, 10, "Vau2");
            kutyaim[2] = new Kutya("Pluto2", "tarka", "terrier", true, 10, "VauVau");
            kutyaim[3] = new Kutya("Pluto3", "barna", "terrier", true, 10, "Vau1Vau1");
            kutyaim[4] = new Kutya("Pluto4", "zöld", "terrier", true, 10, "Vau2Vau2");

            foreach (Kutya aktualisKutya in kutyaim)
            {
                Console.WriteLine(aktualisKutya.nev);
            }

            foreach (Kutya eb in kutyaim)
            {
                Console.WriteLine(eb.standardUgatas());
                Console.WriteLine(eb.egyediUgatas());
            }
        }
    }
}