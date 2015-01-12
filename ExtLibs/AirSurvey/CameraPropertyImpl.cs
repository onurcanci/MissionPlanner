using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    abstract class AbstractCameraProperty<T> : ICameraProperty<T>
    {
        String _name;
        Object _value;

        //public AbstractCameraProperty(String name, T value)
        //{
            
        //}

        public string getName()
        {
            throw new NotImplementedException();
        }

        public void setName(string name)
        {
            _name = name;
        }

        public T getProperty()
        {
            return (T)_value;
        }

        public void setProperty(T value)
        {
            _value = value;
        }
    }
}
