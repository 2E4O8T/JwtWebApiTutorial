using JwtWebApiTutorial.Data;
using JwtWebApiTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtWebApiTutorial.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _appDbContext.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _appDbContext.Users.FindAsync(id);
        }

        public async Task<int> CreateAsync(User user)
        {
            _appDbContext.Users.Add(user);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {  
            _appDbContext.Users.Update(user);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var user = await _appDbContext.Users.FindAsync(id); 
            _appDbContext.Users.Remove(user);
            return await _appDbContext.SaveChangesAsync();
        }
    }
}
