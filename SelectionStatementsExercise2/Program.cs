namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I don't like math!");
                    break;

                case "science":
                    Console.WriteLine("Science is cool!");
                    break;

                case "english":
                    Console.WriteLine("I like english too");
                    break;

                case "history":
                    Console.WriteLine("History is boring!");
                    break;

                default:
                    Console.WriteLine("I don't know that subject.");
                    break;
   
            }

        }
    }
}