namespace TheReplicatorOfD_Tor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that copies an array of 5 elements into a new array

            int num = 0;
            int[] a1 = new int[5];
            int readNum = 0;
            Console.WriteLine("Enter 5 numbers (int) into the array:  ");

            while(num < 5)
            {
                readNum = int.Parse(Console.ReadLine());
                a1[num] = readNum;
                num++;
            }
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Now we will copy the contents of the array into a new array!");
            int[] a2 = new int[a1.Length];
            for (int i = 0; i < a2.Length; i++) 
            {
                a2[i] = a1[i];  
            }
            Console.WriteLine("The new array, called a2 is copied from a1 and contains the following elements: ") ;
            
            for (int i = 0; i < a2.Length; i++)
            {
                Console.Write(a2[i] + " ");
            }
        }
    }
}