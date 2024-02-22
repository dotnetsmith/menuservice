using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuService.Application.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime CreateOn { get; set; }
        public int CreateBy { get; set; }
        public DateTime UpdateOn { get; set; }
        public int UpdateBy { get; set; }
    }
}
