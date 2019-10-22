namespace CryptoMiningSystem.Core
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Engine : IEngine
    {
        private PCController controller;
        private bool isRunning;
        private StringBuilder stringBuilder;

        public Engine(PCController controller)
        {
            this.controller = controller;
            this.stringBuilder = new StringBuilder();
            this.isRunning = true;
        }

        public void Run()
        {
            while (this.isRunning)
            {
                List<string> commandArgs = this.SplitInput();

                string result = null;

                try
                {
                    result = this.ProcessCommand(commandArgs);
                }
                catch (ArgumentException ex)
                {
                    result = ex.Message;
                }

                this.stringBuilder.AppendLine(result);
            }

            Console.WriteLine(stringBuilder.ToString().Trim());
        }

        private string ProcessCommand(List<string> commandArgs)
        {
            string command = commandArgs[0];

            commandArgs.RemoveAt(0);

            string result = null;

            switch (command)
            {
                case "RegisterUser":
                    result = this.controller.RegisterUser(commandArgs);
                    break;
                case "CreateComputer":
                    result = this.controller.CreateComputer(commandArgs);
                    break;
                case "Mine":
                    result = this.controller.Mine();
                    break;
                case "UserInfo":
                    result = this.controller.UserInfo(commandArgs);
                    break;
                case "Shutdown":
                    result = this.controller.Shutdown();
                    this.isRunning = false;
                    break;
            }

            return result;
        }

        private List<string> SplitInput()
        {
            return Console.ReadLine().Split(',').ToList();
        }
    }
}
