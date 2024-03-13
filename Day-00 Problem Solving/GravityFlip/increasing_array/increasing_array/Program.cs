namespace increasing_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int increasing_array(int[] arr)
        {
            int counter = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] >= arr[i])
                {
                    counter += (arr[i - 1] - arr[i]);
                    arr[i] = arr[i - 1];
                }
            }
            return counter;
        }



    }
}
