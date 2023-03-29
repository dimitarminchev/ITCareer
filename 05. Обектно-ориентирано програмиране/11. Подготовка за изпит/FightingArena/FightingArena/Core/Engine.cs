namespace HeroFight.Core
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Engine : IEngine
    {
        private ArenaController arenaController;
        private StringBuilder resultString;
        private bool isRunning;

        public Engine(ArenaController arenaController)
        {
            this.arenaController = arenaController;
            this.resultString = new StringBuilder();
            this.isRunning = true;
        }

        public void Run()
        {
            while (isRunning)
            {
                List<string> commandArgs = Console.ReadLine().Split(':').ToList();

                string command = commandArgs[0];

                commandArgs.RemoveAt(0);

                string result = "";

                try
                {
                    if (command == "CreateHero")
                    {
                        result = arenaController.CreateHero(commandArgs);
                    }
                    else if (command == "CreateWeapon")
                    {
                        result = arenaController.CreateWeapon(commandArgs);
                    }
                    else if (command == "Fight")
                    {
                        result = arenaController.Fight(commandArgs);
                    }
                    else if (command == "HeroInfo")
                    {
                        result = arenaController.HeroInfo(commandArgs);
                    }
                    else if (command == "CloseArena")
                    {
                        result = arenaController.CloseArena();
                        isRunning = false;
                    }
                }
                catch (ArgumentException ex)
                {
                    result = ex.Message;
                }

                resultString.AppendLine(result);
            }

            Console.WriteLine(resultString.ToString().Trim());
        }
    }
}