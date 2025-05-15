namespace Demo_Proprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login()
            {
                Email = "samuel.legrain@bstorm.be",
                Password = "",
                BirthDate = new DateOnly(1987, 9, 27)
            };

            Console.WriteLine($"Votre login est \nEmail : {login.Email}\nMot de passe : {login.Password}\nAge: {login.YearsOld}");

            Console.WriteLine("Veuillez indiquez votre e-mail :");
            string mail = Console.ReadLine();
            Console.WriteLine("Veuillez indiquez votre mot de passe :");
            string pwd = Console.ReadLine();

            if(login.CheckIdentity(mail, pwd))
            {
                Console.WriteLine("Bienvenue");
            }
            else
            {
                Console.WriteLine("Compte bloqué...");
            }

        }
    }

    public class Login
    {
        //prop : permet de faire une auto-propriété comme birthdate
        public DateOnly BirthDate { private get;  set; }

        //Propriété auto-calculée : propriété dépendant d'une variable devant être calculée (age s'obtient par la date de naissance, on sauvegarde pas l'âge)
        public int YearsOld
        {
            get
            {
                DateOnly today = DateOnly.FromDateTime(DateTime.Today);

                int age = today.Year - BirthDate.Year;

                if (BirthDate > today.AddYears(-age)) age--;

                return age;
            }
        }

        public string Email { get; set; }

        //propfull : permet de faire une propriété complète (variable privée et propriété) comme pour password
        private string _password;

        public string Password
        {
            get     //Récupère une information pour la donner à l'utilisateur => toujours un return du même type que la propriété
            {
                string hiddenPassword = "";
                for (int i = 0; i < _password.Length; i++)
                {
                    hiddenPassword += '*';
                }
                return hiddenPassword;
            }

            set     //Récupère une information de l'utilisateur pour le sauvegarder dans une variable (généralement) => vlue est une variable définie pour la valeur entrante
            {
                if (value is null) value = "W3lc0m3";
                value = value.Trim();
                if(string.IsNullOrEmpty(value)) value = "W3lc0m3";
                
                _password = value;
            }
        }

        public bool CheckIdentity (string mail, string pwd)
        {
            return Email == mail && _password == pwd;
        }
    }
}
