using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate01.Models
{
    delegate bool LoadingMethod();
    class VisualStudioCode
    {
        //public List<ExtensionsVSCode> Extensions { get; set; }

        private LoadingMethod _loadingMethods;

        public VisualStudioCode()
        {
            //Extensions = new List<ExtensionsVSCode>();
        }

        public void AddExtensions(ExtensionsVSCode extension)
        {
            //Extensions.Add(extension);
            _loadingMethods += extension.LoadingExtension;
        }

        public void RemoveExtensions(ExtensionsVSCode extension)
        {
            _loadingMethods -= extension.LoadingExtension;
        }

        public void StartEditor()
        {
            //foreach (ExtensionsVSCode ext in Extensions)
            //{
            //    ext.LoadingExtension();
            //}

            _loadingMethods?.Invoke();
            Console.WriteLine("Chargement terminé!");
        }
    }
}
