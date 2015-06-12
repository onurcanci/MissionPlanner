using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    class InternalWayPoint
    {
        private int _row;
        private int _col;
        private utmpos _pos;
        public bool includeInRoute = true;


        public InternalWayPoint(utmpos pos, int col, int row)
        {
            _pos = pos;
            _col = col;
            _row = row;
        }

        public InternalWayPoint(utmpos pos, bool includeInRoute, int col, int row)
        {
            _pos = pos;
            this.includeInRoute = includeInRoute;
            _col = col;
            _row = row;
        }

        public utmpos UtmPosition
        {
            get
            {
                return _pos;
            }
        }
        public int column
        {
            get
            {
                return _col;
            }
        }
        public int row
        {
            get
            {
                return _row;
            }
        }



        public bool active = true;



    }
}
