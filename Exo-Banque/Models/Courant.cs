using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public class Courant
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }

        private double _ligneDeCredit;

        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set {
                if (value < 0) return;
                _ligneDeCredit = value;
            }
        }

        public Personne Titulaire { get; set; }

        public void Retrait(double montant) {
            if (montant <= 0) return;
            if (Solde + LigneDeCredit < montant) return;
            Solde -= montant;
        }

        public void Depot(double montant) {
            if (montant <= 0) return;
            Solde += montant;
        }

    }
}
