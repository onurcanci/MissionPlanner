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
        private float _sensorWidth = 0f;
        private float _sensorHeight = 0f;
        private int _imageWidth = 0;
        private int _imageHeight = 0;
        private String _name = "";
        

        public String getName()
        {
            return _name;
        }

        public void setName(String name)
        {
            this._name = name;
        }

        public int getFocalLength()
        {
            return _focalLength;
        }

        public void setFocalLength(int mm)
        {
            this._focalLength = mm;
        }

        public int getImageWidth()
        {
            return _imageWidth;
        }

        public void setImageWidth(int mm)
        {
            _imageWidth = mm;
        }
        public int getImageHeight()
        {
            return _imageHeight;
        }

        public void setImageHeight(int mm)
        {
            _imageHeight = mm;
        }

        public float getSensorWidth()
        {
            return _sensorWidth;
        }

        public void setSensorWidth(float mm)
        {
            _sensorWidth = mm;
        }

        public float getSensorHeight()
        {
            return _sensorHeight;
        }

        public void setSensorHeight(float mm)
        {
            _sensorHeight = mm;
        }

        public FieldOfView calculateFov(float altitude)
        {
            try
            {
                // scale      mm / mm
                float flscale = (1000 * altitude) / _focalLength;

                //   mm * mm / 1000
                return new FieldOfView((_sensorWidth * flscale / 1000), (_sensorHeight * flscale / 1000));
            }
            catch { return null; }
        }
    }
}
