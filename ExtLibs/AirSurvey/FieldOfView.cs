using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    class FieldOfView
    {
        public FieldOfView(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float width { get; set; }
        public float height { get; set; }
    }
}
