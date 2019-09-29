using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Storage;

namespace StorageMaster
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cmd = System.Console.ReadLine().Split().ToArray();
            StorageMaster.Storage.StorageMaster storageMaster = new Storage.StorageMaster();
            List<string> names = new List<string>();
            while(cmd[0]!="END")
            {
                string result = string.Empty;
                try
                {
                    switch (cmd[0])
                    {
                        case "AddProduct": result = storageMaster.AddProduct(cmd[1], double.Parse(cmd[2])); break;
                        case "RegisterStorage": result = storageMaster.RegisterStorage(cmd[1], cmd[2]); break;
                        case "SelectVehicle": result = storageMaster.SelectVehicle(cmd[1], int.Parse(cmd[2])); break;
                        case "LoadVehicle":  names.AddRange(cmd); names.Remove(names.First());  result = storageMaster.LoadVehicle(names);names = new List<string>(); break;
                        case "SendVehicleTo": result = storageMaster.SendVehicleTo(cmd[1], int.Parse(cmd[2]), cmd[3]); break;
                        case "UnloadVehicle": result = storageMaster.UnloadVehicle(cmd[1], int.Parse(cmd[2])); break;
                        case "GetStorageStatus": result = storageMaster.GetSummary(); break;
                        default: Console.WriteLine("mnoo jestoko gramna :("); break;
                    }
                    Console.WriteLine(result);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
                cmd = System.Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(storageMaster.GetSummary());
        }
    }
}
