using WpfApp1.Services;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    public class AppViewModel : MartialArtsApp2
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { OnPropertyChanged(ref _currentView, value); }
        }
 
        private MaArtViewModel _MartialVM;
        public MaArtViewModel MartialVM
        {
            get { return _MartialVM; }
            set { OnPropertyChanged(ref _MartialVM, value); }
        }
 
        public AppViewModel()
        {
            var dataService = new MockDataService();
            
            MartialVM = new MaArtViewModel(dataService);
            CurrentView = MartialVM;
        }
    }
}