namespace GestionBanque.Models;

internal class Courant : Compte
{
    #region DECLARATION
    private double ligneDeCredit;

    public double LigneDeCredit
    {
        get => ligneDeCredit;
        set
        {
            if (value < 0)
                throw new InvalidOperationException("La ligne de crédit doit être >= 0.");
            ligneDeCredit = value;
        }
    }
    #endregion

    public Courant(string numero, Personne titulaire, double ligneDeCredit) : base(numero, titulaire)
    {
        LigneDeCredit = ligneDeCredit;
    }

    #region SURCHARGE VIA HERITAGE
    public override void Retrait(double montant)
    {
        if (montant <= 0)
            throw new ArgumentOutOfRangeException(nameof(montant), "Le montant doit être positif.");

        if (Solde - montant >= -LigneDeCredit)
        {
            ModifierSolde(Solde - montant);
        }
        else
        {
            throw new InvalidOperationException("Retrait refusé : dépassement de la ligne de crédit.");
        }
    }

    public override void Depot(double montant)
    {
        base.Depot(montant);
    }

    protected override double CalculInteret()
    {
        if (Solde >= 0)
            return Solde * 0.03;
        else
            return Solde * 0.0975;
    }
    #endregion

    #region OPERATOR SURCHAGE
    public static double operator +(Courant c1, Courant c2)
    {
        double r1 = c1.Solde > 0
            ? c1.Solde
            : 0;

        double r2 = c2.Solde > 0
            ? c2.Solde
            : 0;

        return r1 + r2;
    }
    #endregion
}
