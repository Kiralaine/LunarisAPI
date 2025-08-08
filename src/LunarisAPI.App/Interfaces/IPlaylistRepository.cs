

using LunarisAPI.Domain.Entities;

namespace LunarisAPI.App.Interfaces
{
    public  interface IPlaylistRepository
    {
        public Task<Playlist?> SelectByIdAsync(long PlaylistID);
        public IQueryable<Playlist> SelectAll();
        public Task InsertAsync(Playlist playlist);
        Task<ICollection<Playlist>> SelectAllAsync();
        public void Update(Playlist playlist);
        public void Delete(Playlist playlist);
        public Task<int> SaveChangesAsync();

    }
}
