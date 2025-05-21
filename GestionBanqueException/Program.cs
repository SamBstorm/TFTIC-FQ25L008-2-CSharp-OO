using GestionBanque.Interfaces;
using GestionBanque.Models;
using GestionBanqueException.Exceptions;
using System.Numerics;

Personne client = new Personne("Fivez", "Mauritcio", new DateTime(2001, 1, 15));
Compte courant = new Courant("123ABC Courant", client, 1000);
Compte epargne = new Epargne("123ABC Epargne", client);

courant.Depot(500);
epargne.Depot(1000);

courant.AppliquerInteret();
epargne.AppliquerInteret();

Console.WriteLine($"Courant ({courant.Numero}) : {courant.Solde:F2} €");
Console.WriteLine($"Epargne ({epargne.Numero}) : {epargne.Solde:F2} €");


// Utilisation des interfaces ICustomer & IBanker
ICustomer customer = courant;
customer.Depot(500);
customer.Retrait(200);
Console.WriteLine($"Solde du compte: {customer.Solde}");
// customer.AppliquerInteret(); // Pas accès

IBanker banker = courant;
banker.Depot(500);
try
{
    banker.Retrait(20000);
}
catch(SoldeInssufisantException soldeExec)
{
    Console.WriteLine(soldeExec.Message);
    Console.WriteLine($"Montant demandé : {soldeExec.Montant}");
    Console.WriteLine($"Compte traité : {soldeExec.NumeroCompte}");
    Console.WriteLine($"Solde courant : {soldeExec.SoldeCompte}");
    Console.WriteLine($"Limite courante : {soldeExec.LimitSoldeCompte}");
}
banker.AppliquerInteret();
Console.WriteLine($"Solde du compte: {banker.Solde}");
Console.WriteLine($"Titulaire du compte: {banker.Titulaire}");
Console.WriteLine($"Numero du compte: {banker.Numero}");
