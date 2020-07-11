namespace WpfApp1.Models
{
    public class Schools : MartialArtsApp2
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { OnPropertyChanged(ref _name, value); }
        }

        private string[] _schoolAdress;

        public string[] SchoolAdress
        {
            get { return _schoolAdress; }
            set { OnPropertyChanged(ref _schoolAdress, value); }
        }

        private string[] _schoolEmail; 
        public string[] SchoolEmail
        {
            get { return _schoolAdress; }
            set { OnPropertyChanged(ref _schoolEmail, value); }
        }

        private string[] _schoolNumber;

        public string[] SchoolNumber
        {
            get { return _schoolNumber; }
            set { OnPropertyChanged(ref _schoolNumber, value); }
        }

        private bool _isFavourite;
        public bool IsFavourite
        {
            get { return _isFavourite; }
            set { OnPropertyChanged(ref _isFavourite, value); }
        }

        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set { OnPropertyChanged(ref _imagePath, value); }
        }
    }
}