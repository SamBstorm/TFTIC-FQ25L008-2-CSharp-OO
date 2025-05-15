using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oriente_Objet.Exos.Exo1.Models;

namespace Oriente_Objet.Exos.Exo1
{
    /** Enoncé : Thème = Foot
     * Créer une classe joueur qui possède les attributs suivant :
     *  - nom
     *  - prénom
     *  - numéro
     *  et la méthode suivante :
     *  - Courir()
     * 
     * Un joueur instancié doit pouvoir être défini soit :
     *  - via son nom, son prénom et voir son n° être généré aléatoirement
     *  - via la définition de chacun de ses champs
     *  - Essayer d'utiliser lors de l'instanciation de vos objets, le constructeur par défaut,
     *      Que se passe-t-il ?
     */
    internal class Exo1
    {
        public void doExo1()
        {
            //Joueur avec numéro par défaut
            Joueur joueur1 = new Joueur("Michel", "Jerem");
            // Joueur avec numéro défini
            Joueur Joueur2 = new Joueur("Thierry", "Didier", 14);
            // Tentative d'utilisation du constructeur par défaut.
            //Joueur Joueur3 = new Joueur();
            // => Ne fonctionne pas car j'ai défini au moins un constructeur dans la classe joueur,
            //      de ce fait, le constructeur par défaut est écrasé.

            joueur1.courir();
            Joueur2.courir();
        }

    }
}
