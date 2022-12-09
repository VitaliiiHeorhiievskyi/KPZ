using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3.Models
{
    public class ProjectTask
    {
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 1)]
        [StringLength(100)]
        public string? Name { get; set; }

        [Column("Full Description", Order = 2)]
        [StringLength(1000)]
        public string? Description { get; set; }

        [Column(Order = 5)]
        public DateTime CreatedDate { get; set; }

        [Column(Order = 3)]
        public int Priority { get; set; }

        [Column(Order = 4)]
        public Status Status { get; set; }
    }

    public enum Status
    {
        New,
        InProgress,
        Testing,
        Closed
    }
}