using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Application : IApplication
    {
        private IRestaurantService restaurantService;
        private ILoggingService loggingService;
        private bool isYouFinishedOrIsYouDone;

        public Application(IRestaurantService restaurantService, ILoggingService loggingService)
        {
            this.restaurantService = restaurantService;
            this.loggingService = loggingService;

        }

        public void Run()
        {
            while (!isYouFinishedOrIsYouDone)
            {
                int action = 0;
                Console.WriteLine($"\nWelcome to Restaurant Reviews, what would you like to do today?" +
                                    "\n1 - Add A Restaurant\n2 - View All Restaurants\n3 - Review A Restaurant" +
                                    "\n4 - View Top Three Rated Restaurants\n5 - View Restaurant Details" +
                                    "\n6 - All Reviews Of A Restaurant\n7 - Search\n8 - Quit");
                try
                {
                    action = Convert.ToInt32(System.Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input!");
                    loggingService.Log(ex);
                }


                switch (action)
                {
                    case 1:
                        // AddRestaurant();
                        break;
                    case 2:
                        ViewAllRestaurants();
                        break;
                    case 3:
                        // ReviewRestaurant();
                        break;
                    case 4:
                        // TopThreeRatedRestaurants();
                        break;
                    case 5:
                        //ViewRestaurantDetails();
                        break;
                    case 6:
                        //AllReviewsOfARestaurant();
                        break;
                    case 7:
                        //Search();
                        break;
                    case 8:
                        //Quit();
                        break;
                    default:
                        Console.WriteLine("\nThat is not an option!\n");
                        Run();
                        break;
                }
            }
        }

                private void ViewAllRestaurants()
                {
                    Console.WriteLine("\nAll Restaurants:\n");

                    var results = restaurantService.GetAllRestaurantInfo();

                    var restaurantList = results.Select(x => x.RestaurantName);

                    Console.WriteLine(restaurantList);
                }



            }
        }
    
