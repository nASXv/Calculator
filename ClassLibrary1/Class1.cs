using System;
using System.Collections.Generic;
using System.ComponentModel;  //
using System.Linq;
using System.Runtime.CompilerServices; //
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Logarithm
    {
        private string language;  //
        private string a;
        private string b;
        public Logarithm(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public string getLogarithm()
        {
            return "" + Math.Round (Math.Log(Int32.Parse(b), Int32.Parse(a)),3);
        }

        public string Language    //
        {
            get { return language; }
            set
            {
                language = value;
                // OnPropertyChanged("Language");
            }
        }                              //
    }
}
