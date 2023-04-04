using System;
using System.Dynamic;

using TaskConsole.Components.FileManagements;
using TaskConsole.Components.Stard;
namespace TaskConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {

            AddTask addTask = new AddTask();

            AddFile addFile = new AddFile();

            StardingTitle st = new StardingTitle();

            st.Title();

            //addFile.findFileTXT();
            //addFile.deleteFileTXT("dataOne");
            //addTask.WriteFile();
            //addTask.ReadFile();
            //addTask.DeleteData();
            //addTask.ReadFile();
        }

    }
}
