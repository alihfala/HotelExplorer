using lab6Dotnet.Data;
using lab6Dotnet.Models;
using Microsoft.EntityFrameworkCore;


namespace lab6Dotnet.Repos
{
    public class HotelsRepo : IHotelRepo
    {
        private readonly AppDbContext _db;

        public HotelsRepo(AppDbContext db)
        {
            _db = db;
        }

        public async Task CreateHotelsAsync(HotelsModel hotel)
        {
            _db.Hotels.Add(hotel);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var hotel = await _db.Hotels.FindAsync(id);
            _db.Hotels.Remove(hotel);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<HotelsModel>> GetAllAsync()
        {
            return await _db.Hotels.ToListAsync();
        }

        public async Task<HotelsModel> GetByIdAsync(int id)
        {
            return await _db.Hotels.FindAsync(id);
        }
    }
}