using Operations;
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
        private IReviewService reviewService;
        private ILoggingService loggingService;
        private IQueries queries;
        private bool isYouFinishedOrIsYouDone;
        private IInOut inOut;

        public Application(IRestaurantService restaurantService, IReviewService reviewService, ILoggingService loggingService, IInOut inOut)
        {
            this.restaurantService = restaurantService;
            this.reviewService = reviewService;
            this.loggingService = loggingService;
            this.inOut = inOut;

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
                        TopThreeRatedRestaurants();
                        break;
                    case 5:
                        //ViewRestaurantDetails();
                        break;
                    case 6:
                        //AllReviewsOfARestaurant();
                        break;
                    case 7:
                        Search();
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
                    Console.WriteLine("results are : " + results);
                    var restaurantList = results.Select(x => x.RestaurantName);

                    inOut.Output(restaurantList);
                }
        private void TopThreeRatedRestaurants()
        {
            Console.WriteLine("Top three rated \n");
            var results = restaurantService.TopThreeRatedRestaurants();
            inOut.Output(results);
        }

        private void Search()
        {
            Console.WriteLine("Search for a restaurant \n");
            string name = Console.ReadLine();
            var results = restaurantService.SearchByName(name);
            inOut.Output(results);
        }
                



            }
        }
    
