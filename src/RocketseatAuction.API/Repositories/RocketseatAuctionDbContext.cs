using Microsoft.EntityFrameworkCore;
using RockterseatAuction.API.Entities;

namespace RockterseatAuction.API.Repositories;
public class RockterseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }

    public RockterseatAuctionDbContext(DbContextOptions options) : base(options)
    {

    }
}
