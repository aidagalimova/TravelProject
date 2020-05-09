using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.MongoModels
{
    public class Region
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public List<Settlement> Settlements { get; set; }

        public List<Code> Codes { get; set; }

        public string Title { get; set; }
    }
}
