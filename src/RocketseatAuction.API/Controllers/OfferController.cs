using Microsoft.AspNetCore.Mvc;
using RockterseatAuction.API.Communication.Request;
using RockterseatAuction.API.Filters;
using RockterseatAuction.API.UseCases.Offers.Create;

namespace RockterseatAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttributes))]
public class OfferController : RocketseatAuctionController
{
    private readonly CreateOfferUseCase _createOfferUseCase;

    public OfferController(CreateOfferUseCase createOfferUseCase)
    {
        _createOfferUseCase = createOfferUseCase;
    }
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson requestCreateOfferJson)
    {
        var id = _createOfferUseCase.Execute(itemId, requestCreateOfferJson);
        return Created(string.Empty, id);
    }
}
