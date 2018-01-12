using System.Runtime.Serialization;
using System.ServiceModel;

namespace TestReadifyChallenge
{
    [ServiceContract]
    public interface IRedPill
    {
        [System.ServiceModel.OperationContractAttribute]
        System.Guid WhatIsYourToken();

        [System.ServiceModel.OperationContractAttribute]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException))]
        long FibonacciNumber(long n);

        [System.ServiceModel.OperationContractAttribute]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException))]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [System.ServiceModel.OperationContractAttribute]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException))]
        string ReverseWords(string s);

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute]
    public enum TriangleType : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }

}