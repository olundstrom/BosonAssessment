namespace BosonAssessment.Components.Models
{
    /* CLASSES */

    public class YouTubeVideo
    {
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ChannelTitle { get; set; }
        public string ChannelId { get; set; }
        public string ChannelLogoUrl { get; set; }
    }

    public class YouTubeSearchResponse
    {
        public List<YouTubeVideoItem> items { get; set; }
        public string nextPageToken { get; set; }
        public string prevPageToken { get; set; }
        public YouTubePageInfo pageInfo { get; set; }
    }

    public class YouTubeVideoResponse
    {
        public List<VideoItem> items { get; set; }
    }

    public class YouTubeChannelResponse
    {
        public List<YouTubeChannelItem> items { get; set; }
    }

    public class YouTubeChannelItem
    {
        public YouTubeChannelSnippet snippet { get; set; }
    }

    public class YouTubeChannelSnippet
    {
        public YouTubeThumbnail thumbnails { get; set; }
    }

    public class YouTubePageInfo
    {
        public int totalResults { get; set; }
    }

    // For home component
    public class YouTubeVideoItem
    {
        public YouTubeVideoId id { get; set; }
        public YouTubeVideoSnippet snippet { get; set; }
    }

    // For video component
    public class VideoItem
    {
        public string id { get; set; }
        public YouTubeVideoSnippet snippet { get; set; }
    }

    public class YouTubeVideoId
    {
        public string videoId { get; set; }
    }

    public class YouTubeVideoSnippet
    {
        public string title { get; set; }
        public string channelTitle { get; set; }
        public string channelId { get; set; }
        public string channelLogoUrl { get; set; }
        public YouTubeThumbnail thumbnails { get; set; }
    }

    public class YouTubeThumbnail
    {
        public YouTubeThumbnailDetails @default { get; set; }
        public YouTubeThumbnailDetails @high { get; set; }
    }

    public class YouTubeThumbnailDetails
    {
        public string url { get; set; }
    }
}
