using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelWebApp.MongoModels;

namespace TravelWebApp.Services
{
    public class TravelService
    {
        private readonly IMongoCollection<Code> _codes;
        private readonly IMongoCollection<Country> _countries;
        private readonly IMongoCollection<Region> _regions;
        private readonly IMongoCollection<Settlement> _settlements;
        private readonly IMongoCollection<Station> _stations;

        public TravelService(ITravelDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _codes = database.GetCollection<Code>(settings.CodesCollectionName);
            _countries = database.GetCollection<Country>(settings.CountriesCollectionName);
            _regions = database.GetCollection<Region>(settings.RegionsCollectionName);
            _settlements = database.GetCollection<Settlement>(settings.SettlementsCollectionName);
            _stations = database.GetCollection<Station>(settings.StationsCollectionName);
        }

        public List<Code> GetCodes() =>
            _codes.Find(code => true).ToList();

        public List<Country> GetCountries() =>
            _countries.Find(country => true).ToList();

        public List<Region> GetRegions() =>
            _regions.Find(region => true).ToList();

        public List<Settlement> GetSettlements() =>
            _settlements.Find(settlement => true).ToList();

        public List<Station> GetStations() =>
            _stations.Find(station => true).ToList();


        public Code GetCode(string id) =>
            _codes.Find(code => code.Id == id).FirstOrDefault();

        public Country GetCountry(string id) =>
            _countries.Find(country => country.Id == id).FirstOrDefault();

        public Region GetRegion(string id) =>
            _regions.Find(region => region.Id == id).FirstOrDefault();

        public Settlement GetSettlement(string id) =>
            _settlements.Find(settlement => settlement.Id == id).FirstOrDefault();

        public Station GetStation(string id) =>
            _stations.Find(station => station.Id == id).FirstOrDefault();


        public Code CreateCode(Code code)
        {
            _codes.InsertOne(code);
            return code;
        }

        public Country CreateCountry(Country country)
        {
            _countries.InsertOne(country);
            return country;
        }

        public Region CreateRegion(Region region)
        {
            _regions.InsertOne(region);
            return region;
        }

        public Settlement CreateSettlement(Settlement settlement)
        {
            _settlements.InsertOne(settlement);
            return settlement;
        }

        public Station CreateStation(Station station)
        {
            _stations.InsertOne(station);
            return station;
        }
    }
}
