
using Sprint1Project.Models;
using System.Collections.Generic;

namespace Sprint1Project.Interface
{
    public interface ITaskModule
    {

        List<TaskModule> GetAllTask();
        TaskModule GetTaskById(int id);
        TaskModule AddTask(TaskModule task);
        void UpdateTask(int id);
        void DeleteTask(int id);


    }
}
