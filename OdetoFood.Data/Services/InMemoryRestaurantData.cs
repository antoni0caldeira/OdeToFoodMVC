using OdetoFood.Data.Models;
using System;
using System.Collections.Generic;

namespace OdetoFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Pizza", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Nona", Cuisine = CuisineType.French},
                new Restaurant { Id = 3, Name = "Forzza", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 4, Name = "Deli", Cuisine = CuisineType.Indian}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants;
        }
    }
}
