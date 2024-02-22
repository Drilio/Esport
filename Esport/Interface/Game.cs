using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Interface
{
    public interface IGame
    {
        string Id { get; set; }
        string Category { get; set; }
        string Title { get; set; }
        string Description { get; set; }
    }

    public interface ITitleGame
    {
        string Title { get; set; }
    }
}
