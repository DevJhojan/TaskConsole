using System;
using System.Collections.Generic;
using System.Linq;
using TaskConsole.Components.enums;
using TaskConsole.Components.FileManagements;
namespace TaskConsole.Components.Interfaces
{
    public interface ITask
    {
        string? Title {get; set;}
        string? Description {get; set;}
        string? Path{get; set;}
        DateTime DueDate{get; set; }
        enums.TaskStatus Status {get; set; }
        AddFile AddFile { get; set; }

        string WriteFile(string? nameFile);

    }
}