using Microsoft.AspNetCore.Mvc;
using RockterseatAuction.API.Entities;
using RockterseatAuction.API.UseCases.Auctins.GetCurrent;

namespace RockterseatAuction.API.Controllers;

public class AuctionController : RocketseatAuctionController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase getCurrentAuctionUseCase)
    {
        var result = getCurrentAuctionUseCase.Execute();

        if (result is null)
            return NoContent();

        return Ok(result);
    }
}
