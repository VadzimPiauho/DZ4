using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    class House
    {
        public Basement basement;
        public Walls[] walls;
        public Door door;
        public Window[] windows;
        public Roof roof;
        public House()
        {
            basement = null;
            walls = new Walls[4];
            door = null;
            windows = new Window[4];
            roof = null;
        }
        public Basement BASEMENT
        {
            get { return basement; }
            set { basement = value; }
        }
        public Walls[] WALLS
        {
            get { return walls; }
        }
        public Door DOOR
        {
            get { return door; }
            set { door = value; }
        }
        public Window[] WINDOWS
        {
            get { return windows; }
        }
        public Roof ROOF
        {
            get { return roof; }
            set { roof = value; }
        }
    }
}
