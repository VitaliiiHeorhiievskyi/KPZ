using Azure.Core;
using Lab3.Contracts;
using Lab3.Dto;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTasksController : ControllerBase
    {
        private readonly IProjectTaskService _projectTaskService;

        public ProjectTasksController(IProjectTaskService projectTaskService)
        {
            _projectTaskService = projectTaskService;
        }

        /// <summary>
        /// Get all project tasks.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProjectTask>))]
        public async Task<ActionResult<IEnumerable<ProjectTask>>> GetAll()
        {
            return Ok(await _projectTaskService.GetAll());
        }

        /// <summary>
        /// Get project task by ID.
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProjectTask))]
        public async Task<ActionResult<ProjectTask>> Get(int id)
        {
            if (!await _projectTaskService.Exists(id))
            {
                return NotFound($"Project task with id({id}) not found!!!");
            }

            return Ok(await _projectTaskService.Get(id));
        }

        /// <summary>
        /// Search all project tasks by name.
        /// </summary>
        [HttpGet("search/{searchTerm}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProjectTask>))]
        public async Task<ActionResult<IEnumerable<ProjectTask>>> SearchByName(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException($"'{nameof(searchTerm)}' cannot be null or whitespace.", nameof(searchTerm));
            }

            return Ok(await _projectTaskService.SearchByName(searchTerm));
        }

        /// <summary>
        /// Create project task.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        public async Task<ActionResult<int>> Create(CreateProjectTaskRequest projectTask)
        {
            return Ok(await _projectTaskService.Create(projectTask));
        }

        /// <summary>
        /// Update project task.
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        public async Task<IActionResult> Update(ProjectTask request)
        {
            if (!await _projectTaskService.Exists(request.Id))
            {
                return NotFound($"Project task with id({request.Id}) not found!!!");
            }
            return Ok(await _projectTaskService.Update(request));
        }

        /// <summary>
        /// Delete project task by ID.
        /// </summary>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(int id)
        {
            if (!await _projectTaskService.Exists(id))
            {
                return NotFound($"Project task with id({id}) not found!!!");
            }

            await _projectTaskService.Delete(id);

            return NoContent();
        }
    }
}