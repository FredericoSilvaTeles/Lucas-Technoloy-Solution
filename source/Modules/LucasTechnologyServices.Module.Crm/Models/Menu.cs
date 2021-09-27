using LucasTechnologyService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Crm.Models
{
    public class Menu : EntityBase
    {
        public Menu(long id,string name, DateTime createDate, DateTime lastUpdateDate, bool isPublished, bool isSystem, IList<MenuItem> menuItems)
        {

            Id = id;
            Name = name;
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            IsPublished = true;
            IsSystem = true;
            MenuItems = new List<MenuItem>();
        }

        public string Name { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public bool IsPublished { get; private set; }
        public bool IsSystem { get; private set; }
        public IList<MenuItem> MenuItems { get; private set; }
    }
}
