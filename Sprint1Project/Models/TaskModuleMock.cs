using Sprint1Project.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Sprint1Project.Models
{
    public class TaskModuleMock : ITaskModule
    {


        private static List<TaskModule> tasks = new List<TaskModule>();
        private int count = 4;


        public TaskModuleMock()
        {
            tasks.Add(new TaskModule() { Id = 1, ProjectId = 1, StatusId = 0, AssignedToUserId = 1, Detail = "first assignment", CreatedOn = "24-05-2020" });
            tasks.Add(new TaskModule() { Id = 2, ProjectId = 2, StatusId = 0, AssignedToUserId = 1, Detail = "second assignment", CreatedOn = "25-05-2020" });
            tasks.Add(new TaskModule() { Id = 3, ProjectId = 3, StatusId = 0, AssignedToUserId = 1, Detail = "third assignment", CreatedOn = "26-05-2020" });
            tasks.Add(new TaskModule() { Id = 4, ProjectId = 4, StatusId = 0, AssignedToUserId = 1, Detail = "fourth assignment", CreatedOn = "27-05-2020" });
        }
        public TaskModule AddTask(TaskModule task)
        {
            task.Id = ++count;
            tasks.Add(task);
            return task;
        }

        public void DeleteTask(int id)
        {
            TaskModule task = GetTaskById(id);
            tasks.Remove(task);
        }

        public List<TaskModule> GetAllTask()
        {
            return tasks;
        }

        public TaskModule GetTaskById(int id)
        {
            return tasks.FirstOrDefault(u => u.Id == id);
        }

        public void UpdateTask(int id)
        {
            TaskModule task = GetTaskById(id);
            tasks.Remove(task);
            AddTask(task);

        }
    }
}
