using AutoMapper;
using Taller.Application.DTOs;
using Taller.Domain.Models;

namespace Taller.Application.MapperProfiles;

public class ReportProfile : Profile
{
    public ReportProfile()
    {
        CreateMap<Report, ReportDto>()
            .ReverseMap();
    }
}
