using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskConsole.Components.Interfaces;

namespace TaskConsole.Components.Implemens
{
    public class Task : ITask
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public enums.TaskStatus Status { get; set; }

        public Task(string title, string description, DateTime dueDate, enums.TaskStatus Status)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            this.Status = Status;
        }

        //Agregar las tareas desde Aca

    }
}