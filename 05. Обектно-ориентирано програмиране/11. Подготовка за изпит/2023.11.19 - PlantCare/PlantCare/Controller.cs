using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Controller
{
    private readonly Dictionary<int, Plant> plants;
    public Controller()
    {
        plants = new Dictionary<int, Plant>();
    }
    public string AddCareItem(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        if (plants.TryGetValue(plantId, out Plant plant))
        {
            string name = args[1];
            bool status = bool.Parse(args[2]);
            CareItem careItem = new CareItem(name, status);
            plant.AddCareItem(careItem);
            return $"Created Care {name} for {plantId}!";
        }
        else
        {
            return "Plant not found!";
        }
    }

    public string AddPlant(List<string> args)
    {
        int id = int.Parse(args[0]);
        if (plants.ContainsKey(id))
        {
            return $"Plant with ID {id} already exists!";
        }
        string name = args[1];
        double humidityLevel = double.Parse(args[2]);
        double fertilityLevel = double.Parse(args[3]);
        string type = args[4];
        Plant plant;
        if (type == "flower")
        {
            string color = args[5];
            plant = new FloweringPlant(id, name, humidityLevel, fertilityLevel, color);
        }
        else if (type == "tree")
        {
            int height = int.Parse(args[5]);
            plant = new TreePlant(id, name, humidityLevel, fertilityLevel, height);
        }
        else
        {            
            return "Invalid plant type!";
        }

        plants.Add(id, plant);
        return $"Created Plant {name} with ID {id}!";
    }

    public string GetTotalCaresByPlantId(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        if (plants.TryGetValue(plantId, out Plant plant))
        {
            int totalCares = plant.TotalCaresDone();
            return $"Total cares for plant {plantId}: {totalCares}";
        }
        else
        {
            return "Plant not found!";
        }
    }

    public string WaterPlantById(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        double percent = double.Parse(args[1]);

        if (plants.TryGetValue(plantId, out Plant plant))
        {
            bool result = plant.Water(percent);
            if (result)
            {
                return $"Plant {plantId} was watered successfully!";
            }
            else
            {
                return $"Plant {plantId} could not be watered!";
            }
        }
        else
        {
            return "Plant not found!";
        }
    }

    public string FertilizePlantById(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        double percent = double.Parse(args[1]);

        if (plants.TryGetValue(plantId, out Plant plant))
        {
            bool result = plant.Fertilize(percent);
            if (result)
            {
                return $"Plant {plantId} was fertilized successfully!";
            }
            else
            {
                return $"Plant {plantId} could not be fertilized!";
            }
        }
        else
        {
            return "Plant not found!";
        }
    }

    public string GetTallestTree(List<string> args)
    {
        var trees = plants.Values.OfType<TreePlant>().ToList();

        if (trees.Count > 0)
        {
            var tallestTree = trees.OrderByDescending(t => t.Height).First();
            return tallestTree.ToString();
        }
        else
        {
            return "No trees found!";
        }
    }

}