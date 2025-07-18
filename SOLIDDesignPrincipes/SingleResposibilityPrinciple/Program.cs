using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResposibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class page
    {
        public string Title { get; set; }
        public string Content { get; set; }

        override public string ToString()
        {
            return $"{Title} - {Content}";
        }
    }



}
