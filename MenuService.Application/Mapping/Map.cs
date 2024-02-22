using UserApplication.Data.Entities;
using UserApplication.Models;

namespace UserApplication.Mapping
{
    public static class Map
    {
        public static UserModel ToModel(this User user)
        {
            return new UserModel
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                CreateOn = user.CreateOn,
                CreateBy = user.CreateBy,
                UpdateOn = user.UpdateOn,
                UpdateBy = user.UpdateBy
            };
        }
    }
}
