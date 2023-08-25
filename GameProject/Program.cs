using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "Batuhan",
                LastName = "Aslan",
                IdentityNumber = 12345
            });
            Console.WriteLine("Hello World!");
        }
    }
}
