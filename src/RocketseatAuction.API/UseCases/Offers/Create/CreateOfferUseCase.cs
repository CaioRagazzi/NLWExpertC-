using RockterseatAuction.API.Communication.Request;
using RockterseatAuction.API.Entities;
using RockterseatAuction.API.Repositories;
using RockterseatAuction.API.Services;

namespace RockterseatAuction.API.UseCases.Offers.Create;
public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;

    public CreateOfferUseCase(LoggedUser loggedUser)
    {
        _loggedUser = loggedUser;
    }
    public int Execute(int itemId, RequestCreateOfferJson requestCreateOfferJson)
    {
        var repository = new RockterseatAuctionDbContext();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            itemId = itemId,
            Price = requestCreateOfferJson.Price,
            UserId = _loggedUser.User().Id
        };

        repository
                .Offers
                .Add(offer);

        repository.SaveChanges();

        return offer.Id;
    }
}
