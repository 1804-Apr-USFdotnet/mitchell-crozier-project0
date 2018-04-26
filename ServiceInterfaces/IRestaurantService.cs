﻿using DbFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public interface IRestaurantService
    {
        List<RestaurantInfo> GetAllRestaurantInfo();
        Dictionary<RestaurantInfo, double> TopThreeRatedRestaurants();

    }
}
