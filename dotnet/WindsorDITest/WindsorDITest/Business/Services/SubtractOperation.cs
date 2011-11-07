using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindsorDITest.Business.Contracts;

namespace WindsorDITest.Business.Services
{
    public class SubtractOperation: IOperation
    {
        public int Operation(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
