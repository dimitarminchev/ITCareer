using System;
using Task06.Model;
using Task06.Views;

namespace Task06.Controllers
{
    public class PoolController
    {
        private Display display;
        private Pool pool;

        public PoolController()
        {
            display = new Display();
            while (pool is null)
            {
                try
                {
                    display.Input();
                    pool = new Pool(display.V, display.P1, display.P2, display.H);
                }
                catch (Exception e)
                {
                    display.Response = e.Message;
                    display.ShowResponse();
                }
            }
            display.Response = pool.Calculate();
            display.ShowResponse();
        }
    }
}
