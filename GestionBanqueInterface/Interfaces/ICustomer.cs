namespace GestionBanque.Interfaces;

internal interface ICustomer
{
    double Solde { get; }

    void Depot(double montant);
    void Retrait(double montant);
}
