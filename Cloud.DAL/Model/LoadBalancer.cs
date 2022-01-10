
using System.Collections.Generic;

namespace Cloud.DAL.Model
{
    public class LoadBalancer : Server
    {
        public IList<Server> RegisteredActiveServers { get; set; } = new List<Server>();
        public IList<Server> RegisteredInActiveServers { get; set; } = new List<Server>();
        public ServerSelectionStrategy ServerSelectionStrategy { get; set; }
    }
}
