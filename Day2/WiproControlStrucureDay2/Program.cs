namespace WiproControlStrucureDay2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.WriteLine("Enter a mark:");
            int mark = Convert.ToInt32(Console.ReadLine());
            string grade = "";

            if(mark > 90 && mark <= 100)
            {
                Console.WriteLine("Grade 0");
                grade = "O";
            }
            else if (mark > 80 && mark <= 90)
            {
                Console.WriteLine("Grade E");
                grade = "E";
            }
            else if (mark > 70 && mark <= 80)
            {
                Console.WriteLine("Grade A");
                grade = "A";
            }
            else if (mark > 60 && mark <= 70)
            {
                Console.WriteLine("Grade B");
                grade = "B";
            }
            else if (mark >= 50 && mark <= 60)
            {
                Console.WriteLine("Grade C");
                grade = "C";
            }
            else if (mark < 50)
            {
                Console.WriteLine("Better luck next time...");
                grade = " ";
            }

            switch(grade)
            {
                case "O": Console.WriteLine("Outstanding");
                    break;
                case "E": Console.WriteLine("Excellent"); 
                    break;
                case "A": Console.WriteLine("Very Good");
                    break;
                case "B": Console.WriteLine("Good");
                    break;
                default: Console.WriteLine("Try to improve next time...");
                    break;
            }
            int abc = 10;
            for (; ; ) //infinite loop
            {
                Console.WriteLine(abc);
                if (abc <= 0)
                {
                    break;
                }
                else
                {
                    abc -= 3;
                }
            }
            int y = 5;
            while(y<5)
            {
                y++;
                if(y == 2)
                {
                    break; //stops the entire iteration
                    //continue; //stops the current iteration
                }
                Console.WriteLine("While loop"+y);
            }
            //do
            //{
            //    Console.WriteLine("do..while" + y);
            //} while (y < 5);
        }
    }
}