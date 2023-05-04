using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generatore_Indirizzo
{
    class AddressGenerator:IAddress
    {
        private string _bit;
        public AddressGenerator(string bit)
        {
            if (bit.Length == 32)
            {
                for (int i = 0; i < bit.Length; i++)
                {
                    if (bit[i] != '0' && bit[i] != '1')
                    {
                        throw new Exception("non è una sequenza di bit");
                    }
                    this._bit = bit;
                }
            }
            else
            {
                throw new Exception("lunghezza non valida");
            }
        }
        
        public string generateIpv4()
        {
            string ip;
            string[] ottetto = new string[4];
            Random valore = new Random();
            for (int i = 0; i < ottetto.Length; i++)
            {
                ottetto[i] = valore.Next(256).ToString();
            }
            ip = string.Join(".",ottetto);
            return ip;
        }
        public string genrateSubnet()
        {
            string subnet;
            string ip = generateIpv4();
            string[] ottetti = ip.Split('.');
            int CIDR;
            Random value = new Random();

            if (ottetti[3] == "0" || ottetti[3] == "255")
            {
                CIDR = value.Next(0, 24);
            }
            else
            {
                CIDR = value.Next(0, 30);
            }
            return CIDR.ToString();
        }
            
             

    }
}
