using backend.Application.User;
using backend.Application.WebsiteUser.Queries.Get;
using MediatR;

namespace backend.API.Application.WebsiteUser.Queries.Get;

public class WebsiteUserQueryHandler : IRequestHandler<WebsiteUserQuery, List<WebsiteUserResult>>
{
    public Task<List<WebsiteUserResult>> Handle(WebsiteUserQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
