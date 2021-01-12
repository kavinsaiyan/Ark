using Ark.Model.NavigationMenu;
using Ark.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ark.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<NavigationItem> NavItems { get; set; }

        public MainWindowViewModel()
        {
            NavItems = new ObservableCollection<NavigationItem>();

            NavItems.Add(new NavigationItem("pack://application:,,,/Resources/Images/Music_Light.png", new SongLibrary()));
            NavItems.Add(new NavigationItem("pack://application:,,,/Resources/Images/Bible_Light.png", new Bible()));
            NavItems.Add(new NavigationItem("pack://application:,,,/Resources/Images/Table_Light.png", new Table()));

        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
