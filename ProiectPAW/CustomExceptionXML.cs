using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    class CustomExceptionXML :Exception
    {
        public override string Message {
            get { return "Se pot importa doar fisiere XML!"; }
        }
    }
}
