using RockterseatAuction.API.Contracts;
using RockterseatAuction.API.Entities;

namespace RockterseatAuction.API.Repositories.DataAccess;
public class UserRepository : IUserRepository
{
    private readonly RockterseatAuctionDbContext _rockterseatAuctionDbContext;

    public UserRepository(RockterseatAuctionDbContext rockterseatAuctionDbContext)
    {
        _rockterseatAuctionDbContext = rockterseatAuctionDbContext;
    }

    public bool ExistUserWithEmail(string email)
    {
        return _rockterseatAuctionDbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email)
    {
        return _rockterseatAuctionDbContext.Users.First(user => user.Email.Equals(email));
    }
}
