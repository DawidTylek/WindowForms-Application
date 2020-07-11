using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
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

        private bool _isEditMode;
        public bool IsEditMode
        {
            get { return _isEditMode; }
            set { OnPropertyChanged(ref _isEditMode, value);
                OnPropertyChanged("IsDisplayMode");
            }
        }

        public bool IsDisplayMode
        {
            get { return !_isEditMode;  }
        }

        public ObservableCollection<Schools> Schools{ get; private set; }

        public ICommand EditCommand { get; private set; }
        
        public InformationViewModel()
        {
            EditCommand = new MartialArtsApp(Edit, CanEdit);
        }

        private bool CanEdit()
        {
            if (SelectedSchools == null)
                return false;

            return !IsEditMode;
        }

        private void Edit()
        {
            IsEditMode = true;
        }

        public void LoadSchools(IEnumerable<Schools> schools)
        {
            Schools = new ObservableCollection<Schools>(schools);
            OnPropertyChanged("Schools");
        }
    }
}