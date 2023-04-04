namespace TaskConsole.Components.FileManagements;
public class AddFile
{
    public void addFileTXT(string nameFile)
    {

        string path = "/home/dragon/workspace/TaskConsole/Data/" + nameFile + ".txt";

        // Crea un nuevo archivo y escribe en él
        using (FileStream fs = File.Create(path))
        {
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine("Este es un ejemplo de archivo creado con C#.");
            }
        }
    }

    public void deleteFileTXT(string nameFile)
    {
        string path = "/home/dragon/workspace/TaskConsole/Data/" + nameFile + ".txt";
        File.Delete(path);
    }

    public void findFileTXT()
    {
        string path = "/home/dragon/workspace/TaskConsole/Data/";
        string[] files = Directory.GetFiles(path);
        foreach (string file in files)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine(Path.GetFileName(file));
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
        }
    }
}