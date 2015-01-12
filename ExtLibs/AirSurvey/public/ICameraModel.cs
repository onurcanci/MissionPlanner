using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    interface ICameraModel
    {
        int getFocalLength();
        void setFocalLength(int mm);

        List<ICameraProperty<Object>> getProperties();
    }
}
