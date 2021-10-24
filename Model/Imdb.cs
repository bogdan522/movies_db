using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model.ImdbRatings
{
    [BsonIgnoreExtraElements]
    public class Imdb 
    {   [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("rating")]
        public double Rating { get; set; }
        [BsonElement("votes")]
        public int Votes { get; set; }

    }
    

    
}