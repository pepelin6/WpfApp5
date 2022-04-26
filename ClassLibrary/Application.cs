using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Application
    {
        private Application application { get; set; }
        public List<TaskList> tasksList { get; set; }

        private Application()
        {
            tasksList.Add(new TaskList("Входящие"));
        }
        /// <summary>
        /// Возвращает ссылку на экземпляр приложения, а в его отсутствие создает экземпляр
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            if(application != null)
            {
                return application;
            }
            else
            {
                application = new Application();
                return application;
            }
        }
        /// <summary>
        /// Создает список задач с указанным именем и добавляет его в taskLists.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TaskList CreateTaskList(string name)
        {
            tasksList.Add(new TaskList(name));
        }
        /// <summary>
        /// возвращает имена списков задач
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string[] GetTaskListNames(string name)
        {
            List<string> m = new List<string>();
            foreach(TaskList q in tasksList)
            {
                if (q.Name == name)
                {
                    foreach(Task w in q.Tasks)
                    {
                        m.Add(w.Title);
                    }
                    break;

                }
            }
            return m.ToArray();

        }
    }
}
