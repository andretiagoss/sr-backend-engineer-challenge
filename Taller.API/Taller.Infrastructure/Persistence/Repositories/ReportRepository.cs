using Microsoft.EntityFrameworkCore;
using Taller.Domain.Interfaces;
using Taller.Domain.Models;

namespace Taller.Infrastructure.Persistence.Repositories;

public class ReportRepository(DataContext dataContext) : IReportRepository
{
    public async Task Create(Report report, CancellationToken cancellationToken)
    {
        await dataContext.AddAsync(report);
        await dataContext.SaveChangesAsync(cancellationToken); //we can implement unit of work pattern
    }

    public async Task<IEnumerable<Report>> GetByStatusAsync(ReportStatus status, CancellationToken cancellationToken)
    {
        return await dataContext.Reports
            .AsNoTracking()
            .Where(a => a.Status == status)
            .ToListAsync(cancellationToken);
    }
}
