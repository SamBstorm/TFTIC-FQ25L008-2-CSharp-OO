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
        Retrait(montant,0);
        DateDernierRetrait = DateTime.Now;
    }

    protected override double CalculInteret()
    {
        return Solde * 0.045;
    }
}

