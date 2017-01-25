using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    class Window : IPart
    {
        public bool constructionStatus { get; set; }
        public Window()
        {
            constructionStatus = true;
        }
        public void Construct()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
}
