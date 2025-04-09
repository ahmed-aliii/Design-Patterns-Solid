using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class ModernBuilder : HouseBuilder
    {
        SwimmingPool pool;
        Garden garden;
        Jacosi jacosi;


        public void AddGarden()
        {
            garden = new Garden();
        }

        public void AddJacosi()
        {
            jacosi = new Jacosi();
        }

        public void AddPool()
        {
            pool = new SwimmingPool();
        }

        public House Build()
        {
            House house = new House
            {
                Garden = garden,
                Jacosi = jacosi,
                SwimmingPool = pool
            };
            return house;
        }
    }
}
