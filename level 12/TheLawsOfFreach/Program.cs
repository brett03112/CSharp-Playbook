namespace TheLawsOfFreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate the minumum value in an array using a foreach loop.  Should be -99
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentSmallest = int.MaxValue; // Start higher than anything in the array.
            foreach (int num in array)
            {
                if (num < currentSmallest)
                    currentSmallest = num;
            }
            Console.WriteLine(currentSmallest);
            Console.WriteLine();

            //calculate the average value of an array using a foreach loop.  Should be 11.55555
            int[] array1 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            foreach (int index in array1)
                total += index;
            float average = (float)total / array1.Length;
            Console.WriteLine(average);
            Console.WriteLine();
        }
    }
}