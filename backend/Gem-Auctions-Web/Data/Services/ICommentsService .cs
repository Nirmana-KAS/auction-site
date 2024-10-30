using Gem_Auctions_Web.Models;

namespace Gem_Auctions_Web.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
