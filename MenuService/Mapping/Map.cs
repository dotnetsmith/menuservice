using MenuService.Application.Models;
using MenuService.ResponseModels;

namespace MenuService.Mapping
{
    public static class Map
    {
        public static UserResponse ToModel(this UserModel userModel)
        {
            return new UserResponse
            {
                Id = userModel.Id,
                Name = userModel.Name,
                Email = userModel.Email,
                Password = userModel.Password,
                CreateOn = userModel.CreateOn,
                CreateBy = userModel.CreateBy,
                UpdateOn = userModel.UpdateOn,
                UpdateBy = userModel.UpdateBy
            };
        }
    }
}
