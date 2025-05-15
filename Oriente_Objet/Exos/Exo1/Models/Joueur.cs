using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriente_Objet.Exos.Exo1.Models
{
    internal class Joueur
    {
        int numero;
        string nom;
        string prenom;

        public Joueur(string nomDepuisConstructeur, string prenomDepuisConstructeur) 
        {
            this.prenom = prenomDepuisConstructeur;
            this.nom = nomDepuisConstructeur;
            Random random = new Random();
            this.numero = random.Next(1, 100);
        }

        public Joueur(
            string nomDepuisConstructeur, 
            string prenomDepuisConstructeur, 
            int numeroDepuisConstructeur )
        {
            this.prenom = prenomDepuisConstructeur;
            this.nom = nomDepuisConstructeur;
            this.numero = numeroDepuisConstructeur;
        }

        public void courir()
        {
            Console.WriteLine($"{this.nom} {this.prenom} qui est le n° {this.numero} court");
        }
    }
}
