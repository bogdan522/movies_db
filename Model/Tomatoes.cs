using Model.MultipleRatings;
using MongoDB.Bson.Serialization.Attributes;

namespace Model.TomatoesRatings
{
    [BsonIgnoreExtraElements]
    public class Tomatoes
    {
        [BsonElement("viewer")]
        public Ratings Viewer { get; set; }
        [BsonElement("critic")]
        public Ratings Critic { get; set; }
    }
    
}