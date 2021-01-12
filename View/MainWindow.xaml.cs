using Ark.ViewModel;
using System.Windows;

namespace Ark
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            MainMenu.SelectedItem = 0;
        }

    }
}