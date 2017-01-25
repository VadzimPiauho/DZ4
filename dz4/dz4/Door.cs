using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    class Door : IPart
    {
        public bool constructionStatus { get; set; }
        public Door()
        {
            constructionStatus = true;
        }
        public void Construct()
        {
            throw new NotImplementedException();
        }
    }
}
