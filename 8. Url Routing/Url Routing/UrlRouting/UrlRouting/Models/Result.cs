using System.Collections.Generic;

namespace UrlRouting.Models
{
    public class Result
    {
        public string Controller { get; set; }
        public string Actio { get; set; }
        public string Action { get; internal set; }

        public Dictionary<string, object> RouteData = new Dictionary<string, object>();
    }
}