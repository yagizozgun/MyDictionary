using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> plakalar = new MyDictionary<int, string>();
            plakalar.Add(01, "Adana");
            plakalar.Add(02, "Adıyaman");
            plakalar.Add(03, "Afyonkarahisar");
            plakalar.Add(04, "Ağrı");
            plakalar.Add(05, "Aksaray");

            foreach (var item in plakalar.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in plakalar.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(plakalar.Count);
        }
    }
}
