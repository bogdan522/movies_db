using MongoDB.Bson.Serialization.Attributes;

namespace Model.MultipleRatings
{
    [BsonIgnoreExtraElements]
    public class Ratings
    {
        [BsonElement("rating")]
        public double Rating { get; set; }
        [BsonElement("numReviews")]
        public int NumberViews { get; set; }
        [BsonElement("meter")]
        public int Meter { get; set; }
    }
    
}