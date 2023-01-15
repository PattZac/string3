using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string sVelika = s.ToUpper();
            string sMala = s.ToLower();
            string sPrvaTri = s.Substring(0, 3);
            string sZadnjihPet = s.Substring(s.Length - 5, 5);
            string s8_11 = s.Substring(8, 11);
            Console.WriteLine(sVelika + "\r\n" + sMala + "\r\n" + sPrvaTri + "\r\n" + sZadnjihPet + "\r\n" + s8_11);
            Console.ReadKey();
        }
    }
}
