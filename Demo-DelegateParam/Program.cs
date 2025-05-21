namespace Demo_DelegateParam
{
    delegate bool FilterFunc(int value);
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = [4, 5, 81, 62, 13, 41, 14];

            FilterFunc greatherThan50 = delegate (int value)
            {
                return value > 50;
            };

            FilterFunc evenNumber = delegate (int value)
            {
                return value % 2 == 0;
            };

            FilterFunc oddNumber = delegate (int value)
            {
                return value % 2 != 0;
            };

            ShowFilteredValues(ints, evenNumber);
            ShowFilteredValues(ints, oddNumber);
            ShowFilteredValues(ints, greatherThan50);


            //List<int> filteredResult = new List<int>();
            //foreach (int value in ints)
            //{
            //    if (value % 2 == 0) filteredResult.Add(value);
            //}

            //foreach (int evenValue in filteredResult)
            //{
            //    Console.WriteLine(evenValue);
            //}

            //filteredResult = new List<int>();
            //foreach (int value in ints)
            //{
            //    if (value % 2 != 0) filteredResult.Add(value);
            //}

            //foreach (int oddValue in filteredResult)
            //{
            //    Console.WriteLine(oddValue);
            //}

            //filteredResult = new List<int>();
            //foreach (int value in ints)
            //{
            //    if (value > 50) filteredResult.Add(value);
            //}

            //foreach (int greatherThan50 in filteredResult)
            //{
            //    Console.WriteLine(greatherThan50);
            //}
        }

        static void ShowFilteredValues(int[] ints, FilterFunc func)
        {
            List<int> filteredResult = new List<int>();
            foreach (int value in ints)
            {
                if (func(value)) filteredResult.Add(value);
            }

            foreach (int greatherThan50 in filteredResult)
            {
                Console.WriteLine(greatherThan50);
            }
        }
    }
}
