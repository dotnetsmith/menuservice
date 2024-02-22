using MenuService.Application.Data.Entities;
using MenuService.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuService.Application.Mapping
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
