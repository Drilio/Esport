using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Interface
{
    public interface IVideoGame
    {
        string Id { get; set; }
        string Category { get; set; }
        string Title { get; set; }
        string Description { get; set; }
    }

    public interface ITitleVideoGame
    {
        string Title { get; set; }
    }
}
