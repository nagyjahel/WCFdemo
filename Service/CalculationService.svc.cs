using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalculationService.svc or CalculationService.svc.cs at the Solution Explorer and start debugging.
    public class CalculationService : ICalculationService
    {
        public double AddTwoDoubles(double a, double b)
        {
     
            return a;
        }

        public int AddTwoIntegers(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int DivideTwoDoubles(double a, double b)
        {
            throw new NotImplementedException();
        }

        public int DivideTwoIntegers(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int MultiplyTwoDoubles(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int MultiplyTwoIntegers(int a, int b)
        {
            throw new NotImplementedException();
        }

        public double SubstractTwoDoubles(double a, double b)
        {
            throw new NotImplementedException();
        }

        public int SubstractTwoIntegers(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
