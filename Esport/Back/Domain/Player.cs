using Android.Hardware.Camera2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Domain
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public Team Team{ get; set; }
        public Statistics Statistics { get; set; }
    }
}
