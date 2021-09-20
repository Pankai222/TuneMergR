using System.Net.Http;
using System.Threading.Tasks;
using MatBlazor;
using Microsoft.Extensions.Configuration;
using TuneMergR.Data;

namespace TuneMergR.Services
{
    public class SongService : ISongService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public SongService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }

        public async Task<PlaylistSongResult> GetSongsForPlaylist(string playlistId)
        {
            var songsForPlaylistCall =
                $"https://youtube.googleapis.com/youtube/v3/playlistItems?" +
                $"part=snippet%2CcontentDetails&maxResults=5&playlistId={playlistId}&key={_config["Youtube:ServiceApiKey"]}";

            return await _httpClient.GetJsonAsync<PlaylistSongResult>(songsForPlaylistCall);
        }

        public async Task<PlaylistChannelResult> GetPlaylists()
        {
            var playlistCall = "https://youtube.googleapis.com/youtube/v3/playlists?" +
                               "part=snippet%2CcontentDetails&maxResults=25" +
                               $"&channelId=UCTyzldDN3n79qQemELCD4FQ&key={_config["Youtube:ServiceApiKey"]}";

            return await _httpClient.GetJsonAsync<PlaylistChannelResult>(playlistCall);
        }
    }
}