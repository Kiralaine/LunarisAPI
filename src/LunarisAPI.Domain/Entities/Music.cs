using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarisAPI.Domain.Entities
{
    public  class Music
    {
        public long MusicId { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string  Genre { get; set; }
        public TimeSpan  Duration { get; set; }
        public DateTime UploadDate { get; set; } = DateTime.UtcNow;
        //public 
        public ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
}
