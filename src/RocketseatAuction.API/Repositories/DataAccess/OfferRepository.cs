using RockterseatAuction.API.Contracts;
using RockterseatAuction.API.Entities;

namespace RockterseatAuction.API.Repositories.DataAccess;
public class OfferRepository : IOfferRepository
{
    private readonly RockterseatAuctionDbContext rockterseatAuctionDbContext;

    public OfferRepository(RockterseatAuctionDbContext rockterseatAuctionDbContext)
    {
        this.rockterseatAuctionDbContext = rockterseatAuctionDbContext;
    }

    public void Add(Offer offer)
    {
        this.rockterseatAuctionDbContext
                .Offers
                .Add(offer);

        this.rockterseatAuctionDbContext.SaveChanges();
    }
}
