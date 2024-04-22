namespace ArraysNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are notes for arrays in c#.");

            int[] scores = new int[5];
            int x = 1;
            for(int i = 0; i < scores.Length; i++)
            {
                
                scores[i] = x;
                x++;
            }
            for (int i = 0;i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
            Console.WriteLine();
            // get the last element
            int last = scores[^1];
            Console.WriteLine(last);
            Console.Write('\n');

            //Creat a new array with the first 3 elements of scores
            int[] firstThreeScores = scores[0..3];
            for(int i = 0; i < firstThreeScores.Length; i++)
            {
                Console.WriteLine(firstThreeScores[i]);
            }

            int[] theMiddle = scores[1..^1];
            for (int i = 0; i < theMiddle.Length; i++) 
            {
                Console.WriteLine(theMiddle[i]);
            }
            Console.WriteLine() ;

            // Calculate the minumum value in an array
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentSmallest = int.MaxValue; // Start higher than anything in the array.
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < currentSmallest)
                    currentSmallest = array[index];
            }
            Console.WriteLine(currentSmallest);
            Console.WriteLine();

            //calculate the average value of an array
            int[] array1 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            for (int index = 0; index < array1.Length; index++)
                total += array1[index];
            float average = (float)total / array1.Length;
            Console.WriteLine(average);
            Console.WriteLine();

            // the foreach method with arrays.  Will be all 0's
            int[] scores1 = new int[10];
            foreach (int score in scores1)
                Console.WriteLine(score);
            Console.WriteLine();

            // multidimensional arrays
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2 };
            matrix[1] = new int[] { 3, 4 };
            matrix[2] = new int[] { 5, 6 };
            Console.WriteLine(matrix[0][1]); // Should be 2.
            Console.WriteLine();

            //or it can be initialized like the following
            // int[,] matrix = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            // This initiallizes a 4x4 matrix to all 0's
            int[,] matrix1 = new int[4, 4];
            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int column = 0; column < matrix1.GetLength(1); column++)
                    Console.Write(matrix1[row, column] + " ");
                Console.WriteLine();
            }

            Console.WriteLine();

            // initialize a multidimensional array with values using for loops
            int rows = 10;
            int columns = 10;
            int[,] grid = new int[rows, columns];
            int number = 1;

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    grid[i, j] = number;
                    number++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (i == 0 && j < 9)
                        Console.Write(grid[i, j] + "  | ");

                    else
                        Console.Write(grid[i, j] + " | ");
                }
                Console.WriteLine() ;
            }

        }

    }
}