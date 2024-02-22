using UserApplication.Data.Entities;

namespace MenuService.Application.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        Task<User> IUserRepository.GetById(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
