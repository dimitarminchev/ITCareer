using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            // Take the First Gun
            var playerGun = mainPlayer.GunRepository.Models.FirstOrDefault();

            // Shooting
            foreach (var civilPlayer in civilPlayers)
            {
                while (civilPlayer.IsAlive && mainPlayer.IsAlive)
                {
                    // 1. Main Player Shooting the Civil
                    if (playerGun != null)
                    {
                        // Shot
                        if (playerGun.CanFire)
                        {
                            (civilPlayer as CivilPlayer).LifePoints -= playerGun.Fire();
                        }
                        // Change Gun
                        else
                        {
                            mainPlayer.GunRepository.Remove(playerGun);
                            playerGun = mainPlayer.GunRepository.Models.FirstOrDefault();
                        }
                    }

                    // 2. Civil Shooting the Main Playher
                    var civilGun = civilPlayer.GunRepository.Models.FirstOrDefault();
                    if (civilGun != null) 
                    {
                        // Shot
                        if (civilGun.CanFire)
                        {
                            (mainPlayer as MainPlayer).LifePoints -= civilGun.Fire();
                        }
                        // Change Gun
                        else
                        {
                            civilPlayer.GunRepository.Remove(civilGun);
                            civilGun = civilPlayer.GunRepository.Models.FirstOrDefault();
                        }
                    }

                    // Game Over
                    if (mainPlayer.IsAlive == false)
                    {
                        return;
                    }
                }               
            }

        }
    }
}
