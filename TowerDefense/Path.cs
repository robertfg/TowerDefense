using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Path
    {
        private readonly MapLocation[] _path;
        //private readonly MapLocation[] path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
            //this.path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;

            /*if (pathStep < _path.Length)
            {
                return _path[pathStep];
            }
            else
            {
                return null;
            }*/

            /*try
            {
                return _path[pathStep];
            }
            catch(IndexOutOfRangeException)
            {
                return null;
            }*/
        }
    }
}
