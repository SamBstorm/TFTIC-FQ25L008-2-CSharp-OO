namespace Demo_Indexeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JeuDeSociete jds = new JeuDeSociete();

            Joueur sam = new Joueur() { Nom = "Samuel", Score = 0 };
            Joueur michael = new Joueur() { Nom = "Michaël", Score = 0 };
            Joueur thierry = new Joueur() { Nom = "Thierry", Score = 0 };
            Joueur thierry2 = new Joueur() { Nom = "Thierry", Score = 10_000 };
            Joueur georges = new Joueur() { Nom = "Georges", Score = 0 };

            jds.AjouterJoueur(PionJeu.Dinosaure, sam);
            jds[PionJeu.Voiture] = thierry2;
            jds.AjouterJoueur(PionJeu.Cheval, thierry);
            jds.AjouterJoueur(PionJeu.Oie, georges);

            Console.WriteLine($"Actuellement dans notre jeu, nous avons {jds.NbJoueurs} joueurs.");

            Console.WriteLine($"Le joueur avec le pion du Dinosaure est : {jds[PionJeu.Dinosaure].Nom}");

            Console.WriteLine($"Les joueurs dont le nom est Thierry sont au nombre de {jds["Thierry"].Length}.");
            foreach (PionJeu pion in jds["Thierry"])
            {
                Console.WriteLine($"\t- {pion} : {jds[pion].Nom} - {jds[pion].Score} points");
            }
        }
    }

    public enum PionJeu { Voiture, Cheval, Oie, Dinosaure, Lapin, Tortue, Bateau, Avion }

    public class Joueur
    {
        public string Nom { get; set; }
        public int Score { get; set; }
    }

    public class JeuDeSociete
    {
        private Dictionary<PionJeu, Joueur> _joueurs;

        public int NbJoueurs
        {
            get { return _joueurs.Count; }
        }

        public Joueur this[PionJeu index]
        {
            get {
                Joueur j = null;
                if (_joueurs is not null && _joueurs.ContainsKey(index))
                {
                    j = _joueurs[index];
                }
                return j;
            }
            set {
                if (value is null) return;
                AjouterJoueur(index, value);
            }
        }

        public PionJeu[] this[string playerName]
        {
            get
            {
                List<PionJeu> pions = new List<PionJeu>();
                foreach (KeyValuePair<PionJeu, Joueur> joueur in _joueurs)
                {
                    if (joueur.Value.Nom == playerName) pions.Add(joueur.Key);
                }
                return pions.ToArray();
            }
        }

        public void AjouterJoueur(PionJeu pionChoisi, Joueur nouveauJoueur)
        {
            _joueurs ??= new Dictionary<PionJeu, Joueur>();
            if (_joueurs.Count == 4) return;                     //Pas assez de pion
            if (_joueurs.ContainsKey(pionChoisi)) return;        //Pion déjà en jeu
            if (_joueurs.ContainsValue(nouveauJoueur)) return;   //Un joueur ne peut s'inscrire 2 fois

            _joueurs.Add(pionChoisi, nouveauJoueur);
        }
    }
}
