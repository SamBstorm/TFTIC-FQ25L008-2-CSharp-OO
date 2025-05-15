using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriente_Objet.Models
{
    /**
     * Modèle de mon objet :
     *  - Avant de créer dans le cadre de l'exécution de mon programme les objets dont je vais avoir besoin, je dois les définir.
     *      pour se faire je définis une classe (comme celle ci-dessous).
     *      
     *  - Cette classe va posséder différentes choses :
     *      - Des caractéristiques ( taille du téléphone, qualité de la caméra, état)
     *      - Des méthodes (Elles définissent les fonctionnalités du téléphone, ( ex : passer un appel, on y retrouve donc des précisions
     *          logiques quand à un fonctionnement).
     */
    class Telephone
    {
        public double taille;
        public string couleur;
        public string etat;
        public string ecran;

        #region Constructeur
        /** Le constructeur :
         *  - Méthode spécial d'une classe qui est utilisé pour créer (instancier) les objets dans le cadre d'un programme.
         *      Noter qu'il existe par défaut un constructeur implicite dans toutes classes définies et que celui ne possède rien 
         *      dans les parenthèses => Telephone()
         *      
         *  - Donc de part le mécanisme de surcharge (voir region surcharge), lorsque je définis le constructeur téléphone explicitement
         *      dans mon code, comme ci-dessous, je viens écraser l'ancienne définition.
         *      
         *      Le constructeur par défaut d'une classe ressemble à ceci :
         *      
         *      public MêmeNomQueLaClasse(rienDansLesParenthèses) 
         *      {
         *          Rien dans le bloc d'instruction.
         *      }
         * 
         */
        public Telephone()
        {
            taille = 12;
            couleur = "noir";
            etat = "neuf";
            ecran = "OLED";
        }

        public Telephone(string couleur)
        {
            taille = 12;
            this.couleur = couleur;
            etat = "neuf";
            ecran = "OLED";
        }
        #endregion

        void appeler()
        {

        }

        #region SURCHARGE
        /**
         * La surcharge de méthodes permet de redéfinir la logique qui se passe dans plusieurs méthodes portant le même nom.
         * 
         *  - Ici, la méthode addition est définie 3x.
         *      - Dans chacun de ces 3 cas, la signature de la méthode est différente :
         *          1. elle reçoit 2 int.
         *          2. elle reçoit 1 int & 1 float.
         *          3. elle ne reçoit rien
         *  
         *  On peut surcharger une méthode autant de fois qu'on le souhaite à partir du moment où la signature diverge.
         *      - Je n'aurai donc jamais, 2x addition(int, int) sinon erreur de compilation).
         *      
         *  Ce processus peut également être utiliser sur le constructeur puisque le constructeur est également une méthode.
         * 
         */
        public int addition(int nb1, int nb2)
        {
            return nb1 + nb2;
        }

        public float addition(int a, float b )
        {
            return a + b;
        }

        public int addition()
        {
            return 2 + 3;
        }

        #endregion

    }
}
