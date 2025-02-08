using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenableInterfaceApp
{
    public class Parachute : IOpenable
    {
        public string OpenSesame()
        {
            return "Have a thrilling experience flying in air";
        }
    }

}
