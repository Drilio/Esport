using Esport.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Service.CRUD.DataTransferObject
{
    public class TitleGame : ITitleGame
    {
        public string Title { get; set; }
        public TitleGame(string Title) 
        {
            this.Title = Title;
        }
    }
}
