

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TravelWebApp.MongoModels
{
    public class Code
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Esr_code { get; set; }
        
        public string Yandex_code { get; set; }
    }
}
