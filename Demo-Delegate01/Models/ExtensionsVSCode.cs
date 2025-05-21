using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate01.Models
{
    class ExtensionsVSCode
    {
        public string Name { get; set; }
        public string Version { get; set; }

        public ExtensionsVSCode(string name, string version)
        {
            Name = name;
            Version = version;
        }

        public bool LoadingExtension()
        {
            Console.WriteLine($"Chargement en cours de {Name} V{Version}...");
            Console.WriteLine("Prêt!");
            return true;
        }
    }
}
