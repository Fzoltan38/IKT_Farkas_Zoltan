using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2Linq
{
    class ember 
    {
        public string nev;
        public int kor;

        public ember(string nev, int kor)
        {
            this.nev = nev;
            this.kor = kor;
        }
    }


    class arucikk {
        public string neve;
        public int ar;
        public int mennyiseg;

        public arucikk(string neve, int ar, int mennyiseg)
        {
            this.neve = neve;
            this.ar = ar;
            this.mennyiseg = mennyiseg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] nevek = {"Pisti","Tamás","Kredenc","Valéria","Emese" };
            IEnumerable query = nevek.Where(n => n.Contains('e')).OrderByDescending(n=>n);
            foreach (IEnumerable item in query)
            {
                Console.WriteLine(item);
            }

            List<ember> emberek = new List<ember>();
            emberek.Add(new ember("Feri", 24));
            emberek.Add(new ember("Pisti", 26));
            emberek.Add(new ember("Tamás", 21));
            emberek.Add(new ember("Gazsi", 18));
            emberek.Add(new ember("Jolán", 36));

            List<ember> query2 = emberek.Select(n => new ember(n.nev, n.kor)).OrderBy(n =>n.kor).Where(n => n.kor<30).ToList();
            Console.WriteLine("Az emberek:");
            foreach (var item in query2)
            {
                Console.WriteLine(item.nev +" "+item.kor);
            }

            List<arucikk> arucikkek = new List<arucikk>();
            arucikkek.Add(new arucikk("alma",350,18));
            arucikkek.Add(new arucikk("körte", 450, 10));
            arucikkek.Add(new arucikk("szilva", 650, 18));
            arucikkek.Add(new arucikk("alma", 350, 25));
            arucikkek.Add(new arucikk("körte", 450, 18));
            arucikkek.Add(new arucikk("alma", 350, 10));

            List<arucikk> query3 = arucikkek.Where(n =>n.neve=="alma").OrderBy(n=>n.mennyiseg).ToList();

            foreach (var item in query3)
            {
                Console.WriteLine(item.neve+" "+item.ar+" "+item.mennyiseg);
            }


           List<string> query4 = arucikkek.Select(n =>n.neve).Distinct().ToList();

            foreach (var item in query4)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }
    }
}
