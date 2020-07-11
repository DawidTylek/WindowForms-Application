using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using WpfApp1.Models;

namespace WpfApp1.Services
{
    public class MockDataService : IInformationDataService
    {
        private IEnumerable<Schools> _schools;

        public MockDataService()
        {
            _schools = new List<Schools>()
            {
                new Schools
                {
                    Name = "Seiken",
                    SchoolAdress = new string[]
                    {
                        "Al.Jana Pawła II 232",
                        "31-913 Krakow"
                    },
                    SchoolNumber = new string[]
                    {
                        "12-644-02-66",
                        "567-534-636"
                    },
                    SchoolEmail = new string[]
                    {
                        "Seiken.krk@onet.com",
                        "Seiken.Main@gmail.com"
                    }
                },
                new Schools
                {
                Name = "Hajime",
                SchoolAdress = new string[]
                {
                    "ul.Podwale 4",
                    "22-545 Warszawa"
                },
                SchoolNumber = new string[]
                {
                    "12-777-55-44",
                    "765-495-434"
                },
                SchoolEmail = new string[]
                {
                    "Hajime.main@wp.com",
                    "Hajime.application@gmail.com"
                }
            }
            };
        }
        public IEnumerable<Schools> GetInformation()
        {
            return _schools;
        }

        public void Save(IEnumerable<Schools> information)
        {
            _schools = information;
        }
    }
}