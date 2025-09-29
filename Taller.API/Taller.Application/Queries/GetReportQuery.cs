using AutoMapper;
using MediatR;
using Taller.Application.DTOs;
using Taller.Domain.Interfaces;
using Taller.Domain.Models;

namespace Taller.Application.Queries;

public record GetReportQuery(ReportStatus Status) : IRequest<IEnumerable<ReportDto>>;

public class GetReportQueryHandler(IReportRepository reportRepository, IMapper Mapper) : IRequestHandler<GetReportQuery, IEnumerable<ReportDto>>
{
    public async Task<IEnumerable<ReportDto>> Handle(GetReportQuery request, CancellationToken cancellationToken)
    {
        var reportData = await reportRepository.GetByStatusAsync(request.Status, cancellationToken);
        return Mapper.Map<IEnumerable<ReportDto>>(reportData);
    }
}
