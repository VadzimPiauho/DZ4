using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    class Walls : IPart
    {
        public bool constructionStatus { get; set; }
        public Walls()
        {
            constructionStatus = true;
        }
        public void Construct()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
}