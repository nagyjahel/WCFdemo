using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OperationService
{
     public class Service1 : IOperationService
    {
        public double Add(double a, double b) { return a + b; }

        public double Divide(double a, double b) { return a / b; }

        public double Multiply(double a, double b) { return a * b; }

        public double Substract(double a, double b) { return a - b; }
    }
}
