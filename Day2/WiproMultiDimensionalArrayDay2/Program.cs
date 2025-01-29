namespace WiproMultiDimensionalArrayDay2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter rows :");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter columns :");
            int columns = int.Parse(Console.ReadLine());

            //declare 2D array
            int[,] mtrx = new int[rows, columns];

            //read
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Element[{i},{j}]");
                    mtrx[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //display
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mtrx[i,j]+" ");
                }
                Console.WriteLine();
            }

            //sum
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += mtrx[i, j];
                }
            }
            Console.WriteLine("Sum : " + sum);
        }
    }
}