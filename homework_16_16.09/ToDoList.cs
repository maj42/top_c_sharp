using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_16_16._09
{
    public class ToDoList
    {
        internal List<Task> Tasks { get; set; }

        public ToDoList()
        {
            Tasks = new List<Task> { };
        }

        public override string ToString()
        {
            string result = "";
            int cnt = 1;
            foreach (var task in Tasks)
            {
                result += $"{cnt++} Priority: {task.Priority}  {(task.Status ? "Done" : "Not Done")}  {task.Description}\n";
            }
            return result;
        }

        public void AddTask(string descr, int priority = 3)
        {
            Task task = new(descr, priority);
            Tasks.Add(task);
        }

        public void RemoveTask(int ind)
        {
            Tasks.RemoveAt(ind - 1);
        }

        public void ShowPriority(int pr)
        {
            if (pr < 0 || pr > 3)
            {
                Console.WriteLine("No such priority");
                return;
            }

            int cnt = 1;
            foreach (var task in Tasks.Where(x => x.Priority == pr))
            {
                Console.WriteLine($"{cnt++} {task.Description}");
            }
        }

        internal class Task
        {
            public string Description { get; init; }
            public int Priority { get; init; }
            public bool Status { get; init; }

            internal Task(string description, int priority)
            {
                Description = description;
                if (priority < 1 || priority > 3) priority = 3;
                Priority = priority;
                Status = false;
            }
        }
    }
}
