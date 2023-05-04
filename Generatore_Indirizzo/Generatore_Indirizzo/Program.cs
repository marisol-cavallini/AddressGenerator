using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generatore_Indirizzo
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressGenerator Indirizzo = new AddressGenerator("10000000111111110000000000000010");
            Console.WriteLine(Indirizzo.generateIpv4());
            Console.WriteLine(Indirizzo.genrateSubnet());
            Console.ReadLine();
        }
    }
}
