using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Model.Movies;
using MongoDB.Bson;
using MongoDB.Driver;
using Model.ImdbRatings;

namespace Controllers.MoviesControllers
{
    [ApiController]
    [Route("controller")]
    public class MoviesControllers : ControllerBase
    {
        private IMongoCollection<Movies> movieCollection;

        public MoviesControllers(IMongoClient client)
        {
            var database = client.GetDatabase("sample_mflix");
            movieCollection = database.GetCollection<Movies>("movies");   
        }
        

        [HttpGet("time_period")]
        public IEnumerable<Movies> GetTimePeriod(int startYear, int endYear)
        {         
            return movieCollection.Find(q => q.Year <= endYear && q.Year >= startYear).ToList();
        }

        [HttpGet("title")]
        public IEnumerable<Movies> GetTitle(string title)
        {
            return movieCollection.Find(q => q.Title.ToLower().Contains(title.ToLower())).ToList();
        }

        [HttpGet("rating")]

        public IEnumerable<Movies> GetRating(double rating)
        {
            return movieCollection.Find(q => q.Imdb.Rating == rating).ToList();
        }
    }
}