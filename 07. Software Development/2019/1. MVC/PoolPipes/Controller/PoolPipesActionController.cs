using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoolPipes.Model;
using PoolPipes.Views;

namespace PoolPipes.Controller
{
    class PoolPipesActionController
    {
        Pool pool;
        Display display;

        public PoolPipesActionController()
        {
            display = new Display();
            pool = new Pool
            (
                display.poolCapacity,
                display.pipe1,
                display.pipe2,
                display.hoursOfAbsence
            );
            display.result = pool.GetResult();
            display.PrintValues();
        }
    }
}
