using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    interface ICameraProperty<T>
    {
        T getProperty();
        void setProperty(T value);

        String getName();
        void setName(String name);
    }
}
