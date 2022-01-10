using Cloud.Logic.DomainModel;
using System.Threading.Tasks;

namespace Cloud.Logic.Services
{
    public interface ILoadBalancerServices : IServerServices
    {
        Task Register(LoadBalancer loadBalancer, Server server);

        Task Exclude(LoadBalancer loadBalancer, Server server);

        Task Include(LoadBalancer loadBalancer, Server server);
    }
}