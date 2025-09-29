using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller.Domain.Models;

public class Report
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public ReportStatus Status { get; set; }
    public DateTime CreatedDate { get; set; }
}

public enum ReportStatus
{
    Active = 0,
    Archived = 1
}
