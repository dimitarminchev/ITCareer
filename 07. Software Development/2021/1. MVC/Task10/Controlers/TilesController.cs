using System;
using Task10.Models;
using Task10.Views;

namespace Task10.Controlers
{
    public class TilesController
    {
        private Display display;
        private Tiles tiles;

        public TilesController()
        {
            display = new Display();
            while (tiles is null)
            {
                try
                {
                    display.Input();
                    tiles = new Tiles(display.N, display.W, display.L, display.M, display.O);
                }
                catch (Exception e)
                {
                    display.Response = e.Message;
                    display.ShowResponse();
                }
            }
            display.Response = tiles.Calculate();
            display.ShowResponse();
        }
    }
}
