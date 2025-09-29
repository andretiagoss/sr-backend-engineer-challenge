using Taller.Domain.Models;

namespace Taller.Application.DTOs;

public class ReportDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public ReportStatus Status { get; set; }
    public DateTime CreatedDate { get; set; }
}
