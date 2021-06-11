using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MatBlazor;
using TuneMergR.Data;

namespace TuneMergR.Services
{
    public class SongService : ISongService
    {
        private readonly HttpClient httpClient;

        public SongService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Song>> GetSongs()
        {
            return await httpClient.GetJsonAsync<Song[]>("");
        }
    }
}