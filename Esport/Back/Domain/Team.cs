﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Domain
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Player> Players { get; set; }

        public List<StatByEntities> Statistics { get; set; }

        public List<Party> Parties { get; set; }

        public List<Statistic> Results { get; set; }

    }
}