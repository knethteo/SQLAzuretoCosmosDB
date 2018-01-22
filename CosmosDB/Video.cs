using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CosmosDB
{
    public class Video
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("url")]
        public string url;
        //hello

        //[JsonConverter(typeof(IsoDateTimeConverter))]
        //[JsonProperty("title")]
        //public DateTime title;

        [JsonProperty("title")]
        public string title;

        [JsonProperty("tags")]
        public string[] tags;

        [JsonProperty("previewImage")]
        public string previewImage;

        [JsonProperty("type")]
        public string type;

        [JsonProperty("totalviewCount")]
        public int totalviewCount;

        [JsonProperty("rating")]
        public double rating;

        [JsonProperty("ratingCount")]
        public int ratingCount;

        [JsonProperty("totalViewCount")]
        public int totalViewCount;

        [JsonProperty("authors")]
        public string[] authors;

        [JsonProperty("primaryAudience")]
        public string primaryAudience;


    }
}
