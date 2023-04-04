using System;
using System.Dynamic;
using TaskConsole.Components.FileManagements;

namespace TaskConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {

            AddTask addTask = new AddTask();

            AddFile addFile = new AddFile();

            addFile.findFileTXT();
            //addFile.deleteFileTXT("dataOne");
            //addTask.WriteFile();
            //addTask.ReadFile();
            //addTask.DeleteData();
        }

    }
}
