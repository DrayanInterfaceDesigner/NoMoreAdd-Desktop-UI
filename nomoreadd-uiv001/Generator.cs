using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomoreadd_uiv001
{
    class Generator
    {
        private string link;
        public string GenerateLink(string num)
        {
            string link = $"//api.whatsapp.com/send/?phone={num}&text&app_absent=0";
            this.link = link;
            return this.link;
        }

        public void PrintLink()
        {
            Console.WriteLine("Here's your link:");
            Console.WriteLine($"\t{this.link}");
        }
    }
}
