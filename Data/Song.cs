using System.Text.Json.Serialization;

namespace TuneMergR.Data
{
    public class Song
    {
        public SongData Snippet { get; set; }

        public class SongData
        {
            public string Title { get; set; }
            public Thumbnail Thumbnails { get; set; }
            public string Description { get; set; }
        }
        
        public class Thumbnail
        {
            public High High { get; set; }
        }
        
        public class High
        {
            public string Url { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }
    }
}