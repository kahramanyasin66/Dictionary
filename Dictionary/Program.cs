using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1) Dictionary sınıfı içinde belirleyeceğimiz bir key'e uygun olarak değer saklar
             2) key türünü belirleme zorunluluğu var (string ,int ,double)
             */
            //Dictionary<string, int> AdYas = new Dictionary<string, int>();
            //// veri ekleme 
            //AdYas.Add("Yasin", 25);
            //AdYas.Add("Bektaş", 41);
            //AdYas.Add("İlker", 35);

            //foreach (var degeroku in AdYas)
            //{
            //    Console.WriteLine(degeroku);
            //}
            ////deger sayma 
            //var eleman = AdYas.Count;
            //Console.WriteLine("Eleman Sayisi :" + " " + eleman);
            ////deger silme 
            //AdYas.Remove("Yasin");
            //foreach (var degeroku in AdYas)
            //{
            //    Console.WriteLine(degeroku);
            //}
            //Console.ReadLine();

            MyDictionary<string, int> AdYas = new MyDictionary<string, int>();

            AdYas.Add("Yasin", 25);
            AdYas.Add("Bektaş", 41);
            AdYas.Add("İlker", 35);

            foreach (var isim in AdYas.Keys)
            {
                Console.WriteLine(isim);
            }
            foreach (var yas in AdYas.Values)
            {
                Console.WriteLine(yas);
            }
            Console.ReadLine();

        }
    }
}
