using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Operateurs
{
    public class Panier
    {
        private List<Fruit> _fruits = new List<Fruit>();

        public void AddFruit(Fruit fruit)
        {
            _fruits.Add(fruit);
        }

        public static Panier operator +(Panier left, Panier right)
        {
            Panier result = new Panier();

            foreach (Fruit f in left._fruits)
            {
                result.AddFruit(f);
            }

            foreach (Fruit f in right._fruits)
            {
                result.AddFruit(f);
            }

            return result;
        }

        public static int operator +(Panier left, Fruit right)
        {
            left.AddFruit(right);

            return left._fruits.Count;
        }

        public static Panier[] operator *(Panier left, int right)
        {
            Panier[] result = new Panier[right];
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = new Panier();
                foreach (Fruit f in left._fruits)
                {
                    result[i].AddFruit(f);
                }
            }

            return result;
        }

        public static bool operator < (Panier left, Panier right)
        {
            return left._fruits.Count < right._fruits.Count;
        }

        public static bool operator > (Panier left, Panier right)
        {
            return left._fruits.Count > right._fruits.Count;
        }
    }
}
