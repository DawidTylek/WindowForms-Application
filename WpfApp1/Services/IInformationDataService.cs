using System.Collections;
using System.Collections.Generic;
using WpfApp1.Models;

namespace WpfApp1.Services
{
    public interface IInformationDataService
    {
        IEnumerable<Schools> GetInformation();
        void Save(IEnumerable<Schools> information);
    }
}