using System;
using System.Collections.Generic;

namespace TuneMergR.Data
{
    public class PlaylistChannelResult
    {
        public string Kind { get; set; }
        public string Id { get; set; }
        public List<Playlist> Items { get; set; }

        public class Playlist
        {
            public PlaylistData Snippet { get; set; }
            public ContentDetails ContentDetails { get; set; }

            public string Id { get; set; }
            
        }

        public class PlaylistData
        {
            public DateTime PublishedAt { get; set; }
            public string ChannelId { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public Thumbnails Thumbnails { get; set; }
            public string ChannelTitle { get; set; }
            public string DefaultLanguage { get; set; }
        }
        public class ContentDetails
        {
            public int ItemCount { get; set; }
        }
        
        public class Thumbnails
        {
            public Default Default { get; set; }
            public Medium Medium { get; set; }
            public High High { get; set; }
            public Standard Standard { get; set; }
            public Maxres Maxres { get; set; }
        }
        
        public class Default
        {
            public string Url { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        public class Medium
        {
            public string Url { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        public class High
        {
            public string Url { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        public class Standard
        {
            public string Url { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        public class Maxres
        {
            public string Url { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }
        
    }
}