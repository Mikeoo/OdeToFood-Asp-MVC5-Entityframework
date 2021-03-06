﻿using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Mike's Restaurant", Cuisine = CuisineType.French },
                new Restaurant{Id = 2, Name = "Dave's Restaurant", Cuisine = CuisineType.Italian },
                new Restaurant{Id = 3, Name = "Lionel's Restaurant", Cuisine = CuisineType.Indian },
                new Restaurant{Id = 4, Name = "Naceur's Restaurant", Cuisine = CuisineType.None }
            };
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
