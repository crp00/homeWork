using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7.Task_3
{
    class Stove : ICook, IBake
    {
        private ICook _cook;
        private IBake _bake;

        public Stove(ICook cook, IBake bake)
        {
            _cook = cook;
            _bake = bake;
        }

        public void Bake()
        {
            _bake.Bake();
        }

        public void Cook()
        {
            _cook.Cook();
        }
    }
}
