namespace MenuService.ResponseModels
{
    public class UserResponse
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
