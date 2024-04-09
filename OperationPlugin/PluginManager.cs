using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OperationPlugin
{

    public class PluginManager
    {
        private List<IPlugin> _plugins;

        public PluginManager()
        {
            _plugins = [];
        }

        public void LoadPlugins(string pluginDirectory)
        {

            if (!Directory.Exists(pluginDirectory))
            {
                Console.WriteLine("Plugin directory not found.");
                return;
            }

            string[] pluginFiles = Directory.GetFiles(pluginDirectory, "*.dll");

            foreach (string file in pluginFiles)
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(file);
                    Type[] types = assembly.GetTypes();

                    foreach (Type type in types)
                    {
                        if (typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface)
                        {
                            var plugin = Activator.CreateInstance(type) as IPlugin;
                            _plugins.Add(plugin);
                            Console.WriteLine($"Loaded plugin: {plugin.Name}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading plugin from {file}: {ex.Message}");
                }
            }
        }

        public void ExecutePlugins()
        {
            foreach (var plugin in _plugins)
            {
                Console.WriteLine($"Executing plugin: {plugin.Name}");
                plugin.Execute();
            }
        }
    }
}
