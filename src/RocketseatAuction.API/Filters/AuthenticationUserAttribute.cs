using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RockterseatAuction.API.Repositories;

namespace RockterseatAuction.API.Filters;
public class AuthenticationUserAttributes : AuthorizeAttribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        try
        {
            var token = TokenOnRequest(context.HttpContext);

            var repository = new RockterseatAuctionDbContext();

            var email = FromBase64String(token);

            var exists = repository.Users.Any(user => user.Email.Equals(email));

            if (!exists)
            {
                context.Result = new UnauthorizedObjectResult("Email not valid");
            }
        }
        catch (System.Exception ex)
        {
            context.Result = new UnauthorizedObjectResult(ex.Message);
        }
    }

    private string TokenOnRequest(HttpContext httpContext)
    {
        var authentication = httpContext.Request.Headers.Authorization.ToString();

        return authentication["Bearer ".Length..];
    }

    private string FromBase64String(string base64)
    {
        var data = Convert.FromBase64String(base64);

        return System.Text.Encoding.UTF8.GetString(data);
    }
}
