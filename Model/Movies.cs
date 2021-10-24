using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Model.ImdbRatings;
using Model.TomatoesRatings;

namespace Model.Movies
{
    [BsonIgnoreExtraElements]
    public class Movies
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("plot")]
        public string Plot { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("year")]
        public int Year { get; set; }
        [BsonElement("imdb")]
        public Imdb Imdb { get; set; }
        [BsonElement("tomatoes")]
        public Tomatoes Tomatoes { get; set; }

         
    }
}