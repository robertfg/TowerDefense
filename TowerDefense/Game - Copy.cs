using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Game1
    {
        public static void Main1()
        {
            // Instantiate Tower object
            //Tower tower = new Tower();

            Map map = new Map(8, 5);

            //map.Width = 8;
            // Can't access private variable, Height
            //map.Height = 10;

            //int area = map.Width * map.Height;

            //Point point = new Point(4, 2);
            //bool isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);

            //Console.WriteLine(point.DistanceTo(5, 5));

            //point = new Point(8, 5);
            //isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);

            // x is a Point and a MapLocation
            //MapLocation x = new MapLocation(3, 3);
            //Console.WriteLine(point.DistanceTo(5, 5));

            /*map.OnMap(new MapLocation(0, 0));

            Console.WriteLine(x is MapLocation);    // true
            Console.WriteLine(x is Point);          // true

            Point point2 = new Point(0, 0);
            Console.WriteLine(point2 is MapLocation);   // false*/

            // Throw exception:
            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(OutOfBoundsException ex)
            {
                //Console.WriteLine("That map location is not on the map.");
                Console.WriteLine(ex.Message);
            }
            catch (TowerDefenseException)
            {
                Console.WriteLine("Unhandled TowerDefenseException.");
            }
            //catch (Exception)
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception.");
            }

            Console.ReadLine();
        }
    }
}