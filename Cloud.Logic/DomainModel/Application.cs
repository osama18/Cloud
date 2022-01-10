namespace Cloud.Logic.DomainModel
{
    public interface IApplication
    {
        Response Execute(Request request);
    }
}