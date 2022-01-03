using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomoreadd_uiv001
{
    class Generator
    {
        private string _link;
        public string GenerateLink(string num)
        {
            string link = $"whatsapp://send/?phone={num}&text&app_absent=0";
            this._link = link;
            return this._link;
        }

        public string GenerateLinkDDI(string DDI, string num)
        {
            string link =$"whatsapp://send/?phone={DDI}{num}&text&app_absent=0";
            this._link = link;
            return this._link;
        }

        public void PrintLink()
        {
            Console.WriteLine("Here's your link:");
            Console.WriteLine($"\t{this._link}");
        }
    }
}
