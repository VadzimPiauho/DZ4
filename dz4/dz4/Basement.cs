using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    class Basement : IPart
    {
        public bool constructionStatus { get; set; }

        public Basement()
        {
            constructionStatus = true;
        }

        public void Construct()
        {
            Console.WriteLine("========");
        }
    }
}
