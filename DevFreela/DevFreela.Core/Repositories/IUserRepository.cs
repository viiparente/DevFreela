using DevFreela.Core.Entities;

namespace DevFreela.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task AddAsync(User user);
        Task SaveChangesAsync();
        Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash); 
    }
}
