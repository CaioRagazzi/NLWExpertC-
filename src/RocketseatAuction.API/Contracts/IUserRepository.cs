using RockterseatAuction.API.Entities;

namespace RockterseatAuction.API.Contracts;
public interface IUserRepository
{
    public bool ExistUserWithEmail(string email);
    User GetUserByEmail(string email);
}
