using Exo_CarWash.Models;

namespace Exo_CarWash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture("2-ZZZ-999");
            Voiture v2 = new Voiture("2-AAA-111");

            CarWash carwash = new CarWash();

            carwash.Traiter(v1);
            carwash.Traiter(v2);
        }
    }
}
