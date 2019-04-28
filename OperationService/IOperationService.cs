using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OperationService
{
    [ServiceContract]
    public interface IOperationService
    {

        [OperationContract]
        double Substract(double a, double b);

        [OperationContract]
        double Add(double a, double b);

        [OperationContract]
        double Multiply(double a, double b);

        [OperationContract]
        double Divide(double a, double b);
    }

}
