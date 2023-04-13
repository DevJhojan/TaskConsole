using System.Data.Common;
using System;
using System.IO;
using TaskConsole.Components.Implemens;
namespace TaskConsole.Components.FileManagements;

public class AddTask
{
    private AddFile addFile = new AddFile();
    private static string? task;

    private static string? description;
    public void ReadFile(string? nameFile)//Modificar para que archivo se va a modificar (string nameFile)
    {
        Console.WriteLine("|---Estas en espacio: " + nameFile + "---|");
        string path = "/home/dragon/workspace/TaskConsole/Data/" + nameFile + ".txt";//midifcar => ""+nameFile+".txt"
        using (StreamReader read = new StreamReader(path))
        {
            Console.WriteLine("|----Tareas agregadas----|");
            string? line;
            while ((line = read.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    public void WriteFile(string? nameFile)
    {
        Console.WriteLine("Tipo de tarea: " + nameFile);

        string path = "/home/dragon/workspace/TaskConsole/Data/" + nameFile + ".txt";
        if (File.Exists(path))
        {

            using (StreamWriter write = File.AppendText(path))
            {
                write.WriteLine("------------------------------");
                write.WriteLine("------------------------------");
                write.Write("Tarea:");
                Console.WriteLine("------------------------------");
                Console.WriteLine("------------------------------");
                Console.Write("Agrega la tarea > ");
                task = Console.ReadLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine("------------------------------");
                write.WriteLine(task);
                write.WriteLine("------------------------------");
                write.WriteLine("------------------------------");

            }
        }
        else
        {
            Console.WriteLine("Tu espacio no se encuentra: ¿pero quieres Crearla?");
            string? resp = Console.ReadLine();
            if (resp == "si" || resp == "Si" || resp == "s" || resp == "S" || resp == "Y" || resp == "y")
            {
                Console.Write("Nombre del Espacio");
                string? res = Console.ReadLine();
                addFile.addFileTXT(res);
            }
        }

    }
    public void DescriptionTask(string? nameFile) //agregar la ruta del archivo
    {

        string path = "/home/dragon/workspace/TaskConsole/Data/" + nameFile + ".txt";//midifcar => ""+nameFile+".txt"
        if (File.Exists(path))
        {

            using (StreamWriter write = File.AppendText(path))
            {

                write.Write("Descripcion de " + task + ":");
                Console.WriteLine("------------------------------");
                Console.WriteLine("------------------------------");
                Console.Write("Escribe la descripcion > ");
                description = Console.ReadLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine("------------------------------");
                write.WriteLine(description);
                write.WriteLine("------------------------------");
                write.WriteLine("------------------------------");

            }
        }
    }
    public void DeleteData(string? nameFile)
    {
        Console.WriteLine("Estas en espacio: " + nameFile);
        string? path = "/home/dragon/workspace/TaskConsole/Data/" + nameFile + ".txt";
        if (File.Exists(path))
        {


            Console.Write("Escribe los datos a elminar>");
            List<string> blocksDataDelete = new List<string>();
            bool sw = true;
            string? dataDelete = "";
            while (sw == true)
            {
                dataDelete = Console.ReadLine();
                blocksDataDelete.Add(dataDelete);

                if (dataDelete == "") sw = false;

            }

            string? content = File.ReadAllText(path);

            foreach (string? blokToRemove in blocksDataDelete)
            {

                int index = content.IndexOf(blokToRemove);//Don't waste time with this warning.

                if (index < 0) return;

                int endIndex = content.LastIndexOf(blokToRemove) + blokToRemove.Length;

                content = content.Remove(index, endIndex - index);

            }
            File.WriteAllText(path, content);

        }

    }
}


