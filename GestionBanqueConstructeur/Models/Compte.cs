using GestionBanque.Interfaces;

namespace GestionBanque.Models;

internal abstract class Compte : ICustomer, IBanker
{
    public Compte(string numero, Personne titulaire)
    {
        Numero = numero;
        Titulaire = titulaire;
    }

    protected Compte(string numero, Personne titulaire, double solde) : this (numero, titulaire)
    {
        Solde = solde;
    }

    public string Numero { get; set; }
    public Personne Titulaire { get; set; }
    public double Solde { get; private set; }
   
    

    #region VIRTUAL
    public virtual void Depot(double montant)
    {
        if (montant <= 0)
            throw new ArgumentOutOfRangeException(nameof(montant), "Le montant doit être supérieur à 0.");
        Solde += montant;
    }

    public virtual void Retrait(double montant)
    {
        if (montant <= 0)
            throw new ArgumentOutOfRangeException("Le montant doit être positif.");
        Solde -= montant;
    }

    #endregion

    #region ABSTRACT
    protected abstract double CalculInteret();
    #endregion

    #region METHODES
    public void AppliquerInteret()
    {
        Solde += CalculInteret();
    }

    protected void ModifierSolde(double nouveauSolde)
    {
        Solde = nouveauSolde;
    }
    #endregion

}
