using System;
using System.ServiceModel;

namespace MultiplicationServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    //Use this only for dev envs!
    //[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class MultiplicationService : INewMultiplicationService
    {
        public int Multiply(int a, int b) => a * b;
        public int Div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                var divFault = new DivFault
                {
                    Message = "The second parameter cannot be zero.",
                    OperationMessage = e.Message
                };
                throw new FaultException<DivFault>(divFault, divFault.Message);
            }
        }
        public double Multiply(double a, double b) => a * b;

        public void Save(Student student)
        {
            Console.WriteLine($"Student data: {student.Id}:{student.Name}");
        }
    }
}
