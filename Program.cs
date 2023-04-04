using System;
using System.Dynamic;

using TaskConsole.Components.FileManagements;
using TaskConsole.Components.Stard;
namespace TaskConsole
{
    public class Program
    {

        public static StardingTitle st = new StardingTitle();
        public static Prompt prompt = new Prompt();
        public static void Main(string[] args)
        {

            st.Title();
            prompt.Input("");

        }

    }
}
