using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Players;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private Queue<Gun> guns;
        private MainPlayer player;
        private List<CivilPlayer> civils;

        public Controller()
        {
            this.player = new MainPlayer();
            this.civils = new List<CivilPlayer>();
            this.guns = new Queue<Gun>();
        }

        public string AddGun(string type, string name)
        {
            if (type != "Rifle" && type != "Pistol")
            {
                return "Invalid gun type!";
            }
            if (type == "Rifle") guns.Enqueue(new Rifle(name));
            if (type == "Pistol") guns.Enqueue(new Pistol(name));
            return $"Successfully added {name} of type: {type}";
        }

        public string AddGunToPlayer(string name)
        {
            Gun gun = null;
            if(guns.Count == 0)
            {
                return "There are no guns in the queue!";
            }
            if (name == "Vercetti")
            {
                gun = this.guns.Dequeue();
                this.player.GunRepository.Add(gun);
                return $"Successfully added {name} to the Main Player: Tommy Vercetti";
            }
            if (civils.Count(x => x.Name == name) == 0)
            {
                return "Civil player with that name doesn't exists!";
            }
            var civil = civils.First(x => x.Name == name);
            gun = this.guns.Dequeue();
            civil.GunRepository.Add(gun);
            return $"Successfully added {gun.Name} to the Civil Player: {civil.Name}";
        }

        public string AddPlayer(string name)
        {
            this.civils.Add(new CivilPlayer(name));
            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            throw new NotImplementedException();
        }
    }
}
