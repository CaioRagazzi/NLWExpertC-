using RockterseatAuction.API.Entities;

namespace RockterseatAuction.API.Contracts;
public interface IAuctionRepository
{
    public Auction? GetCurrent();
}
