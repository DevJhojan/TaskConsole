using System;
using System.IO;

namespace TaskConsole.Components.FileManagements;

public class AddTask
{
    public void ReadFile()//Modificar para que archivo se va a modificar (string nameFile)
    {
        string path = "/home/dragon/workspace/TaskConsole/Data/datos.txt";
        using (StreamReader read = new StreamReader(path))
        {
            Console.WriteLine("Tareas agregadas:");
            string line;
            while ((line = read.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    public void WriteFile()//Modificar para que archivo se va a modificar (string nameFile)
    {
        //que siempre muestre en que archivo va estar la tarea
        string path = "/home/dragon/workspace/TaskConsole/Data/datos.txt";
        using (StreamWriter write = new StreamWriter(path))
        {
            write.WriteLine("------------------------------");
            write.WriteLine("------------------------------");
            write.Write("Tarea:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.Write("Agrega la tarea: ");
            string task = Console.ReadLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            write.WriteLine(task);
            write.WriteLine("------------------------------");
            write.WriteLine("------------------------------");
            Console.Write("¿Quieres agregar la descripción?: ");
            string resp = Console.ReadLine();
            if (resp == "si" || resp == "Si" || resp == "s" || resp == "S" || resp == "Y" || resp == "y")
            {
                DescriptionTask(task);
            }
        }
    }
    public void DescriptionTask(string task)
    {
        string path = "/home/dragon/workspace/TaskConsole/Data/datos.txt";
        using (StreamWriter write = new StreamWriter(path))
        {

            write.WriteLine("------------------------------");
            write.Write("Descripcion de " + task + ":");
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.Write("Escribe la descripcion: ");
            string description = Console.ReadLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            write.WriteLine(description);
            write.WriteLine("------------------------------");
            write.WriteLine("------------------------------");
        }
    }
    public void DeleteData()//Modificar para que archivo se va a modificar (string nameFile)
    {
        string path = "/home/dragon/workspace/TaskConsole/Data/datos.txt";

        string content = File.ReadAllText(path);

        Console.Write("Escribe el dato a elminar:");
        string dataDelete = Console.ReadLine();

        content = content.Replace(dataDelete, " ");

        File.WriteAllText(path, content);
    }
}