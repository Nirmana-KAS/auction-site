using Gem_Auctions_Web.Models;

namespace Gem_Auctions_Web.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
    }
}
