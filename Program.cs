using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(55,"Gökhan Çam");
            kullanıcılar.Add(25,"Sümeyye Aydin");


            Console.WriteLine(kullanıcılar[55]);

            foreach(var kullanıcı in kullanıcılar)
            {
                Console.WriteLine(kullanıcı);
            }

            // Count
                Console.WriteLine(kullanıcılar.Count());

            // Contains
                Console.WriteLine(kullanıcılar.ContainsKey(25));
                Console.WriteLine(kullanıcılar.ContainsValue("aLİ"));

            // Remove
            kullanıcılar.Remove(55);
            foreach(var kullanıcı in kullanıcılar)
            {
                Console.WriteLine(kullanıcı);
            }

            // keys and value

            foreach(var kullanıcı in kullanıcılar.Keys)
            {
                Console.WriteLine(kullanıcı);
            }

            foreach(var kullanıcı in kullanıcılar.Values)
            {
                Console.WriteLine(kullanıcı);
            }



        }
    }
}
