using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    class GenericCameraModel : ICameraModel
    {
        private int _focalLength = 0;

        public int getFocalLength()
        {
            return _focalLength;
        }

        public void setFocalLength(int mm)
        {
            this._focalLength = mm;
        }


        public List<ICameraProperty<object>> getProperties()
        {
            throw new NotImplementedException();
        }
    }
}
