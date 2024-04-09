using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationPlugin.Plugins
{
    // SamplePlugin2.cs
    public class SamplePlugin2 : IPlugin
    {
        public string Name => "Sample Plugin 2";

        public void Execute()
        {
            Console.WriteLine("Executing Sample Plugin 2");
        }
    }

}
