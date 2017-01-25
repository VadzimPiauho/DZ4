using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    class Roof : IPart
    {
        public bool constructionStatus { get; set; }
        public Roof()
        {
            constructionStatus = true;
        }

        public void Construct()
        {
            Console.WriteLine("-------");
        }
    }
}

