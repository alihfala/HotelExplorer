using lab6Dotnet.Models;

namespace lab6Dotnet.Repos
{
    public interface IHotelRepo
    {
        Task CreateHotelsAsync(HotelsModel hotel);
        Task DeleteAsync(int id);
        Task<HotelsModel> GetByIdAsync(int id);
        Task<IEnumerable<HotelsModel>> GetAllAsync();

    }
}