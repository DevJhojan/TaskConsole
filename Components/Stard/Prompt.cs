
namespace TaskConsole.Components.Stard
{
    public class Prompt
    {
        private const bool V = false;
        public static string inpu = "";
        private bool input = false;

        private StardingTitle title = new StardingTitle();

        public void Input(string v)
        {
            input = true;
            while (input)
            {
                switch (v)
                {
                    case "":
                        Console.Write("#>");
                        Input(Console.ReadLine());
                        Console.ReadKey();
                        break;
                    case "task":
                        
                        break;
                    case "cl":

                        Console.Clear();
                        title.Title();
                        Input("");
                        Console.ReadKey();
                        break;

                    case "ext":
                        input = false;
                        Console.WriteLine("Adios");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("#>");
                        Input(Console.ReadLine());
                        Console.ReadKey();
                        break;

                }
            }
        }

    }
}