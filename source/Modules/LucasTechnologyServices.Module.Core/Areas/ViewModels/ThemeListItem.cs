using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Areas.ViewModels
{
    public class ThemeListItem
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ThumbmailUrl { get; set; }
        public bool IsCurrentMyProperty { get; set; }
        public bool IsCurrent { get; internal set; }
        public string ThumbnailUrl { get; internal set; }
    }
}
