namespace CryptoMiningSystem.Core
{
    using Contracts;
    using CryptoMiningSystem.Entities;
    using CryptoMiningSystem.Entities.Components.Processors;
    using CryptoMiningSystem.Entities.Components.VideoCards;
    using CryptoMiningSystem.Factories;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PCController :  IPCController
    {
        private const int HoursToMine = 24;

        private Dictionary<string, User> users;
        private decimal totalMinedMoney;

        public PCController()
        {
            this.users = new Dictionary<string, User>();
        }

        public string RegisterUser(List<string> args)
        {
            string name = args[0];
            decimal money = decimal.Parse(args[1]);

            if (!this.users.ContainsKey(name))
            {
                User user = new User(name, money);

                this.users.Add(name, user);

                return $"Successfully registered user - {name}!";
            }

            return $"Username: {name} already exists!";
        }

        public string CreateComputer(List<string> args)
        {
            string userName = args[0];

            args.RemoveAt(0);

            if (!this.users.ContainsKey(userName))
            {
                return $"Username: {userName} does not exist!";
            }

            User user = this.users[userName];

            Processor processor = ProcerssorFactory.CreateProcessor(args.Take(4).ToList());

            if (processor == null)
            {
                return "Invalid type processor!";
            }

            VideoCard videoCard = VideoCardFactory.CreateVideoCard(args.Skip(4).Take(5).ToList());

            if (videoCard == null)
            {
                return "Invalid type video card!";
            }

            int ram = int.Parse(args[args.Count - 1]);

            Computer computer = new Computer(processor, videoCard, ram);

            decimal computerCosts = computer.Processor.Price + computer.VideoCard.Price;

            if (user.Money >= computerCosts)
            {
                user.Computer = computer;
                user.Money -= computerCosts;

                return $"Successfully created computer for user: {userName}!";
            }

            return $"User: {user.Name} - insufficient funds!";
        }

        public string Mine()
        {
            List<User> usersToMine = this.users.Values
                .Where(x => x.Computer != null
                && x.Computer.Processor.LifeWorkingHours >= HoursToMine
                && x.Computer.VideoCard.LifeWorkingHours >= HoursToMine)
                .ToList();

            decimal dailyMinedMoney = 0;

            foreach (var user in usersToMine)
            {
                decimal result = user.Computer.MinedAmountPerHour * HoursToMine;
                user.Computer.Processor.LifeWorkingHours -= HoursToMine;
                user.Computer.VideoCard.LifeWorkingHours -= HoursToMine;
                user.Money += result;
                dailyMinedMoney += result;
            }

            this.totalMinedMoney += dailyMinedMoney;

            return $"Daily profits: {dailyMinedMoney}!";
        }

        public string UserInfo(List<string> args)
        {
            string name = args[0];

            if (!this.users.ContainsKey(name))
            {
                return $"Username: {name} does not exist!";
            }

            User user = this.users[name];

            return user.ToString();
        }

        public string Shutdown()
        {
            StringBuilder stringBuilder = new StringBuilder();

            List<User> orderedUsers = this.users.Values
                .OrderByDescending(x => x.Stars)
                .ThenBy(x => x.Name)
                .ToList();

            orderedUsers
                .ForEach(x => stringBuilder.AppendLine(x.ToString()));

            stringBuilder.AppendLine($"System total profits: {totalMinedMoney}!!!");

            return stringBuilder.ToString().Trim();
        }
    }
}
