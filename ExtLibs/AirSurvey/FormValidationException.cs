using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSurvey
{
    class FormValidationException : Exception
    {
        public FormValidationException(String message)
            : base(message)
        {
            
        }
    }
}
