using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculationService" in both code and config file together.
    [ServiceContract]
    public interface ICalculationService
    {
      
        [OperationContract]
        int AddTwoIntegers(int a, int b);
        
        [OperationContract]
        int SubstractTwoIntegers(int a, int b);

        [OperationContract]
        int MultiplyTwoIntegers(int a, int b);

        [OperationContract]
        int DivideTwoIntegers(int a, int b);



   

        [OperationContract]
        double SubstractTwoDoubles(double a, double b);

        [OperationContract]
        double AddTwoDoubles(double a, double b);

        [OperationContract]
        int MultiplyTwoDoubles(int a, int b);

        [OperationContract]
        int DivideTwoDoubles(double a, double b);

    }
}
