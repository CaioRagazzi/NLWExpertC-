using RockterseatAuction.API.Communication.Request;
using RockterseatAuction.API.Contracts;
using RockterseatAuction.API.Entities;
using RockterseatAuction.API.Repositories;
using RockterseatAuction.API.Services;

namespace RockterseatAuction.API.UseCases.Offers.Create;
public class CreateOfferUseCase
{
    private readonly ILoggedUser _loggedUser;
    private readonly IOfferRepository _offerRepository;

    public CreateOfferUseCase(ILoggedUser loggedUser, IOfferRepository offerRepository)
    {
        _loggedUser = loggedUser;
        _offerRepository = offerRepository;
    }
    public int Execute(int itemId, RequestCreateOfferJson requestCreateOfferJson)
    {
        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            itemId = itemId,
            Price = requestCreateOfferJson.Price,
            UserId = _loggedUser.User().Id
        };

        _offerRepository.Add(offer);

        return offer.Id;
    }
}
