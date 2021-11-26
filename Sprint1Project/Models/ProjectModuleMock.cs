using Sprint1Project.Interface;
using System.Collections.Generic;
using Microsoft.OData.Edm;
using System.Linq;

namespace Sprint1Project.Models
{
    public class ProjectModuleMock : IProjectModule
    {

        private static List<ProjectModule> projects = new List<ProjectModule>();
        private int count = 4;

        public ProjectModuleMock()
        {
            projects.Add(new ProjectModule() { Id = 1, Name = "John", Detail = ".net", CreatedOn = "24-05-2020" });
            projects.Add(new ProjectModule() { Id = 2, Name = "Sansa", Detail = "java", CreatedOn = "26-05-2020" });
            projects.Add(new ProjectModule() { Id = 3, Name = "Arya", Detail = "python", CreatedOn = "27-05-2020" });
            projects.Add(new ProjectModule() { Id = 4, Name = "Rob", Detail = "shellscript", CreatedOn = "28-05-2020" });
        }
        public ProjectModule AddProject(ProjectModule project)
        {
            project.Id = ++count;
            projects.Add(project);
            return project;
        }

        public void DeleteProject(int id)
        {
            ProjectModule project = GetProjectById(id);
            projects.Remove(project);
        }

        public List<ProjectModule> GetAllProject()
        {
            return projects;
        }

        public ProjectModule GetProjectById(int id)
        {
            return projects.FirstOrDefault(u => u.Id == id);
        }

        public ProjectModule UpdateProject(int  id)
        {
            ProjectModule project = GetProjectById(id);
            project.Id = id;
            projects.Remove(project);
            projects.Add(project);
            return project;
        }

    

    }
}
