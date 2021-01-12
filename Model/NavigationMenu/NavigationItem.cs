using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Ark.Model.NavigationMenu
{
    public class NavigationItem
    {
        public string IconPath { get; set; }
        public UserControl UserControl { get; set; }

        public NavigationItem(string iconPath, UserControl userControl)
        {
            IconPath = iconPath;
            UserControl = userControl;
        }
    }
}
