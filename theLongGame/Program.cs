namespace theLongGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            string userInp = "";

            //Ask User for Input
            Console.WriteLine("Welcome user! What's Your name?");
            userInp = Console.ReadLine();
            Console.WriteLine("Well, " + userInp + " Press every key EXCEPT enter");

            do
            {
                //will start the adding process only if score != 0
                if (score != 0)
                {
                    Console.WriteLine("\nGreat! " + userInp + " has earned " + score + " points!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Well go on! Start pressing!");
                    score++;
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Enter && !Console.KeyAvailable);

            Console.WriteLine("Save Codee");

        }
    }
}
