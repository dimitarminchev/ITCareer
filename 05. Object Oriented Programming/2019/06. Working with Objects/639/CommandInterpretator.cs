using _369.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _369.Core
{
    class CommandInterpretator : ICommandInterpreter
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpretator(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        IExecutable ICommandInterpreter.InterpretCommand(string[] data, string commandName)
        {
            string result = string.Empty;
            Assembly assembly = Assembly.GetCallingAssembly();
            Type commandType = assembly.GetTypes().FirstOrDefault(type => type.Name.ToLower() == commandName + "command");
            if (commandType == null)
            {
                throw new ArgumentException("Invalid Command");
            }

            if (!typeof(IExecutable).IsAssignableFrom(commandType))
            {
                throw new ArgumentException($"{commandName} Is Not A Command");
            }

            object[] constrArgs = new object[] { data, this.repository, this.unitFactory };
            IExecutable instance =(IExecutable) Activator.CreateInstance(commandType, constrArgs);
            MethodInfo method = typeof(IExecutable).GetMethods().First();

            return instance;
        }
    }
}
