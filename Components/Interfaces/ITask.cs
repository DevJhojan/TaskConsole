using System;
using System.Collections.Generic;
using System.Linq;
using TaskConsole.Components.enums;
namespace TaskConsole.Components.Interfaces
{
    public interface ITask
    {
        string? Title {get; set;}
        string? Description {get; set;}
        DateTime DueDate{get; set; }
        enums.TaskStatus Status {get; set; }
    }
}