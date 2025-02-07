using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment2.Observer
{
    public interface IObserver
    {
        void Update(float temperature);
    }
}
