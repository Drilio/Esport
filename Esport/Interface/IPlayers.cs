using Esport.Front.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Interface
{
    public interface IPlayers
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        Team Team { get; set; }
        Statistic Stats { get; set; }
    }

    public interface ISelectedPlayer : IPlayers
    {
        bool IsSelected { get; set; }
    }

    public interface ITeam
    {
        string Name { get; set; }
    }

}
