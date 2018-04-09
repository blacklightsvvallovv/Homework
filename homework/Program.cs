using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1SHORP
{
    class Program
    {
        static void Main(string[] args)
        {
            Strings symbols = new Strings("hghg++hg+");
            
            symbols.Replace();
            symbols.Insert();
            symbols.Show();

            string s = String.Format(symbols.ToString());
            Console.ReadKey();
          }
    }
}
