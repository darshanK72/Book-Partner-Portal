using Book_Portal_API.Models;
using System.Diagnostics.CodeAnalysis;

namespace Book_Portal_API.Payloads
{
    public class TitlePublishRequest
    {
        public string title_id { get; set; }
        public string title { get; set; } = null!;
        public string type { get; set; } = null!;
        public string? pub_id { get; set; }
        public decimal? price { get; set; }
        public decimal? advance { get; set; }
        public int? royalty { get; set; }
        public int? ytd_sales { get; set; }
        public string? notes { get; set; }
        public DateTime pubdate { get; set; }

        public List<TitleauthorPublishRequest> titleauthors { get; set; }
    }
}
