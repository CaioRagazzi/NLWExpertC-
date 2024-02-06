using Microsoft.EntityFrameworkCore;
using RockterseatAuction.API.Entities;
using RockterseatAuction.API.Repositories;

namespace RockterseatAuction.API.UseCases.Auctins.GetCurrent;
public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RockterseatAuctionDbContext();
        return repository
                .Auctions
                .Include(auction => auction.Items)
                .First();
    }
}
