namespace Cloud.Logic.DomainModel.RequestsType
{
    public enum StatusCode
    {
        Success = 200,
        ResourceCreated = 201,
        BadRequest = 400,
        Forbidden = 403,
        UnAuthorized = 401,
        PageNotFound = 404,
        Conflict = 409,
        InternalServerError = 500,
        GatWayTimeOut = 503
    }
}