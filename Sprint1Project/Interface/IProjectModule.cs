using Sprint1Project.Models;
using System.Collections.Generic;

namespace Sprint1Project.Interface
{
    public interface IProjectModule
    {
        List<ProjectModule> GetAllProject();
        ProjectModule GetProjectById(int id);
        ProjectModule AddProject(ProjectModule project);
        ProjectModule UpdateProject(int id);
        void DeleteProject(int id);
    }
}
