﻿using DbFirst;
using Operations;
using RepositoryInterfaces;
using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RestaurantService : IRestaurantService
    {
        private IRestaurantRepository restaurantRepository;
        private IReviewerRepository reviewerRepository;

        public RestaurantService(IRestaurantRepository repository, IReviewerRepository reviewRepository)
        {
            restaurantRepository = repository;
            reviewerRepository = reviewRepository;
        }
        public List<RestaurantInfo> GetAllRestaurantInfo()
        {
            Console.WriteLine(restaurantRepository.getAll());
            return restaurantRepository.getAll().ToList();
        }

        public Dictionary<RestaurantInfo, double> TopThreeRatedRestaurants()
        {
            var restaurants = restaurantRepository.getAll();
            var reviews = reviewerRepository.getAll();
            var query = new TopThreeQuery();
            var results =  query.GetTopThreeRated(restaurants, reviews);
            
            return results;
        }
    }

    
}
