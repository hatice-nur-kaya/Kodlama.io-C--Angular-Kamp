using System;

namespace OyunOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {Id =1, BirthDay = 1999 , firstName = "Hatice Nur" ,lastName = "KAYA" ,IdentityNumber = 12125456654 });
            Console.WriteLine("Hello World!");
        }
    }
}
