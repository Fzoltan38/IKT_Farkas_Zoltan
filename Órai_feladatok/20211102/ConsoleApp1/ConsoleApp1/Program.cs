using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ember {
        public string nev;
        public int kor;

        public ember(string nev, int kor)
        {
            this.nev = nev;
            this.kor = kor;
        }

       
    }
    class arucikk
    {
        public string nev;
        public int ar;
        public int db;

        public arucikk(string nev, int ar, int db)
        {
            this.nev = nev;
            this.ar = ar;
            this.db = db;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] nevek = { "Pisti", "Feri", "Péter", "Tamás" };
            IEnumerable query = nevek.Where(n => n.Contains('i')).OrderBy(n=>n);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            List<ember> emberek = new List<ember>();
            emberek.Add(new ember("Pisti",19));
            emberek.Add(new ember("Géza", 23));
            emberek.Add(new ember("Sanyi", 34));
            emberek.Add(new ember("Peti", 17));

            IEnumerable query2=emberek.Select(n =>new ember(n.nev,n.kor)).OrderBy(n =>n.kor).Where(n =>n.kor<30);
            foreach (ember item in query2)
            {
                Console.WriteLine(item.nev);
            }

            List<arucikk> cikkek = new List<arucikk>();
            cikkek.Add(new arucikk("alma", 330, 5));
            cikkek.Add(new arucikk("körte", 550, 15));
            cikkek.Add(new arucikk("eper", 860, 52));
            cikkek.Add(new arucikk("alma", 330, 7));
            cikkek.Add(new arucikk("alma", 330, 9));

            IEnumerable query3 = cikkek.Where(n => n.nev.Equals("alma")).OrderBy(n =>n.db);
            foreach (arucikk item in query3)
            {
                Console.WriteLine(item.db);
            }

            Console.ReadLine();


        }
    }
}
