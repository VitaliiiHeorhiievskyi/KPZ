using Lab3.Dto;
using Lab3.Models;

namespace Lab3.Contracts
{
    public interface IProjectTaskService
    {
        /// <summary>
        /// Create project task.
        /// </summary>
        Task<int> Create(CreateProjectTaskRequest projectTask);

        /// <summary>
        /// Delete project task by ID.
        /// </summary>
        Task Delete(int id);

        /// <summary>
        /// Returns true if a project task with the input ID is found.
        /// </summary>
        Task<bool> Exists(int id);

        /// <summary>
        /// Get project task by ID.
        /// </summary>
        Task<ProjectTask?> Get(int id);

        /// <summary>
        /// Get all project tasks.
        /// </summary>
        Task<IEnumerable<ProjectTask>> GetAll();

        /// <summary>
        /// Update project task.
        /// </summary>
        Task<int> Update(ProjectTask request);

        /// <summary>
        /// Search all project tasks by name.
        /// </summary>
        Task<IEnumerable<ProjectTask>> SearchByName(string searchTerm);
    }
}