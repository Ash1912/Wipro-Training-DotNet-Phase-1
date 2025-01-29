namespace WiproJaggedArrayDay2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Jagged Array
            int[][] jagarr = new int[4][];
            jagarr[0] = new int[] { 10, 20, 30 };
            jagarr[1] = new int[] { 20, 24 };
            jagarr[2] = new int[] { 45, 78, 89, 99 };
            jagarr[3] = new int[] { 45, 78, 89, 99 };

            // Display
            for (int i = 0; i < jagarr.Length; i++)
            {
                Console.Write($"Outer Array: Row {i + 1} ");
                for (int j = 0; j < jagarr[i].Length; j++)
                {
                    Console.Write(jagarr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter the number of teams:");
            int teams = Convert.ToInt32(Console.ReadLine());

            int[][] jagarruser = new int[teams][]; // Created jagged array with teams, size

            // Reading
            for (int i = 0; i < jagarruser.Length; i++)
            {
                Console.WriteLine($"Number of rounds played by team {i + 1}:");
                int rounds = Convert.ToInt32(Console.ReadLine());
                jagarruser[i] = new int[rounds]; // Within array declaring another array of size, rounds
                Console.WriteLine($"Enter the scores for each round for team {i + 1}:");
                for (int j = 0; j < rounds; j++)
                {
                    jagarruser[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Display the scores and calculate the total sum
            for (int i = 0; i < jagarruser.Length; i++)
            {
                int teamSum = 0;
                Console.Write($"Scores for team {i + 1}: ");
                for (int j = 0; j < jagarruser[i].Length; j++)
                {
                    Console.Write(jagarruser[i][j] + " ");
                    teamSum += jagarruser[i][j]; // Add score to teamSum
                }
                Console.WriteLine($"\nTotal score for team {i + 1}: {teamSum}");
            }
        }
    }
}
