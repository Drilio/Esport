using Esport.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Esport.Back.Domain
{
    internal class EGame
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }

        public EGame(int Id, string Description, string Title, string Category) {
            this.Id = Id;
            this.Description = Description;
            this.Title = Title;
            this.Category = Category;
        }

    }
}
