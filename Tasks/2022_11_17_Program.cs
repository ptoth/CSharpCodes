using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022._11._17
{
    class Program
    {
        

        // 2022 12 06 feladat (3 feladat file beolvasásához kell)
        struct Enekes
        {
            public string nev;
            public string orszag;
        }

        // 2022 12 07 feladat (4 feladat az évek külön tárolásához kell)
        struct Diak
        {
            public string nev;
            public int ev;
            public int honap;
            public int nap;
        }
        static List<int> max_sorozat(List<int> sorozat)
        {
            // 1, 6, 4, 2, 1, 2, 5, 6, 2, 3, 4, 5, 1, 1,, 1, 2, 3, 4, 4, 1
            // sor=1
            //db=1
            // maxsor = 1,2,5,6
            // maxdb=4

            List<int> maxsorozat = new List<int>();
            int maxdb = 0;
            int db = 0;
            List<int> sor = new List<int>();
            sor.Add(sorozat[0]);
            db = 1;
            for (int i = 1; i < 20; i++)
            {
                if (sorozat[i] > sorozat[i - 1])
                {
                    db++;
                    sor.Add(sorozat[i]);
                }
                else
                {
                    if (db > maxdb)
                    {
                        maxdb = db;
                        maxsorozat = sor;
                    }
                }
                db = 1;
                sor.Clear();
                sor.Add(sorozat[i]);
            }
            return maxsorozat;
        }


        static int maxfejhossz(List<string> sorozat, string mit)
        {
            // fej, fej, írás, írás, fej, írás, fej, fej, fej, fej, írás
            //fej, fej, fej, fej, fej......
            //írás, írás, írás
            int max = 0; int db = 0;
            foreach (string elem in sorozat)
            {
                if (elem == mit) db++;
                else
                {
                    if (db > max) max = db;
                    db = 0;
                }
            }
            if (db > max) max = db;
            return max;

        }

        static bool prim_e(int szam)
        {
            bool pr = false;
            int oszto = 0;
            int k = 1;

            while (k <= szam)
            {
                if (szam % k == 0) oszto++;
                k++;
            }
            if (oszto < 3) pr = true;
            return pr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Feladat");
            Console.Write("Adjon meg egy számot: ");
            int valtozo = int.Parse(Console.ReadLine());
            if (valtozo > 0)
            {
                int s = 1;
                int sum = 100;

                while (s <= valtozo)
                {
                    sum = sum - s; // sum -= s
                    s = s + 1; // s++
                }
                Console.WriteLine(sum);

            }

            else
            {
                Console.WriteLine("Hibás");
            }
            Console.WriteLine();


            //2. Feladat
            Console.WriteLine("2. Feladat");
            Console.Write("Kérek egy nem nulla egész számot: ");
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            int p = 1;
            while (n != 0)
            {
                int c = n % 10;
                if (c < 9)
                {
                    c++;
                }
                nr += c * p;
                p *= 10;
                n = n / 10;
            }
            n = nr;
            Console.WriteLine($"{n}\n");


            // 3. Feladat
            Console.WriteLine("3. Feladat");
            Console.Write("Kérem x értékét: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Kérem y értékét: ");
            int y = int.Parse(Console.ReadLine());

            int z = 1;
            int w = 0;

            while (x >= z)
            {
                if (x % z == y)
                {
                    w = z;
                }
                z++;
            }
            Console.WriteLine($"{w}\n");



            // Pythonos Feladatok
            Console.WriteLine("\n\nPythonos Feladatok\n");
    //1) Generáljon egy 30 hosszú fej-írás sorozatot!
            Console.WriteLine("1. Feladat");

            //a) Tárolja el egy megfelelő változóban vagy adatszerkezetben!
            Random fejiras = new Random();
            List<string> dobas = new List<string>();

            for (int i = 0; i < 30; i++)
            {
                if (fejiras.Next(0, 2) == 0)
                {
                    dobas.Add("Fej");
                }
                else
                {
                    dobas.Add("Írás");
                }
            }

            //b) Adja meg, hogy hány fej van!

            int fdb = 0;
            for (int i = 0; i < 30; i++)
            {
                if (fejiras.Next(0, 2) == 0) dobas.Add("fej");
                else dobas.Add("Írás");
                if (dobas[i] == "fej") fdb++;
            }

            //c) Adja meg, hányadik dobás volt először írás!

            int j = 0;
            while (j < 30 && dobas[j] != "Írás") j++;
            if (j < 30) Console.WriteLine($"Az első írás a {j}. dobás volt.");
            else Console.WriteLine("Csak fej dobás volt");

            //d) Adja meg, hányadik dobás volt utoljára fej!

            int k = 29;
            while (k > -1 && dobas[k] != "fej") k--;
            if (k > -1) Console.WriteLine($"Az utolsó fej a {k}. helyen volt");
            else Console.WriteLine("Nincs fej dobás.");

            //e) Adja meg, hogy a dobások hány százaléka írás! Az eredményt kerekítse 2 tizedesre!

            double szazalek = Convert.ToDouble((30.0 - fdb) / 30.0) * 100;
            Console.WriteLine($"A dobások {Math.Round(szazalek, 2)}% volt írás.");

            //f) Függvénnyel határozza meg a leghosszabb fejsorozatot!

            int maxfej = maxfejhossz(dobas, "fej");
            Console.WriteLine($"A leghosszabb fej sorozat: {maxfej} hosszú");


    //2) Generáljon egy 20 hosszú kockadobás sorozatot!
            Console.WriteLine("\n2. Feladat");

            Random dob = new Random();
            int[] dobasok = new int[20];
            int ossz = 0; int prtl = 0; int prim = 0;
            for (int i = 0; i < 20; i++)
            {
                dobasok[i] = dob.Next(1, 7);
                ossz += dobasok[i];
                if (dobasok[i] % 2 != 0) prtl++;
                if (prim_e(dobasok[i])) prim++;
            }
            Console.WriteLine($"A prím számok összege: {prim}");

            //a) Tárolja el egy megfelelő változóban vagy adatszerkezetben!

            Random kocka = new Random();
            List<int> kockadobas = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                kockadobas.Add(kocka.Next(1, 7));
            }

            //b) Adja meg a dobott számok összegét!

            int osszeg = 0;
            for (int i = 0; i < kockadobas.Count; i++)
            {
                osszeg += kockadobas[i];
            }
            Console.WriteLine($"A dobott számok összege: {osszeg}");


            //c) Adja meg, hogy hány páratlan van!

            int paratlan = 0;
            for (int i = 0; i < kockadobas.Count; i++)
            {
                if (kockadobas[i] % 2 == 1)
                {
                    paratlan++;
                }
            }
            Console.WriteLine($"{paratlan} darab páratlan szám van.");


            //d) Adja meg, hogy hány prím van!

            int primek = 0;
            for (int i = 0; i < 20; i++)
            {
                if (kockadobas[i] >= 2)
                {
                    int osztok = 0;
                    for (int a = 2; a <= kockadobas[i] / 2; a++)
                    {
                        if (kockadobas[i] % a == 0)
                        {
                            osztok++;
                        }
                    }

                    if (osztok == 0)
                    {
                        primek++;
                    }
                }
            }
            Console.WriteLine($"A prím számok darabszáma: {primek}");


            //e) Dobott-e 4-est?

            if (kockadobas.Contains(4))
            {
                Console.WriteLine("Igen dobott 4 est.");
            }
            else
            {
                Console.WriteLine("Nem dobott 4 est.");
            }


            //f) Függvénnyel határozza meg a leghosszabb monoton növekvő sorozatot!

            int hossz = 0;
            int maxhossz = 0;
            for (int i = 1; i < 20; i++)
            {
                if (kockadobas[i - 1] < kockadobas[i])
                {
                    hossz++;
                }
                else
                {
                    if (maxhossz < hossz) maxhossz = hossz;
                    hossz = 0;
                }
            }
            Console.WriteLine($"{maxhossz}\n");

    //3) Olvasson be egy fájlból énekeseket a nevükkel, nemzetiségükkel!
            
            Console.WriteLine("3. Feladat");

                // fájból memóriába, egy string tipusú tömbbe.    
             string[] fajlbol = File.ReadAllLines("enekesek.txt");

            // adatok tárolása strng típusú listát tartalmazó listában
            List<List<string>> adatok = new List<List<string>>();
            foreach(string elem in fajlbol)
            {
                string[] darabol = elem.Split(';'); // adatok = ((Ariana Grande, amerikai), (Migosm mexikoi))
                List<string> mit = new List<string>(); // adatok [1][0]=> Migos
                mit.Add(darabol[0]);
                mit.Add(darabol[1]);
                adatok.Add(mit);
            }

            // adatok tárolása string típusú tömbbe
            string[,] adatok_t = new string[fajlbol.Length, 2];
            for(int i=0; i<fajlbol.Length; i++)
            {
                string[] darabol = fajlbol[i].Split(';');
                adatok_t[i, 0] = darabol[0];
                adatok_t[i, 1] = darabol[1];
            }

            // adatok tárolása struktúra típusú tömbben vagy listában
            Enekes[] adatok_s = new Enekes[fajlbol.Length];
            List<Enekes> adatok_sl = new List<Enekes>();
            for(int i=0; i<fajlbol.Length; i++)
            {
                string[] darabol = fajlbol[i].Split(';');
                Enekes szem = new Enekes();
                szem.nev = darabol[0];
                szem.orszag = darabol[1];

                adatok_s[i] = szem;
                adatok_sl.Add(szem);
            }



            //a)	Adja meg, hány olasz van közöttük!


            int db1=0, db2=0, db3=0, db4= 0;
            for(int i=0; i<fajlbol.Length; i++)
            {
                if (adatok_s[i].orszag == "olasz") db1++;    // énekes tipusú tömb
                if (adatok_sl[i].orszag == "olasz") db2++;   // énekes tipusú lista
                if (adatok[i][1] == "olasz") db3++;          // listát tartalmazó lista
                if (adatok_t[i, 1] == "olasz") db4++;        //két dimenziós string tipusú tömb
            }
            Console.WriteLine($"Az olasz énekesek száma: {db1} fő");
            Console.WriteLine($"Az olasz énekesek száma: {db2} fő");
            Console.WriteLine($"Az olasz énekesek száma: {db3} fő");
            Console.WriteLine($"Az olasz énekesek száma: {db4} fő\n");


            //b)	Hány olyan van, akinek a neve legalább 15 karakter hosszú (a szóközöket is beleértve)?
            int db_b = 0;
            db2 = 0; 
            db3 = 0; 
            db4 = 0;
            for(int i=0; i < fajlbol.Length; i++)
            {
                if(adatok_s[i].nev.Length >=15) db_b++; // énekes tipusu tömb
                if (adatok_sl[i].nev.Length >=15) db2++; // énekes tipusú tömb
                if ((adatok[i][0]).Length >=15) db3++; // listát tartalmazó lista
                if (adatok_t[i, 0].Length >= 15) db4++;
            }
            Console.WriteLine($"{db_b} énekesnek legalább 15 karakter hosszú a neve");
            Console.WriteLine($"{db2} énekesnek legalább 15 karakter hosszú a neve");
            Console.WriteLine($"{db3} énekesnek legalább 15 karakter hosszú a neve");
            Console.WriteLine($"{db4} énekesnek legalább 15 karakter hosszú a neve");
            string szo = "almafa";
            Console.WriteLine(szo.Length);

            //4) Olvassa be egy fájlból a csoport diákjainak nevét és születési dátumát!
            Console.WriteLine("\n4. Feladat");

            string[] fajlbol4 = File.ReadAllLines("diak.txt");
            Diak[] adatok = new Diak[fajlbol4.Length]; // Count ha lista || Lenght ha string 
            List<Diak> diakok = new List<Diak>();
            
            for (int i = 0; i < fajlbol4.Length; i++)
            {
                string[] darabol = fajlbol4[i].Split(';');
                adatok[i].nev = darabol[0];
                
                Diak kisdiak =  new Diak();
                kisdiak.nev = darabol[0];
                darabol = darabol[1].Split('.');
                
                adatok[i].ev = int.Parse(darabol[0]);
                adatok[i].honap = int.Parse(darabol[1]);
                adatok[i].nap = int.Parse(darabol[2]);

                kisdiak.ev = int.Parse(darabol[0]);
                kisdiak.honap = int.Parse(darabol[1]);
                kisdiak.nap = int.Parse(darabol[2]);
                
                diakok.Add(kisdiak);
            }

            int[] honapok = new int[12];

            for(int i = 0; i < fajlbol4.Length; i++)
            {
                honapok[adatok[i].honap -1]++;
            }
            string[]honapnev = new string[12] {"január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december"};
            for(int i=0; i<12; i++)
            {
                Console.Write($"{honapnev[i]}-ban/ben:\t {honapok[i]} tanuló született.\n");
            }

            Console.WriteLine();
            //a)	Adja meg, hogy melyik hónapban hányan születtek!

            //b)	Van-e, aki bármelyik hónapban a maival egyező napon született (pl. 14-én)?

    //5) Generáljon 1-től 200-ig 25 véletlen számot!

            //a)	Függvénnyel adja meg, a páratlanok szorzatát!

            //b)	Adja meg az összegüket váltakozó előjellel! Az első tag pozitív legyen!

            //c)	Adja meg a 10. elemet!

            //d)	Hány negatív szám van köztük?

            //e)	Van-e benne olyan, ami 7-tel osztva 2 maradékot ad?

            //f)	Törölje a nem prímeket!

            //g)	Rendezze a prímeket növekvő sorrendbe!
            Console.ReadLine();

        }
    }
}
