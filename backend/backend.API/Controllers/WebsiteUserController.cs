using backend.API.Controllers.Base;
using backend.Application.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace backend.API.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class WebsiteUserController : BaseController
    {
        readonly IMediator _mediator;

        public WebsiteUserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<ActionResult<List<WebsiteUserResult>>> Get(CancellationToken ct)
        {
            return await _mediator.Send(WebsiteUserResult, ct);
        }
    }
}
