namespace Demo_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb1 = 0, nb2 = 0, result = 0;

            try
			{
                try
                {
                    do
                    {
                        Console.WriteLine("Veuillez introduire un premier nombre :"); 
                    } while (!TryParse(Console.ReadLine(), out nb1));
                }
                catch (OverflowExtendedException oExtEx)
                {
                    long.Parse((string)oExtEx.Value);
                    Console.WriteLine("La valeur aurait pu être sauvegardée dans un long...");
                    throw oExtEx;
                }

                do
                {
                    Console.WriteLine("Veuillez introduire un second nombre :"); 
                } while (!TryParse(Console.ReadLine(), out nb2));

                result = nb1 / nb2;

                Console.WriteLine($"{nb1} / {nb2} = " + result);
			}
            catch(DivideByZeroException)
            {
                Console.WriteLine($"La division par 0 de {nb1} tend vers l'infini et au-delà!");
            }
            catch(FormatException fEx)
            {
                Console.WriteLine($"La valeur {fEx.Data[0]} n'est pas un nombre!");
            }
            catch(ArgumentNullException aNullEx)
            {
                Console.WriteLine("Pas de valeur reçue...");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
			}
			finally
			{
                Console.WriteLine("Appuyez sur une touche pour teminer...");
				Console.ReadKey(true);
			}
        }
    
        /// <summary>
        /// Fonction de convertion de String vers Int32.
        /// </summary>
        /// <param name="value">Valeur à convertir</param>
        /// <param name="result">Variable récupérant la valeur convertie ou 0</param>
        /// <returns>True : Réussite de la convertion | False : échec de la convertion</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="OverflowExtendedException"></exception>
        static bool TryParse(string value, out int result)
        {
            result = 0;
            try
            {
                result = int.Parse(value);
                return true;
            }
            catch (FormatException fEx)
            {
                return false;
            }
            catch (OverflowException oEx)
            {
                throw new OverflowExtendedException(value, result.GetType());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
