using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationPlugin.Plugins
{
    public class SamplePlugin1 : IPlugin
    {
        public string Name => "Sample Plugin 1";

        public void Execute()
        {
            Console.WriteLine("Executing Sample Plugin 1");
        }
    }

}
