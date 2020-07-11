using System.Windows.Input;

namespace WpfApp1.ViewModels
{
    public class MaArtViewModel : MartialArtsApp2
    {
        private InformationViewModel _informationVM;
        public InformationViewModel InformationVm
        {
            get { return _informationVM; }
            set { OnPropertyChanged(ref _informationVM, value); }
        }
        
        public ICommand LoadInformationCommand { get; private set; }
        public ICommand LoadFavouritesCommand { get; private set; }

        public MaArtViewModel()
        {
            InformationVm = new InformationViewModel();

            LoadInformationCommand = new RoutedCommand(LoadInforamtions);
            LoadFavouritesCommand = new RoutedCommand(LoadFavourite);
        }

        private void LoadInforamtions()
        {
            
        }

        private void LoadFavourite()
        {
            
        }
    }
}