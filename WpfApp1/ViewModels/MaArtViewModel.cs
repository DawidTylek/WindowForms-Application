using System.Linq;
using System.Windows.Input;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    public class MaArtViewModel : MartialArtsApp2
    {
        private IInformationDataService _service;
            
        private InformationViewModel _informationVM;
        public InformationViewModel InformationVm
        {
            get { return _informationVM; }
            set { OnPropertyChanged(ref _informationVM, value); }
        }
        
        public ICommand LoadInformationCommand { get; private set; }
        public ICommand LoadFavouritesCommand { get; private set; }

        public MaArtViewModel(IInformationDataService service)
        {
            InformationVm = new InformationViewModel();

            _service = service;

            LoadInformationCommand = new MartialArtsApp(LoadInforamtions);
            LoadFavouritesCommand = new MartialArtsApp(LoadFavourite);
        }

        private void LoadInforamtions()
        {
            InformationVm.LoadSchools(_service.GetInformation());
        }

        private void LoadFavourite()
        {
            var favourites = _service.GetInformation().Where(c => c.IsFavourite);
            InformationVm.LoadSchools(favourites);
        }
    }
}