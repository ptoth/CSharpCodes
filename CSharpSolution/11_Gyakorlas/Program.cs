namespace _11_Gyakorlas
{
    internal class Program
    {
        struct rgb
        {
            public int Red;
            public int Green;
            public int Blue;
        }
        static void Main(string[] args)
        {

            rgb[,] kep = new rgb[360, 640];
            string[] beolvasottFajl = File.ReadAllLines("kep.txt");
            List<rgb> adatok = new List<rgb>();

            for (int sor = 0; sor < beolvasottFajl.Length; sor++)
            {
                rgb seged = new rgb();
                //Ez a fájl egy sora
                string[] darabol = beolvasottFajl[sor].Split(' ');
                //egy sor
                for (int oszlop = 0; oszlop < darabol.Length / 3; oszlop++)
                {

                    //3 szám beolvasása az rgb structba
                    for (int j = 0; j < 3; j++)
                    {
                        seged.Red = int.Parse(darabol[0]);
                        seged.Green = int.Parse(darabol[1]);
                        seged.Blue = int.Parse(darabol[2]);
                        adatok.Add(seged);
                    }
                    //Console.WriteLine(sor+""+oszlop);
                    kep[sor, oszlop] = seged;
                }
            }

            /*
            foreach (rgb elem in adatok) 
            {
                Console.Write(elem.Red+" "+elem.Green+" "+elem.Blue+"|");
            }
            */

            /*
            Console.WriteLine("Kérem adjon meg egy sor és oszlopszámot!");
            int megadottAdat = int.Parse(Console.ReadLine());
            */
            Console.WriteLine("Adja meg az sorszámot");
            int sorszam = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg az oszlopszámot");
            int oszlopszam = int.Parse(Console.ReadLine());

            Console.WriteLine($"2. feladat : Az adott képpont színe: RGB: {kep[sorszam, oszlopszam].Red} {kep[sorszam, oszlopszam].Green} {kep[sorszam, oszlopszam].Blue}");

            int vilagosKepdb = 0;
            for (int sor = 0; sor < kep.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < kep.GetLength(1); oszlop++)
                {
                    if (kep[sor, oszlop].Red + kep[sor, oszlop].Green + kep[sor, oszlop].Blue > 600)
                    {
                        vilagosKepdb++;
                    }
                }

            }
            Console.WriteLine($"3. feladat ,Világos képpontok száma: {vilagosKepdb} ");
            Console.ReadLine();

            int sotetKeppont = 255 + 255 + 255;
            int koordinataX = 0;
            int koordinataY = 0;
            for (int sor = 0; sor < kep.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < kep.GetLength(1); oszlop++)
                {
                    if (kep[sor, oszlop].Red + kep[sor, oszlop].Green + kep[sor, oszlop].Blue < sotetKeppont)
                    {
                        sotetKeppont = kep[sor, oszlop].Red + kep[sor, oszlop].Green + kep[sor, oszlop].Blue;
                        koordinataX = sor;
                        koordinataY = oszlop;

                    }
                }

            }
            Console.WriteLine($"4. feladat ,Világos képpontok száma: {sotetKeppont} és koordinátái: {koordinataX},{koordinataY}");
            Console.ReadLine();
        }
    }
}