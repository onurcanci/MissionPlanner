using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    interface ICameraModel
    {
        String getName();
        void setName(String name);
        int getFocalLength();
        void setFocalLength(int mm);
        int getImageWidth();
        void setImageWidth(int mm);
        int getImageHeight();
        void setImageHeight(int mm);
        float getSensorWidth();
        void setSensorWidth(float mm);
        float getSensorHeight();
        void setSensorHeight(float mm);

        FieldOfView calculateFov(float altitude);

        //List<ICameraProperty<Object>> getProperties();
    }
}
