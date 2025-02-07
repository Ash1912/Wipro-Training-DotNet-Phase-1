using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringDemo.Interfaces
{
    internal interface IPayslipGenerate
    {
        void GeneratePaySlip(string employeeName, double salary);
    }
}
