using Esport.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Persistence.CRUD.DataTransferObject
{
    public class TitleVideoGame : ITitleVideoGame
    {
        public string Title { get; set; }
        public TitleVideoGame(string Title)
        {
            this.Title = Title;
        }
    }
}
