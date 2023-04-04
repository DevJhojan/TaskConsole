using System;
using System.IO;

namespace TaskConsole.Components.FileManagements;

public class AddTask
{
    public void ReadFile(){
        string path = "/home/dragon/workspace/TaskConsole/Data/datos.txt";
        using (StreamReader read = new StreamReader(path))
        {
            string line; 
            while ((line = read.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    public  void WriteFile()
    {
        string path = "/home/dragon/workspace/TaskConsole/Data/datos.txt";
        using (StreamWriter write = new StreamWriter(path))
        {
            write.WriteLine("------------------------------");
            write.WriteLine("------------------------------");
            write.Write("Tarea:");
            Console.WriteLine("------------------------------");
            Console.Write("tarea: ");
            string task = Console.ReadLine();
            Console.WriteLine("------------------------------");
            write.WriteLine(task);
            write.WriteLine("------------------------------");
            write.WriteLine("------------------------------");
        }
    }

    public void DeleteData()
    {
        string path = "/home/dragon/workspace/TaskConsole/Data/datos.txt";

        string content = File.ReadAllText(path);

        Console.Write("Escribe el dato a elminar:");
        string dataDelete = Console.ReadLine();
        
        content = content.Replace(dataDelete, " ");

        File.WriteAllText(path, content);
    }
}