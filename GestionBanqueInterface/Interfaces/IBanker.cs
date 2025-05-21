using GestionBanque.Models;

namespace GestionBanque.Interfaces;

internal interface IBanker : ICustomer
{
    string Numero { get; }
    Personne Titulaire { get; }


    void AppliquerInteret();
}
