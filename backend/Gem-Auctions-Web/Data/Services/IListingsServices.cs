using Gem_Auctions_Web.Models;

namespace Gem_Auctions_Web.Data.Services
{
    public interface IListingsServices
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);
        Task<Listing> GetById(int? id);
        Task SaveChange();
    }
}
