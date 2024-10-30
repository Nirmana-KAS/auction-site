using Gem_Auctions_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Gem_Auctions_Web.Data.Services
{
    public class BidsService : IBidsService
    {
        private readonly ApplicationDbContext _context;

        public BidsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Bid bid)
        {
            _context.Bids.Add(bid);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Bid> GetAll()
        {
            var applicationDbContext = from a in _context.Bids.Include(l => l.Listing).ThenInclude(l => l.User)
                                       select a;
            return applicationDbContext;
        }

        public Task<List<Bid>> GetExpiredBidsAsync()
        {
            throw new NotImplementedException();
        }

        public Task Update(Bid bid)
        {
            throw new NotImplementedException();
        }
    }
}
