using Ark.ViewModel;
using System.Windows.Controls;

namespace Ark.View
{

    public partial class SongLibrary : UserControl
    {

        private SongLibraryViewModel _viewModel;

        public SongLibrary()
        {
            _viewModel = new SongLibraryViewModel();
            DataContext = _viewModel;
            InitializeComponent();
        }
    }
}
