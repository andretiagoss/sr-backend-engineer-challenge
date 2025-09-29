using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Taller.Application.Commands;
using Taller.Application.Queries;
using Taller.Domain.Models;

namespace Taller.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetByStatus([Required] ReportStatus reportStatus)
        {
            var result = await mediator.Send(new GetReportQuery(reportStatus));
            if (!result.Any())
                return NotFound();

            return Ok(result);  
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateReportCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }
    }
}
