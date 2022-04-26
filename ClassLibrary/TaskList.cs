using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class TaskList
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }

        /// <summary>
        /// Инициализирует список задач с указанным именем
        /// </summary>
        /// <param name="name"></param>
        public TaskList(string name)
        {
            Name = name;
            Tasks = new List<Task>();
        }
        /// <summary>
        /// Возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return Name;
        }
        /// <summary>
        /// Добавляет задачу в список задач
        /// </summary>
        /// <param name="tasks"></param>
        /// <returns></returns>
        public Task AddTask(Task tasks)
        {
            Tasks.Add(tasks);
        }

        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public Task[] GetTasks()
        {
            return Tasks.ToArray();
        }
       /// <summary>
       /// Удаляет задачу из списка
       /// </summary>
       /// <param name="task"></param>
        public void Remove(Task task)
        {
            Tasks.Remove(task);
        }
        /// <summary>
        /// Возвращает задачи запланированные на сегодня в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public Task[] GetTasksByToday()
        {
            List<Task> n = new List<Task>();
            foreach(Task t in Tasks)
            {
                if (t.Due == DateTime.Now)
                {
                    n.Add(t);
                }
            }
            return n.ToArray();
        }
        /// <summary>
        /// Возвращает задачи на завтра и позже в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public Task[] GetTasksByFuture()
        {
            List<Task> n = new List<Task>();
            foreach (Task t in Tasks)
            {
                if (t.Due > DateTime.Now)
                {
                    n.Add(t);
                }
            }
            return n.ToArray();
        }
    }
}
