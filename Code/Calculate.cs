namespace Code
{
    public class Calculate
    {
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)a / b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
