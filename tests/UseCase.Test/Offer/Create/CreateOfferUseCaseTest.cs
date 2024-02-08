using Bogus;
using FluentAssertions;
using Moq;
using RockterseatAuction.API.Communication.Request;
using RockterseatAuction.API.Contracts;
using RockterseatAuction.API.Entities;
using RockterseatAuction.API.Services;
using RockterseatAuction.API.UseCases.Offers.Create;
using Xunit;

namespace UseCase.Test.Offer.Create;
public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void Success(int itemId)
    {
        var offerRepository = new Mock<IOfferRepository>();
        var mockUser = new Mock<ILoggedUser>();
        var fakeUser = new Faker<User>().Generate();
        mockUser.Setup(x => x.User()).Returns(fakeUser);
        var fakeOffer = new Faker<RequestCreateOfferJson>().Generate();
        var useCase = new CreateOfferUseCase(mockUser.Object, offerRepository.Object);

        var act = () => useCase.Execute(itemId, fakeOffer);

        act.Should().NotThrow();
    }
}
