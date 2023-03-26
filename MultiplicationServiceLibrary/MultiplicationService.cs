namespace MultiplicationServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MultiplicationService : INewMultiplicationService
    {
        public int Multiply(int a, int b) => a * b;
        public double Multiply(double a, double b) => a * b;
    }
}
