namespace GestionBanque.Models;

internal class Epargne : Compte
{

    public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
    {
        DateDernierRetrait = DateTime.MinValue;
    }

    public DateTime DateDernierRetrait { get; private set; }


    public override void Depot(double montant)
    {
        base.Depot(montant);
    }

    public override void Retrait(double montant)
    {
        if (Solde >= montant)
        {
            ModifierSolde(Solde - montant);
            DateDernierRetrait = DateTime.Now;
        }
        else
        {
            throw new InvalidOperationException("Fonds insuffisants sur le compte épargne.");
        }
    }

    protected override double CalculInteret()
    {
        return Solde * 0.045;
    }
}

