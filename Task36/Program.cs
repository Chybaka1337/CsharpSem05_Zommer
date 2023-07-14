namespace Task36
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] array = GetArray();
            foreach(var element in array) 
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine();
            int sum = 0;
            for(int i = 1; i < array.Length; i += 2) 
            {
                sum += array[i];
            }
            Console.WriteLine("sum = " + sum);
        }

        static int[] GetArray() 
        {
            int[] array = new int[5];
            for(int i = 0; i < array.Length; i++) 
            {
                array[i] = new Random().Next(-1000, 1000);
            }
            return array;
        }
    }
}