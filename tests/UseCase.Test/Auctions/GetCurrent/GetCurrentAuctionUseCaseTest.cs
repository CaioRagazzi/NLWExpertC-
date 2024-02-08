using Bogus;
using FluentAssertions;
using Moq;
using RockterseatAuction.API.Contracts;
using RockterseatAuction.API.Entities;
using RockterseatAuction.API.UseCases.Auctins.GetCurrent;
using Xunit;

namespace UseCase.Test.Auctions.GetCurrent;
public class GetCurrentAuctionUseCaseTest
{
    [Fact]
    public void Sucesso()
    {
        var mock = new Mock<IAuctionRepository>();
        var fakeAuction = new Faker<Auction>();
        mock.Setup(i => i.GetCurrent()).Returns(fakeAuction);
        var useCase = new GetCurrentAuctionUseCase(mock.Object);

        var auction = useCase.Execute();

        auction.Should().NotBeNull();
    }
}
