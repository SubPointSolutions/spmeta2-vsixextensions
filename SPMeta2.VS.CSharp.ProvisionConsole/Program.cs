using SPMeta2.VS.CSharp.ProvisionConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.VS.CSharp.ProvisionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConsoleAppService().Run(args);
        }
    }
}
