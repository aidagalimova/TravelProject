using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.MongoModels
{
    public class TravelDatabaseSettings : ITravelDatabaseSettings
    {
        public string CodesCollectionName { get; set; }
        public string CountriesCollectionName { get; set; }
        public string RegionsCollectionName { get; set; }
        public string SettlementsCollectionName { get; set; }
        public string StationsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ITravelDatabaseSettings
    {
        string CodesCollectionName { get; set; }
        string CountriesCollectionName { get; set; }
        string RegionsCollectionName { get; set; }
        string SettlementsCollectionName { get; set; }
        string StationsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
