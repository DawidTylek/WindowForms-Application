using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class InformationViewModel : MartialArtsApp2
    {
        private Schools _selectedSchools;
        public Schools SelectedSchools
        {
            get { return _selectedSchools; }
            set { OnPropertyChanged(ref _selectedSchools, value); }
        }
        
        public ObservableCollection<Schools> Schools{ get; private set; }

        public InformationViewModel()
        {
            
        }

        public void LoadSchools(IEnumerable<Schools> schools)
        {
            Schools = new ObservableCollection<Schools>(schools);
            OnPropertyChanged("Schools");
        }
    }
}