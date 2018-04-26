using DbFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class InOut : IInOut
    {

        public void Output(IEnumerable<RestaurantInfo> restaurants)
        {
            foreach (var i in restaurants)
            {
                Console.WriteLine(i);
            }
        }
        public void Output(Dictionary<RestaurantInfo, double> restaurants)
        {
            foreach (var item in restaurants)
            {
                Console.WriteLine(item.Key.RestaurantName + " " + item.Value);
            }
        }
        public string ReadString()
        {
            return System.Console.ReadLine();
        }

        public double ReadDouble()
        {
            return Convert.ToDouble(System.Console.ReadLine());
        }

        public void Output(string value)
        {
            System.Console.WriteLine(value);
        }

        public int ReadInteger()
        {
            return Convert.ToInt32(System.Console.ReadLine());
        }       

        public void Output(IEnumerable<string> stringList)
        {
            foreach (var i in stringList)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
