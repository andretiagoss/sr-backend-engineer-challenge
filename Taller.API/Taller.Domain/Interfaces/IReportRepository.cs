using Taller.Domain.Models;

namespace Taller.Domain.Interfaces;

public interface IReportRepository
{
    Task<IEnumerable<Report>> GetByStatusAsync(ReportStatus status, CancellationToken cancellationToken);
    Task Create(Report report, CancellationToken cancellationToken);
}
