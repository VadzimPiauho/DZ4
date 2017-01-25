using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{

    class TeamLeader : IWorker
    {
        public string name { get; set; } = "Бригадир";

        public void Build(House house)
        {
            Console.WriteLine("Реализованные постройки: ");
            if (house.basement != null)
            {
                Console.WriteLine("Построен - ");
                house.BASEMENT.Construct();  
            }
            for (int i = 0; i < 4; i++)
            {
                if (house.walls[i] != null)
                {
                    Console.WriteLine($"Построенa - {i+1}");
                    house.WALLS[i].Construct();  
                }
            }
            if (house.door != null)
            {
                Console.WriteLine("Построена - ");
                house.DOOR.Construct();    
            }
            for (int i = 0; i < 4; i++)
            {
                if (house.windows[i] != null)
                {
                    Console.WriteLine($"Построено - {i+1}");
                    house.WINDOWS[i].Construct();      
                }
            }
            if (house.roof != null)
            {
                Console.WriteLine("Построена - ");
                house.ROOF.Construct(); 
            }
        }
    }
}
