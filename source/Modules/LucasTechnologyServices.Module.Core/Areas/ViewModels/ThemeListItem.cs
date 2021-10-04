using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Areas.ViewModels
{
    public class ThemeListItem
    {
        public string Name { get; private set; }
        public string DisplayName { get; private set; }
        public string ThumbmailUrl { get; private set; }
        public bool IsCurrentMyProperty { get; private set; }
    }
}
