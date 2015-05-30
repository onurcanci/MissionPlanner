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

        public InternalWayPoint(utmpos position, int column, int row)
        {
            this._row = row;
            this._col = column;
            this._pos = position;
        }


    }
}
