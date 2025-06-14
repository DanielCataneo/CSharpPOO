using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Devices
{
     class ComboDevice : Device, IPrinter , IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing: " + document);

        }

        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print: " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }

    }
}
