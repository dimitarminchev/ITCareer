using CryptoMiningSystem.Entities.Components.VideoCards;
using System.Collections.Generic;

namespace CryptoMiningSystem.Factories
{
    public class VideoCardFactory
    {
        public static VideoCard CreateVideoCard(List<string> args)
        {
            string type = args[0];
            string model = args[1];
            int generation = int.Parse(args[2]);
            int ram = int.Parse(args[3]);
            decimal price = decimal.Parse(args[4]);

            VideoCard videoCard = null;

            if (type == "Game")
            {
                videoCard = new GameVideoCard(model, generation, ram, price);
            }
            else if (type == "Mine")
            {
                videoCard = new MineVideoCard(model, generation, ram, price);
            }

            return videoCard;
        }
    }
}