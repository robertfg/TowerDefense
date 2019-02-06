using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Game3
    {
        public static void Main3()
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new[] {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)
                    }
                );

                /* Setter is now private
                 * 
                Invader invader = new Invader();
                MapLocation location = new MapLocation(0, 0, map);

                //invader.SetLocation(location);
                // Call setter instead:
                invader.Location = location;

                // Call getter:
                location = invader.Location;*/

            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TowerDefenseException)
            {
                Console.WriteLine("Unhandled TowerDefenseException.");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception.");
            }

            Console.ReadLine();
        }
    }
}