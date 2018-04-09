using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lab1SHORP
{
    class Strings
    {
        private string InitialData;
        private string ReplacedData;
        private string FinalData;
        private int quantityOfreplaces;

        public Strings(string InitialData)
        {
            this.InitialData = InitialData;
         }

        public void Replace()
        {
            
            ReplacedData = InitialData.Replace("+","*");
            quantityOfreplaces++;
        }

        public void Insert()
        {
            //InitialData.Insert()
            char[] symbols = this.ReplacedData.ToCharArray();
            FinalData = "";
            foreach (var el in symbols)
            {
                if (el == '*')
                {
                    FinalData += el;
                    FinalData += '>';
                }
                else
                {
                    FinalData += el;
                }
            }
        }
       
        
        public void Show()
        { 
        Console.WriteLine(String.Format("{0,-13} {1,-15} {2,-15}\n\n", "Input string", "Changed string", "Changed string"));
        Console.WriteLine("{0,-13} {1,-15} {2,-15}\n\n",InitialData, ReplacedData, FinalData);
        
        }



   
    }
}
