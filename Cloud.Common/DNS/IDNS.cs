namespace Cloud.Common.DNS
{
    public interface IDNS
    {
        string GenerateNewIP(bool isPublic = true);
        string ReserveIp(string domainname, bool isPublic = true);
    }
}