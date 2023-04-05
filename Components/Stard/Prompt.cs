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
        public void Input(string? v)
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
                        Console.Write("Espacio de trabajo>");
                        string? epwa = Console.ReadLine();
                        addTask.WriteFile(epwa);
                        Console.Write("¿Quieres agregar la descripción?: ");
                        string? resp = Console.ReadLine();
                        if (resp == "si" || resp == "Si" || resp == "s" || resp == "S" || resp == "Y" || resp == "y")
                        {
                            addTask.DescriptionTask(epwa);
                        }
                        Input("");
                        break;

                    case "r-task":
                        Console.Write("Espacio de trabajo>");
                        string? epwr = Console.ReadLine();
                        addTask.ReadFile(epwr);
                        Input("");
                        break;

                    case "d-task":
                        Console.Write("Espacio de trabajo>");
                        string? epwd = Console.ReadLine();
                        addTask.DeleteData(epwd);
                        Input("");
                        break;

                    case "hola":
                        Console.WriteLine("Hola ¿Como estas?");
                        break;

                    case "muy bien y tu":
                        Console.WriteLine("Bien, bien, ahora pon la tarea :V");
                        break;

                    case "¿Que eres?":
                        Console.WriteLine("Una simple app de consola \n" +
                             "y si te lo preguntas, nop, no tengo todavia inteligencia artificial integrada\n" +
                             "posiblemente en un futuro mi creador lo haga, pero en estos momento, nop");
                        break;

                    case "que eres":
                        Console.WriteLine("Una simple app de consola \n" +
                                 "y si te lo preguntas nop, no tengo todavia inteligencia artificial integrada\n" +
                                 "posiblemente en un futuro mi creador lo haga, pero en estos momento, nop");
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