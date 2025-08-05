

namespace LunarisAPI.Domain.Entities
{
    public  class User
    {
        public long UserId { get; set; }

        public string?  ProfilePictureURL { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string? Bio { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool isBanned { get; set; } = false;
        public UserRole Role { get; set; }

        public ICollection<Playlist>  Playlists { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; }
    }


    public enum UserRole
    {
        User,
        Author,
        Admin,
        SuperAdmin,
        Dev
    }
}
