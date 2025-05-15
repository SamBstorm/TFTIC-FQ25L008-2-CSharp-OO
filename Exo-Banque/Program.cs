using Exo_Banque.Models;

namespace Exo_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Permet d'afficher les symboles € ou les smileys
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Personne p1 = new Personne()
            {
                Nom = "Morre",
                Prenom = "Thierry",
                DateNaiss = new DateTime(1975, 1, 1)
            };

            Courant c1 = new Courant()
            {
                Numero = "BE01",
                Titulaire = p1,
                LigneDeCredit = 500
            };

            c1.Depot(1_000);
            c1.Retrait(1_400);

            Console.WriteLine($"Le compte {c1.Numero} appartenant à {c1.Titulaire.Prenom} {c1.Titulaire.Nom}\na pour solde {c1.Solde} € avec une ligne de crédit de {c1.LigneDeCredit}.");
         }
    }
}
