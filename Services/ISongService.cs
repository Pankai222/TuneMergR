using System.Collections.Generic;
using System.Threading.Tasks;
using TuneMergR.Data;

namespace TuneMergR.Services
{
    public interface ISongService
    {
        Task<PlaylistSongResult> GetSongsForPlaylist(string playlistId);

        Task<PlaylistChannelResult> GetPlaylists();
    }
}