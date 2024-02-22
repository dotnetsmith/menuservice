using UserApplication.Data.Entities;

namespace MenuService.Application.Data.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetById(Guid userId);
    }
}
