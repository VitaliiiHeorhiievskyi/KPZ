using Lab3.Contracts;
using Lab3.DataBase;
using Lab3.Dto;
using Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Services
{
    public class ProjectTaskService : IProjectTaskService
    {
        private readonly AppDbContext _context;
        public ProjectTaskService(AppDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<ProjectTask>> GetAll()
        {
            return await _context.ProjectTasks.ToListAsync();
        }

        /// <inheritdoc />
        public async Task<ProjectTask?> Get(int id)
        {
            return await _context.ProjectTasks.FirstOrDefaultAsync(task => task.Id == id);
        }

        /// <inheritdoc />
        public async Task<int> Update(ProjectTask request)
        {
            if (request is null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var projectTask = await _context.ProjectTasks.FirstOrDefaultAsync(task => task.Id == request.Id);

            if (projectTask is null)
            {
                throw new InvalidOperationException(nameof(request));
            }

            projectTask.Description = request.Description;
            projectTask.Status = request.Status;
            projectTask.CreatedDate = request.CreatedDate;
            projectTask.Priority = request.Priority;

            _context.Entry(projectTask).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return projectTask.Id;
        }

        /// <inheritdoc />
        public async Task<int> Create(CreateProjectTaskRequest createProjectTask)
        {
            var newProjectTask = new ProjectTask() 
            {
                Name = createProjectTask.Name,
                Description = createProjectTask.Description,
                Status = createProjectTask.Status,
                Priority = createProjectTask.Priority,
                CreatedDate = createProjectTask.CreatedDate
            };
            await _context.ProjectTasks.AddAsync(newProjectTask);
            await _context.SaveChangesAsync();
            return newProjectTask.Id;
        }

        /// <inheritdoc />
        public async Task Delete(int id)
        {
            _context.ProjectTasks.Remove(await _context.ProjectTasks.FirstOrDefaultAsync(task => task.Id == id));
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task<bool> Exists(int id)
        {
            return await _context.ProjectTasks.AnyAsync(task => task.Id == id);
        }

        /// <inheritdoc />
        public async Task<IEnumerable<ProjectTask>> SearchByName(string searchTerm)
        {
            return await _context.ProjectTasks.Where(task => task.Name.Contains(searchTerm)).ToListAsync();
        }
    }
}