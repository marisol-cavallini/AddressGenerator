using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generatore_Indirizzo
{
    interface IAddress
    {
        string generateIpv4();
        string genrateSubnet();
    }
}
