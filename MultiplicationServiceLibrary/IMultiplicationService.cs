using System.Runtime.Serialization;
using System.ServiceModel;

namespace MultiplicationServiceLibrary
{
    [DataContract]
    public class Student
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember(IsRequired = true)]
        public string Contact { get; set; }
    }

    [DataContract]
    public class DivFault
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string OperationMessage { get; set; }
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name = "MultiplicationService")]
    public interface IMultiplicationService
    {
        [OperationContract(Name = "MultiplyInt")]
        int Multiply(int a, int b);

        [OperationContract(Name = "DivInt")]
        [FaultContract(typeof(DivFault))]
        int Div(int a, int b);
    }

    [ServiceContract(Name = "NewMultiplicationService")]
    public interface INewMultiplicationService : IMultiplicationService
    {
        [OperationContract(Name = "MultiplyDouble")]
        double Multiply(double a, double b);

        [OperationContract(Name = "Save")]
        void Save(Student student);
    }
}
