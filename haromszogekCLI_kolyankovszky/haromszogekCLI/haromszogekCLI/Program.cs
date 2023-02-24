using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace haromszogekCLI
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<Haromszog> haromszogs = new List<Haromszog>();
            StreamReader sr = new StreamReader("haromszogek2.csv");
            while (!sr.EndOfStream)
            {
                Haromszog h = new Haromszog(sr.ReadLine());
                haromszogs.Add(h);
            }
            sr.Close();

            foreach (var item in haromszogs)
            {
                if (derekszogu(item.oldalA, item.oldalB, item.oldalC))
                {
                    Console.WriteLine("a:"+item.oldalA+" b:"+item.oldalB+" c:"+item.oldalC);
                }
            }
            Haromszog maxharomszog = haromszogs[0];
            foreach (var item in haromszogs)
            {
                if ((item.oldalA*item.oldalB)/2>(maxharomszog.oldalA*maxharomszog.oldalB)/2)
                {
                    maxharomszog = item;
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        public static bool derekszogu(int a, int b, int c)
        {
            if (a*a+b*b==c*c)
            {
                return true;
            }
            return false;
        }
    }
}
