using GestionBanque.Interfaces;
using GestionBanqueException.Exceptions;

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

    /* Selon le correctif, pas besoin d'être abstract
    public virtual void Retrait(double montant) {
        Solde -= montant;
    }*/

    /*Mais selon la bonne pratique*/
    public abstract void Retrait(double montant);

    protected void Retrait(double montant, double limite)
    {
        if (montant <= 0)
            throw new ArgumentOutOfRangeException(nameof(montant), $"Le montant de {montant} doit être positif.");
        if (Solde - montant < limite)
            throw new SoldeInssufisantException(montant, this);
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
    #endregion

}
