using JwtWebApiTutorial.Models;

namespace JwtWebApiTutorial.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetByIdAsync(int id);
        Task<int> CreateAsync(User user);
        Task UpdateAsync(User user);
        Task<int> DeleteAsync(int id);
    }
}
