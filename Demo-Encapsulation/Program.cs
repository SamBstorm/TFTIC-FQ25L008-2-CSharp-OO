namespace Demo_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoClassDefaut dcd = new DemoClassDefaut();    //Pas de soucis d'instanciation, internal est accessible dans le même projet
            //dcd.textDefaut = "Toto";                        //Pas d'accès à la variable, celle-ci est accessible dans sa class mais pas en dehors
            //dcd.DemoMethodeDefaut();                        //Pas d'accès à la variable, celle-ci est accessible dans sa class mais pas en dehors

            dcd.changeValueTextDefaut("Je peux accéder à ma variable privée grâce à cette méthode publique!");
            dcd.afficheTextDefaut();
        }
    }

    class DemoClassDefaut       //Pas de spécification d'encapsulation dans un namespace : internal
    {
        string textDefaut;      //Pas de spécification d'encapsulation dans une class : private

        void DemoMethodeDefaut()//Pas de spécification d'encapsulation dans une class : private
        {
            Console.WriteLine("Je suis une méthode sans encapsulation, je ne sais pas être accessible sauf dans ma class...");
        }

        public void changeValueTextDefaut(string newValue)
        {
            textDefaut = newValue;
        }

        public void afficheTextDefaut()
        {
            Console.WriteLine(textDefaut);
        }
    }
}
