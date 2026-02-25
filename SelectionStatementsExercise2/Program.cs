namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
          FavSubject();  
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is not my favorite subject.");
                    break;
                case "science":
                    Console.WriteLine("I enjoyed science, especially technology.");
                    break;
                case "physics":
                    Console.WriteLine("Physics is the absolute best.");
                    break;
                case "history":
                    Console.WriteLine("I enjoy history as an adult, but really didn't like it in school.");
                    break;
                case "geography":
                    Console.WriteLine("I enjoy learning about the world.");
                    break;
                default:
                    Console.WriteLine("Interesting choice. What do you like about it?");
                    break;
                
            }
        }
    }
}