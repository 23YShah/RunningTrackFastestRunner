namespace RunningTrackFastestRunner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students do you want timed?");
            double totalstudents = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            int inttotalstudents;
            double minimumtime;

            //GETTING POSITIVE INTEGER AMOUNT OF STUDENTS
            if((totalstudents % 1) != 0 || (totalstudents <=0))
            {
                Console.Write("You must have a positive integer amount of students.");
                Console.WriteLine();
            }

            else
            {
                //GETTING STUDENT TIMES
                inttotalstudents = Convert.ToInt32(totalstudents);

                double[] times = new double[inttotalstudents];
                double[] fastesttimes = new double[inttotalstudents];

                for (int i = 0; i < inttotalstudents; i++)
                {
                    Console.WriteLine("What time did student " + (i+1) + " get?");
                    times[i] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                }

                //NOW CALCULATING LOWEST TIME

                int fastestrunner = 0;

                for (int j = 1; j < inttotalstudents; j++)
                {
                    if (times[j] <= times[fastestrunner])
                    {
                        fastestrunner = j;
                    }
                }

                for (int k = 0; k < inttotalstudents; k++)
                {
                    if (times[k] == times[fastestrunner])
                    {
                        fastesttimes[k]++;
                    }
                }

                Console.WriteLine("The fastest running time was " + times[fastestrunner] + " seconds, achieved by the following runners:");
                for (int l = 0; (l < inttotalstudents); l++)
                {
                    if (fastesttimes[l] !=0)
                    {
                        Console.WriteLine("Runner " + (l+1) + ", ");
                    }
                }
            }
        }
    }
}
