using OperationPlugin;
using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            PluginManager pluginManager = new PluginManager();
            pluginManager.LoadPlugins("Plugins");

            pluginManager.ExecutePlugins();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}