using System.ServiceModel;

namespace MultiplicationServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name = "MultiplicationService")]
    public interface IMultiplicationService
    {
        [OperationContract(Name = "MultiplyInt")]
        int Multiply(int a, int b);
    }

    [ServiceContract(Name = "NewMultiplicationService")]
    public interface INewMultiplicationService : IMultiplicationService
    {
        [OperationContract(Name = "MultiplyDouble")]
        double Multiply(double a, double b);
    }
}
