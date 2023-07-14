namespace Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = GetArray();
            Console.WriteLine("source");
            foreach(var element in array)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine("\neven");
            foreach(var element in array) 
            {
                if(element % 2 == 0)
                    Console.Write(element + "\t");
            }
        }

        static int[] GetArray() 
        {
            int[] array = new int[10];
            for(int i = 0; i < array.Length; i++) 
            {
                array[i] = new Random().Next(1, 1000);
            }
            return array;
        }
    }
}