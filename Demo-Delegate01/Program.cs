using Demo_Delegate01.Models;

namespace Demo_Delegate01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExtensionsVSCode prettier = new ExtensionsVSCode("Prettier", "1.2");
            ExtensionsVSCode csharp = new ExtensionsVSCode("CSharp", "8.13");
            ExtensionsVSCode json = new ExtensionsVSCode("Json", "15Bis");

            VisualStudioCode vscode = new VisualStudioCode();
            vscode.AddExtensions(prettier);
            vscode.AddExtensions(csharp);
            vscode.AddExtensions(json);

            vscode.StartEditor();

            vscode.RemoveExtensions(prettier);
            vscode.RemoveExtensions(csharp);
            vscode.RemoveExtensions(json);

            vscode.StartEditor();
        }
    }
}
