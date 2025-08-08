namespace LunarisAPI.Domain.Entities
{
    public class Playlist
    {
        public long PlaylistId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CoverFileId { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public ICollection<Music> Musics { get; set; } = new List<Music>();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
