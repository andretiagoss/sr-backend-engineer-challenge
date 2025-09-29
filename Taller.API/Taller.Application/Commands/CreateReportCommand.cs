using MediatR;
using System.ComponentModel.DataAnnotations;
using Taller.Domain.Interfaces;
using Taller.Domain.Models;

namespace Taller.Application.Commands;

public class CreateReportCommand : IRequest
{
    [Required(ErrorMessage = "Title is mandatory")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Content is mandatory")]
    public string Content { get; set; } = string.Empty;

    [Required(ErrorMessage = "Status is mandatory")]
    public ReportStatus? Status { get; set; }
}
public class CreateReportCommandHandler(IReportRepository reportRepository) : IRequestHandler<CreateReportCommand>
{
    public async Task Handle(CreateReportCommand request, CancellationToken cancellationToken)
    {
        var report = new Report
        {
            Title = request.Title,
            Content = request.Content,
            Status = request.Status!.Value,
            CreatedDate = DateTime.UtcNow,
        };

        await reportRepository.Create(report, cancellationToken);
    }
}
