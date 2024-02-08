using RockterseatAuction.API.Entities;

namespace RockterseatAuction.API.Contracts;
public interface IOfferRepository
{
    public void Add(Offer offer);
}
