namespace GestionBanque.Models;

internal class Personne
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public DateTime DateNaiss { get; set; }

    public Personne(string nom, string prenom, DateTime dateNaiss)
    {
        Nom = nom;
        Prenom = prenom;
        DateNaiss = dateNaiss;
    }
}
