using System.Collections.Generic;

namespace Cloud.Logic.DomainModel.RequestsType
{
    public class HttpRequest : Request
    {
        public string Method { get; set; }
        public string Path { get; set; }
        public dynamic Body { get; set; }
        public IDictionary<string, string> Headers { get; set; }
    }
}