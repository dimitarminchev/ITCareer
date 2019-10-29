using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    public interface IReader
    {
        string ReadLine();
    }

    public interface IWriter
    {
        void WriteLine(string message);
    }

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Engine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            var cmd = reader.ReadLine().Split().ToArray();
            StorageMaster.Storage.StorageMaster storageMaster = new Storage.StorageMaster();
            while (cmd[0] != "END")
            {
                string result = string.Empty;
                try
                {
                    switch (cmd[0])
                    {
                        case "AddProduct": result = storageMaster.AddProduct(cmd[1], double.Parse(cmd[2])); break;
                        case "RegisterStorage": result = storageMaster.RegisterStorage(cmd[1], cmd[2]); break;
                        case "SelectVehicle": result = storageMaster.SelectVehicle(cmd[1], int.Parse(cmd[2])); break;
                        case "LoadVehicle":   result = storageMaster.LoadVehicle(cmd.Where(x => x != "LoadVehicle").ToList());break;
                        case "SendVehicleTo": result = storageMaster.SendVehicleTo(cmd[1], int.Parse(cmd[2]), cmd[3]); break;
                        case "UnloadVehicle": result = storageMaster.UnloadVehicle(cmd[1], int.Parse(cmd[2])); break;
                        case "GetStorageStatus": result = storageMaster.GetStorageStatus(cmd[1]); break;
                        default: writer.WriteLine("Don't panic!"); break;
                    }
                    writer.WriteLine(result);
                }
                catch (Exception e)
                {
                    writer.WriteLine($"Error: {e.Message}");
                }
                cmd = reader.ReadLine().Split().ToArray();
            }
            writer.WriteLine(storageMaster.GetSummary());
        }
    }
}
