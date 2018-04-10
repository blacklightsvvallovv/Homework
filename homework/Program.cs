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
            Strings a;
            Strings symbols = new Strings("a");
            
            
            symbols.Replace();
            symbols.Insert();
            symbols.Show();
            Console.WriteLine("Program replaces, inserts, shows result");
            string s = String.Format(symbols.ToString());
            Console.ReadKey();
          }
    }
}
