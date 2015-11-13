using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pigeon
{
    public partial class Module
    {
        private static Module module;

        static public Module GetInstance()
        {
            if (Module.module == null)
                module = new Module();

            return module;
        }
    }
}
