using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    class Worker: IWorker

    {
        public Worker() { }
        public string name { get; set; }
        public void Build(House house)
        {
            if (house.basement==null)
            {
                house.BASEMENT = new Basement();
                house.BASEMENT.Construct();
               return;
            }
            for (int i = 0; i < 4; i++)
            {
                if (house.walls[i] == null)
                {
                    house.WALLS[i] = new Walls();
                    house.WALLS[i].Construct();
                    return;
                } 
            }
            if (house.door == null)
            {
                house.DOOR = new Door();
                house.DOOR.Construct();
                return;
            }   
            for (int i = 0; i < 4; i++)
            {
                if (house.windows[i] == null)
                {
                    house.WINDOWS[i] = new Window();
                    house.WINDOWS[i].Construct();
                    return;
                }
            }
            if (house.roof == null)
            {
                house.ROOF = new Roof();
                house.ROOF.Construct();
            }     
        }
    }
}
