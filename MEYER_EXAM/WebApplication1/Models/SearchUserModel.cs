using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class SearchUserModel
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }
        public List<Items> items { get; set; }
    }

    public class Items
    {
        public int id { get; set; }
        public string login { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string following_url { get; set; }
        public string followers_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public string site_admin { get; set; }
        public string score { get; set; }
    }
}