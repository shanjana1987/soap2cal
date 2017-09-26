using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace soap2cal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double AddSub(double a, double b);
        [OperationContract]
        double Subtract(double a, double b);
        [OperationContract]
        double Multiply(double a, double b);
        [OperationContract]
        double Divide(double a, double b);
    }
    [DataContract]
    public class Calculator
    {
        [DataMember]
        public double a;
        [DataMember]
        public double b;
    }
}

