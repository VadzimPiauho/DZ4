using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    interface IWorker
    {
        string name { get; set; }
        void Build(House house);
    }
}
