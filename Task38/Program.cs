namespace Task38
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = GetArray();
            foreach(var element in array)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("diff = " + (GetMax(array) - GetMin(array)));
        }

        static double GetMax(double[] array)
        {
            double max = double.MinValue;
            foreach(var element in array)
            {
                if(max < element)
                {
                    max = element;
                }
            }
            return max;
        }

        static double GetMin(double[] array) 
        {
            double min = double.MaxValue;
            foreach(var element in array)
            {
                if(min > element) 
                {
                    min = element;
                }
            }
            return min;
        }

        static double[] GetArray() 
        {
            double[] array = new double[10];
            for(int i = 0; i < array.Length; i++) 
            {
                array[i] = new Random().NextDouble() * 100;
            }
            return array;
        }
    }
}