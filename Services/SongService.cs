using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MatBlazor;
using Microsoft.Extensions.Configuration;
using TuneMergR.Data;

namespace TuneMergR.Services
{
    public class SongService : ISongService
    {
        private readonly HttpClient httpClient;
        private string _youtubeAPIKEY = null;
        private readonly IConfiguration _config;

        public SongService(HttpClient httpClient, IConfiguration config)
        {
            this.httpClient = httpClient;
            _config = config;
        }

        public async Task<IEnumerable<Song>> GetSongs()
        {
            _youtubeAPIKEY = _config["YoutubeAPIKEY"];
            return await httpClient.GetJsonAsync<Song[]>($"");
        }

        public async Task<IEnumerable<Playlist>> GetPlaylists()
        {
            _youtubeAPIKEY = _config["YoutubeAPIKEY"];
            var playlistCall = "https://youtube.googleapis.com/youtube/v3/playlists?" +
                               "part=snippet%2CcontentDetails&maxResults=25" +
                               $"&mine=true&key={_youtubeAPIKEY} HTTP/1.1";
            
            return await httpClient.GetJsonAsync<Playlist[]>(playlistCall);
        }
    }
}