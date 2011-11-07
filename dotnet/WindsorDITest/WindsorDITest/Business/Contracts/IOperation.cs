using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindsorDITest.Business.Contracts
{
    public interface IOperation
    {
        int Operation(int num1, int num2);
    }
}
