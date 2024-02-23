using Esport.Interface;
using Esport.Back.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esport.Front.Model;

namespace Esport.Back.Persistence.CRUD.DataTransferObject
{
    class DTOPlayer : IPlayers
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int TeamId { get; set; }

        public DTOPlayer(int id,string name, string username,int teamid)
        {
            this.Id = id;
            this.Name = name;
            this.Username = username;
            this.TeamId = teamid;
        }

    }
}
