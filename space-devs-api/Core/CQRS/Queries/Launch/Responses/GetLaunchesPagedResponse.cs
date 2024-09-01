using Core.Materializated.Views;
using Core.Shared;
using Cross.Cutting.Helper;

namespace Core.CQRS.Queries.Launch.Responses
{
    public class GetLaunchesPagedResponse : BaseQueryResponse<Pagination<LaunchView>>
    {
        public GetLaunchesPagedResponse(bool success, string error, Pagination<LaunchView> data)
        {
            Success = success;
            Error = error;
            Data = data;
        }
    }
}