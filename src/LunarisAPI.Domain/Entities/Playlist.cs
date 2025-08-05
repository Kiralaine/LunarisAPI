using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarisAPI.Domain.Entities
{
    public class Playlist
    {
        public long PlaylistId { get; set; }
        public string Name { get; set; }
        public string? PictureURL { get; set; }
        public string Description { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public ICollection<Music> Musics { get; set; } = new List<Music>();
    }
}
    