using TaskConsole.Components.FileManagements;
namespace TaskConsole.Components.Stard
{
    public class Prompt
    {
        private const bool V = false;
        public static string inpu = "";
        private bool input = false;

        private StardingTitle title = new StardingTitle();
        
        private AddTask addTask = new AddTask();
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
                    case "a-task":
                        addTask.WriteFile();
                        break;

                    case "r-task":
                        addTask.ReadFile();
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