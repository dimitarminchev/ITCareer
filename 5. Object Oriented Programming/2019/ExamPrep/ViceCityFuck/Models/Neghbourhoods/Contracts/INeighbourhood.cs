using ViceCity.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Neghbourhoods.Contracts
{
    public interface INeighbourhood
    {
        void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers);
    }
}
