using BosonAssessment.Components.Pages;
using Google.Apis.YouTube.v3.Data;
using System.Threading.Channels;

namespace BosonAssessment.Components.Models
{
    /* CLASSES */

    // Call to store YouTube video content
    public class YouTubeVideo
    {
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string ThumbnailUrl { get; set; }
        public string ChannelTitle { get; set; }
        public string ChannelId { get; set; }
        public string ChannelLogoUrl { get; set; }

        // Constructor
        public YouTubeVideo()
        {
            VideoId = string.Empty;
            Title = string.Empty;
            ThumbnailUrl = string.Empty;
            ChannelTitle = string.Empty;
            ChannelId = string.Empty;
            ChannelLogoUrl = string.Empty;
        }

    }

    // Class to store search response data
    public class YouTubeSearchResponse
    {
        public List<YouTubeVideoItem> items { get; set; }
        public string nextPageToken { get; set; }
        public string prevPageToken { get; set; }
        public YouTubePageInfo pageInfo { get; set; }

        // Constructor
        public YouTubeSearchResponse()
        {
            items = new List<YouTubeVideoItem>();
            nextPageToken = string.Empty;
            prevPageToken = string.Empty;
            pageInfo = new YouTubePageInfo();
        }
    }

    // Class to store video response data
    public class YouTubeVideoResponse
    {
        public List<VideoItem> items { get; set; }

        // Constructor
        public YouTubeVideoResponse()
        {
            items = new List<VideoItem>();
        }
    }

    // Class to store channel response data
    public class YouTubeChannelResponse
    {
        public List<YouTubeChannelItem> items { get; set; }

        // Constructor
        public YouTubeChannelResponse()
        {
            items = new List<YouTubeChannelItem>();
        }

    }

    // Class to store channel items
    public class YouTubeChannelItem
    {
        public YouTubeChannelSnippet snippet { get; set; }

        // Constructor
        public YouTubeChannelItem()
        {
            snippet = new YouTubeChannelSnippet();
        }
    }

    // Class to store channel snippet
    public class YouTubeChannelSnippet
    {
        public YouTubeThumbnail thumbnails { get; set; }

        // Constructor
        public YouTubeChannelSnippet()
        {
            thumbnails = new YouTubeThumbnail();
        }
    }

    // Class to store page info
    public class YouTubePageInfo
    {
        public int totalResults { get; set; }
    }

    // For home component - class to store video items
    public class YouTubeVideoItem
    {
        public YouTubeVideoId id { get; set; }
        public YouTubeVideoSnippet snippet { get; set; }

        // Constructor
        public YouTubeVideoItem()
        {
            id = new YouTubeVideoId();
            snippet = new YouTubeVideoSnippet();
        }
    }

    // For video component - class to store video items
    public class VideoItem
    {
        public string id { get; set; }
        public YouTubeVideoSnippet snippet { get; set; }

        // Constructor
        public VideoItem()
        {
            id = string.Empty;
            snippet = new YouTubeVideoSnippet();
        }
    }

    // Class to store video id
    public class YouTubeVideoId
    {
        public string videoId { get; set; }

        // Constructor
        public YouTubeVideoId()
        {
            videoId = string.Empty;
        }
    }

    // Class to store video snippet
    public class YouTubeVideoSnippet
    {
        public string title { get; set; }
        public string channelTitle { get; set; }
        public string channelId { get; set; }
        public string channelLogoUrl { get; set; }
        public YouTubeThumbnail thumbnails { get; set; }

        // Constructor
        public YouTubeVideoSnippet()
        {
            title = string.Empty;
            channelTitle = string.Empty;
            channelId = string.Empty;
            channelLogoUrl = string.Empty;
            thumbnails = new YouTubeThumbnail();
        }
    }

    // Class to store video thumbnail
    public class YouTubeThumbnail
    {
        public YouTubeThumbnailDetails @default { get; set; }
        public YouTubeThumbnailDetails @high { get; set; }

        // Constructor
        public YouTubeThumbnail()
        {
            @default = new YouTubeThumbnailDetails();
            @high = new YouTubeThumbnailDetails();
        }
    }

    // Class to store video thumbnail url
    public class YouTubeThumbnailDetails
    {
        public string url { get; set; }

        // Constructor
        public YouTubeThumbnailDetails()
        {
            url = string.Empty;
        }
    }
}
