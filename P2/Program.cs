using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {

            //pol.2
            List<Sportowiec> sport = new List<Sportowiec>();
            sport.Add(new Biegacz("ss", 'w', 234));
            sport.Add(new Biegacz("sedes", 'e', 34));
            sport.Add(new Biegacz("srfers", 'q', 54));
            sport.Add(new Biegacz("32343ss", 'v', 555));
            foreach(var element in sport)
            {
                element.Zawody(4);
            }

            //pol.3
            foreach (var element in sport)
            {
                Console.WriteLine(element);
            }

            //pol.4
            sport.Sort();
            foreach (var element in sport)
            {
                Console.WriteLine(element);
            }
            sport.Reverse();

            //pol.5
            Zawodnik zaw = new Zawodnik();
            zaw.Medal();
            zaw.Miejsce("ssd");

            //pol.6
            string wejscie = Console.ReadLine();
            int liczba = 0;
            Int32.TryParse(wejscie, out liczba);
            Zawodnik zaw2 = new Zawodnik();
            zaw2.UstawCzas(liczba);

            //pol.7
            Zawody zawody1 = Zawody.Utworz(34);

            //pol.8
            ArrayList a1 = new ArrayList();
            a1.Add("sss");
            a1.Add('d');
            a1.Add(344);
            a1.Add(4.5d);
            a1.Add(6.5f);
            a1.Add(new DateTime(2018, 1, 1));
            for(int i=0; i< a1.Count;i++)
            {
                if (i % 2 != 0) Console.WriteLine(a1[i]);
            }

            //pol.9
            LinkedList<char> znaki = new LinkedList<char>();
            znaki.AddFirst('e');
            znaki.AddFirst('5');
            znaki.AddFirst('t');
            znaki.AddFirst('s');
            znaki.AddFirst('g');
            LinkedListNode<char> trzy =znaki.Find(znaki.ElementAt(3));
            znaki.AddBefore(trzy, 'w');

            Console.ReadKey();
        }
    }
}
