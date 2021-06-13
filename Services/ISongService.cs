using System.Collections.Generic;
using System.Threading.Tasks;
using TuneMergR.Data;

namespace TuneMergR.Services
{
    public class ISongService
    {
        Task<IEnumerable<Song>> GetSongs()
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Playlist>> GetPlaylists()
        {
            throw new System.NotImplementedException();
        }
    }
}