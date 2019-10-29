using ViceCity.Core.Contracts;
using System;
using ViceCity.IO.Contracts;
using ViceCity.IO;

namespace ViceCity.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private Controller controller;

        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();
            this.controller = new Controller();
        }
        public void Run()
        {
            while (true)
            {
                var input = reader.ReadLine().Split();
                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }
                try
                {
                    if (input[0] == "AddPlayer")
                    {
                        Console.WriteLine(controller.AddPlayer(input[1]));
                    }
                    else if (input[0] == "AddGun")
                    {
                        Console.WriteLine(controller.AddGun(input[1], input[2]));
                    }
                    else if (input[0] == "AddGunToPlayer")
                    {
                        Console.WriteLine(controller.AddGunToPlayer(input[1]));
                    }
                    else if (input[0] == "Fight")
                    {
                        Console.WriteLine(controller.Fight());
                    }            
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
