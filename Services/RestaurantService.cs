using DbFirst;
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

        public RestaurantService(IRestaurantRepository repository)
        {
            restaurantRepository = repository;
        }
        public List<RestaurantInfo> GetAllRestaurantInfo()
        {
            return restaurantRepository.getAll().ToList();
        }
    }
}
