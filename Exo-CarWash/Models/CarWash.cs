using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_CarWash.Models
{
    delegate void TraitementVoiture(Voiture v);
    class CarWash
    {
        private TraitementVoiture _traitement;
        public CarWash()
        {
            //_traitement = Preparer;
            //_traitement += Laver;
            //_traitement += Secher;
            //_traitement += Finaliser;
            _traitement = delegate(Voiture v) { Console.WriteLine($"Je prépare la voiture : {v.Plaque}"); };
            _traitement += delegate(Voiture v) { Console.WriteLine($"Je lave la voiture : {v.Plaque}"); };
            _traitement += delegate(Voiture v) { Console.WriteLine($"Je sèche la voiture : {v.Plaque}"); };
            _traitement += delegate(Voiture v) { Console.WriteLine($"Je finalise la voiture : {v.Plaque}"); };
        }
        private void Preparer(Voiture v)
        {
            Console.WriteLine($"Je prépare la voiture : {v.Plaque}");
        }
        private void Laver(Voiture v)
        {
            Console.WriteLine($"Je lave la voiture : {v.Plaque}");
        }
        private void Secher(Voiture v)
        {
            Console.WriteLine($"Je sèche la voiture : {v.Plaque}");
        }
        private void Finaliser(Voiture v)
        {
            Console.WriteLine($"Je finalise la voiture : {v.Plaque}");
        }

        public void Traiter(Voiture v)
        {
            _traitement(v);
        }
    }
}
