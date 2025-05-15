using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque.Models
{
    public class Banque
    {
        public string Nom { get; set; }

        private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();

        public Courant this[string numero]
        {
            get
            {
                /* Avec une boucle
                Courant courant = null;
                foreach (KeyValuePair<string, Courant> compte in _comptes)
                {
                    if (compte.Key == numero) courant = compte.Value;
                }
                return courant;*/

                /*Avec ContainsKey()*/
                if (_comptes.ContainsKey(numero)) return _comptes[numero];
                return null;
            }
        }

        public void Ajouter (Courant compte)
        {
            if (_comptes.ContainsKey(compte.Numero)) return;
            if (_comptes.ContainsValue(compte)) return;
            _comptes.Add(compte.Numero, compte);
        }

        public void Supprimer(string numero)
        {
            _comptes.Remove(numero);
        }
    }
}
