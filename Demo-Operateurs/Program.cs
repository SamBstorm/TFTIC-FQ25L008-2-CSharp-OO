namespace Demo_Operateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Rappel opérateur system
             * int nb1 = 5, nb2 = 7, result;
            result = nb1 + nb2;

            Console.WriteLine($"{nb1} + {nb2} = {result}");

            string word1 = "Hello", word2 = "world";

            Console.WriteLine(word1 + " " + word2 + "!");
            */

            Panier p1 = new Panier();
            p1.AddFruit(new Fruit());
            p1.AddFruit(new Fruit());
            p1.AddFruit(new Fruit());

            //Console.WriteLine($"Dans le panier 1 nous avons : {p1.fruits.Count} fruits");

            Panier p2 = new Panier();
            p2.AddFruit(new Fruit());
            p2.AddFruit(new Fruit());

            //Console.WriteLine($"Dans le panier 2 nous avons : {p2.fruits.Count} fruits");

            Panier total = p1 + p2;

            //Console.WriteLine($"Si je réunis le tout, j'obtiens un panier de {total.fruits.Count} fruits");

            Console.WriteLine($"Ajoutons-y un fruit! Cela me donne : {total + new Fruit()} fruits.");

            Panier voisin = new Panier();
            voisin.AddFruit(new Fruit());
            voisin.AddFruit(new Fruit());
            voisin.AddFruit(new Fruit());
            voisin.AddFruit(new Fruit());
            voisin.AddFruit(new Fruit());

            if (total > voisin)
            {
                Console.WriteLine("J'ai plus de fruit que le voisin!");
            }
            else if(total < voisin)
            {
                Console.WriteLine("Le voisin est encore venu voler mes fruits!");
            }
            else
            {
                Console.WriteLine("Il en a autant que moi, mais les miens sont plus beaux!");
            }
                    
        }
    }
}
