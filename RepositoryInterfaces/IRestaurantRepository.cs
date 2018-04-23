using DbFirst;
using System.Collections.Generic;

namespace RepositoryInterfaces
{
    public interface IRestaurantRepository
    {
        IEnumerable<RestaurantInfo> getAll();
    }
}
