using GestionBanque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanqueException.Exceptions
{
    internal class SoldeInssufisantException : Exception
    {
        private double _montant;

        private Compte _compte;

        public double Montant
        {
            get { return _montant; }
        }

        public string NumeroCompte
        {
            get { return _compte.Numero; }
        }

        public double SoldeCompte
        {
            get { return _compte.Solde; }
        }

        public Type TypeCompte
        {
            get { return _compte.GetType(); }
        }

        public double LimitSoldeCompte
        {
            get
            {
                if (_compte is Epargne) return 0;
                else return ((Courant)_compte).LigneDeCredit;
            }
        }

        public SoldeInssufisantException(double montant, Compte compte) : base("Votre solde est actuellement inssufisant pour effectuer votre retrait.")
        {
            _montant = montant;
            _compte = compte;
        }
    }
}
