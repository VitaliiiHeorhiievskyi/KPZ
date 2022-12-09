using FluentValidation;
using Lab3.Models;

namespace Lab3.Dto
{
    public class CreateProjectTaskRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public DateTime CreatedDate { get; set; }
        public int Priority { get; set; }
        public Status Status { get; set; }
    }

    public class CreateProjectTaskValidator : AbstractValidator<CreateProjectTaskRequest>
    {
        public CreateProjectTaskValidator()
        {
            RuleFor(p => p.Name).NotEmpty().NotNull();
            RuleFor(p => p.Description).NotEmpty().NotNull();
            RuleFor(p => p.CreatedDate).NotNull();
            RuleFor(p => p.Priority).NotNull();
            RuleFor(p => p.Status).NotNull();
        }
    }
}