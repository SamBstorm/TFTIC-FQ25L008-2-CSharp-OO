using GestionBanque.Interfaces;
using GestionBanque.Models;

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
banker.Retrait(200);
banker.AppliquerInteret();
Console.WriteLine($"Solde du compte: {banker.Solde}");
Console.WriteLine($"Titulaire du compte: {banker.Titulaire}");
Console.WriteLine($"Numero du compte: {banker.Numero}");
