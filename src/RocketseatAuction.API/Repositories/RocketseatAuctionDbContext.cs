using Microsoft.EntityFrameworkCore;
using RockterseatAuction.API.Entities;

namespace RockterseatAuction.API.Repositories;
public class RockterseatAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=/home/caio/Documents/workspace/leilaoDbNLW.db");
    }
}
