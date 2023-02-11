using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP
{
    public class Kutya
    {
        // tulajdonságok
        // legyen public, hogy más objektumok is lássák
        public string nev;
        public string szin;
        public string fajta;
        public bool neme; // 0 = lany, 1 = fiu
        public int kor;


        // metodusok
        // public itt is fontos
        public string ugatas()
        {
            return "Vau-vau";
        }
    }
}
