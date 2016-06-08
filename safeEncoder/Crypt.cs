using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace safeEncoder
{
    class Crypt
    {
        string inputCrypt { get; set; }

        public Crypt(string ToCrypt)
        {
            inputCrypt = ToCrypt;
        }
        public void GenerateKey()
        {
            Random key = new Random();
            
        }
    }
}
