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


            gsd = (((height/width)*100)*0.393701);
        }

        public FieldOfView(float width, float height, float gsd)
        {
            this.width = width;
            this.height = height;
            this.gsd = gsd;
        }

        public float width { get; set; }
        public float height { get; set; }

        public double gsd { get; set; }
    }
}
