namespace FirstUnitTestWithNUnit
{
    /// <summary>
    /// Class Calculate is a class that makes some basic calculations and 
    /// comparisons between two integers
    /// </summary>
    public class Calculate
    {
        /// <summary>
        /// A method that returns the sum of x + y
        /// </summary>
        /// <param name="x">First integer</param>
        /// <param name="y">Second integer</param>
        /// <returns></returns>
        public int Sum(int x, int y)
        {
            return x + y;   // One execution path
        }


        /// <summary>
        /// A method that returns the subtration of x - y
        /// </summary>
        /// <param name="x">First integer</param>
        /// <param name="y">Second integer</param>
        /// <returns></returns>
        public int Subtract(int x, int y)
        {
            return x - y;   // One execution path
        }

        /// <summary>
        /// A method that return the greater number between to integer x and y
        /// </summary>
        /// <param name="x">First integer</param>
        /// <param name="y">Second integer</param>
        /// <returns></returns>
        public int Greater(int x, int y)
        {
            if (x > y)
                return x;   // First execution path
            else if (y > x)
                return y;   // Second execution path
            else
                return x;   // Third execution path
        }

    }
}
