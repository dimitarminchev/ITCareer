namespace _369.Core
{
    using System;
    using Contracts;
    using System.Reflection;
    using System.Linq;

    class Engine : IRunnable
    {
        private ICommandInterpreter commandInterpreter;
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    IExecutable command = commandInterpreter.InterpretCommand(data, commandName);


                    MethodInfo method = typeof(IExecutable).GetMethods().First();

                    try
                    {
                        string result = (string)method.Invoke(command, null);
                        Console.WriteLine(result);
                    }
                    catch(TargetInvocationException e)
                    {
                        throw e.InnerException;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        
    }
}
