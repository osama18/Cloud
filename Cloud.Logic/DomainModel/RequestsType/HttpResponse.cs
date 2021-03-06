using System.Collections.Generic;

namespace Cloud.Logic.DomainModel.RequestsType
{
    public class HttpResponse : Response
    {
        public StatusCode StatusCode { get; set; }
        public dynamic Body { get; set; }
        public IDictionary<string, string> Headers { get; set; }
    }
}