using DNM = Demo_NameSpace.Models;
using DNT = Demo_NameSpace.Test;

namespace Demo_NameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoStruct ds = new DemoStruct();
            DNM.DemoModel dm = new DNM.DemoModel();
            DNT.DemoModel dt = new DNT.DemoModel();

            Console.WriteLine("Hello, World!");
        }
    }

    public struct DemoStruct
    {
        public string texte;
    }
}
