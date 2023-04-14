using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskConsole.Components.FileManagements;
using TaskConsole.Components.Interfaces;

namespace TaskConsole.Components.Implemens
{
    public class Task : ITask
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public string? Path { get; set; }
        public enums.TaskStatus Status { get; set; }
        public AddFile AddFile { get; set; }

        public Task(string title, string description, DateTime dueDate, 
                        enums.TaskStatus Status, AddFile add, string path)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            this.Status = Status;
            AddFile = add;
            Path = path;
            WriteFile(Path);
        }

        private void WriteFile(string? nameFile)
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
                    write.WriteLine(Title);
                    write.WriteLine("------------------------------");
                    write.Write("Descripción:");
                    write.WriteLine(Description);
                    write.WriteLine("------------------------------");
                    write.Write("Comenzar Tarea:");
                    write.WriteLine(DueDate);
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
                    AddFile.addFileTXT(res);
                }
            }
        }

        string ITask.WriteFile(string? nameFile)
        {
            throw new NotImplementedException();
        }
    }
}