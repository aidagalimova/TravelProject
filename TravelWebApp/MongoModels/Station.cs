using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.MongoModels
{
    public class Station
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Direction { get; set; }

        public List<Code> Codes { get; set; }

        public string Station_type { get; set; }

        public string Title { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }

        public string Transport_type { get; set; }
    }
}
