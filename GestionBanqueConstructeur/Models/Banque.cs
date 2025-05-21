namespace GestionBanque.Models;

internal class Banque
{
    #region DECLARATION
    public string Nom { get; set; }

    private Dictionary<string, Compte> comptes = new Dictionary<string, Compte>();

    public Compte this[string numero]
    {
        get
        {
            if (!comptes.ContainsKey(numero))
                throw new KeyNotFoundException("Compte non trouvé.");
            return comptes[numero];
        }
    }

    #endregion
    public Banque(string nom)
    {
        Nom = nom;
    }

    #region FONCTIONS D'INSTANCE
    public void Ajouter(Compte compte)
    {
        if (compte == null || string.IsNullOrWhiteSpace(compte.Numero))
            throw new ArgumentException("Compte invalide.");

        if (comptes.ContainsKey(compte.Numero))
            throw new InvalidOperationException("Compte déjà existant.");

        comptes[compte.Numero] = compte;
    }

    public void Supprimer(string numero)
    {
        if (!comptes.Remove(numero))
        {
            throw new KeyNotFoundException("Le compte à supprimer n'existe pas.");
        }
        comptes.Remove(numero);
    }

    public double AvoirDesComptes(Personne titulaire)
    {
        double total = 0;

        foreach (var compte in comptes.Values)
        {
            if (compte.Titulaire == titulaire)
            {
                total += compte.Solde > 0 ? compte.Solde : 0;
            }
        }

        return total;
    }
    #endregion
}
