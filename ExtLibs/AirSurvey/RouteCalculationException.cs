using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    class RouteCalculationException : Exception
    {
        public RouteCalculationException(String message) : base(message) { }

    }
}
