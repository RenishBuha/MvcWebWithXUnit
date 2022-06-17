namespace MvcWebWithXUnit.Services
{
    public class AirthmeticService : IAirthmeticService
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }

        public int Subtraction(int x, int y)
        {
            return (x - y);
        }
        public int Multiplication(int x, int y)
        {
            return  x * y;
        }

        public double Division(int x, int y)
        {
            double result = 0;
            try
            {
                result = Convert.ToDouble(x) / y;
            }
            catch (DivideByZeroException e)
            {
                return -1;
            }
            return result;
        }
    }
}
