using System.IO;
using System.Text;

namespace theLongGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int iter = 0;
            string userInp = "";

            //Ask User for Name
            Console.WriteLine("Welcome user! What's Your name?");
            userInp = Console.ReadLine();
            Console.WriteLine("Well, " + userInp + " Press every key EXCEPT enter");

            //Test if Name file exist and Read Score from if it does
            FileStream fs = new FileStream(@"..\users\" + userInp + ".txt", FileMode.OpenOrCreate);
            fs.Close();
            try
            {
                StreamReader sr = new StreamReader(@"..\users\" + userInp + ".txt");
                //Checks if String is Null or Empty
                while (sr.ReadLine() != null)
                {
                    score = Int32.Parse(sr.ReadLine());
                }
                sr.Close();
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Thrown");
                Console.WriteLine(e.ToString());
                
            }

            do
            {
                //will start the adding process only if iter != 0
                if (score != 0)
                {
                    if(iter != 0) { 
                    Console.WriteLine("\nGreat! " + userInp + " has earned " + score + " points!");
                    score++;
                    }
                    else
                    {
                        Console.WriteLine("You currently have " + score);
                        iter++;
                        score++;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Well go on! Start pressing!");
                    score++;
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Enter && !Console.KeyAvailable);

            Console.WriteLine("Saving Codee");
            //Saving Code with StreamWriter
            try
            {
                StreamWriter sw = new StreamWriter(@"..\users\" + userInp + ".txt", false);
                sw.WriteLine("User Score");
                sw.WriteLine(score);
                Console.WriteLine("Data saved for next time " + userInp);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found");
                Console.WriteLine(e.ToString());
                return;
            }
        }
    }
}
