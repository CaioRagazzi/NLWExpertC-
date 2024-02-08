using Microsoft.EntityFrameworkCore;
using RockterseatAuction.API.Contracts;
using RockterseatAuction.API.Entities;
using RockterseatAuction.API.Repositories;
using RockterseatAuction.API.Repositories.DataAccess;

namespace RockterseatAuction.API.UseCases.Auctins.GetCurrent;
public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository auctionRepository;

    public GetCurrentAuctionUseCase(IAuctionRepository auctionRepository)
    {
        this.auctionRepository = auctionRepository;
    }
    public Auction? Execute()
    {
        return this.auctionRepository.GetCurrent();
    }
}
