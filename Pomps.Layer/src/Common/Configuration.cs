using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomps.Layer.src.Common
{
    static class Configuration
    {
        public static string Provider
        { get
            {
                return Properties.Settings.Default.Provider;
            }
        }
    }
}
