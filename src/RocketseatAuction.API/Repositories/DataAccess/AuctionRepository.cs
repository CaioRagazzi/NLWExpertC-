using Microsoft.EntityFrameworkCore;
using RockterseatAuction.API.Contracts;
using RockterseatAuction.API.Entities;

namespace RockterseatAuction.API.Repositories.DataAccess;
public class AuctionRepository : IAuctionRepository
{
    private readonly RockterseatAuctionDbContext dbContext;

    public AuctionRepository(RockterseatAuctionDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public Auction? GetCurrent()
    {
        return this.dbContext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault();
    }
}
