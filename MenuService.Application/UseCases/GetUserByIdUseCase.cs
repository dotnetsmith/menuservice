using MenuService.Application.Data.Repositories;
using UserApplication.Models;

namespace UserApplication.UseCases
{
    public class GetUserByIdUseCase
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserModel> Execute(Guid userId)
        {
            var user = await _userRepository.GetById(userId);

            var userModel = Mapping.Map.ToModel(user);

            return userModel;
        }
    }
}
