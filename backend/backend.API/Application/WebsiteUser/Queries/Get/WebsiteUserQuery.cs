using backend.Application.User;
using MediatR;

namespace backend.Application.WebsiteUser.Queries.Get;

public class WebsiteUserQuery : IRequest<List<WebsiteUserResult>> { }
