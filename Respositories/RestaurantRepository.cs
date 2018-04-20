using RepositoryInterfaces;
using DbFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private ProjectZeroDbContext context;

        public RestaurantRepository(ProjectZeroDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<RestaurantInfo> getAll()
        {
            return context.RestaurantInfos;
        }
    }
}
