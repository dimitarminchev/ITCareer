using System;

namespace Task_6.Controllers
{
    class PoolController
    {
        private Display display;
        private Pool pool;
        public PoolController()
        {
            display = new Display();
            while (pool is null)
                try
                {
                    display.Input();
                    pool = new Pool(display.V, display.P1, display.P2, display.H);
                }
                catch (Exception e) { display.Response = e.Message; display.ShowResponse(); }
            display.Response = pool.Calculate();
            display.ShowResponse();
        }
    }
}
