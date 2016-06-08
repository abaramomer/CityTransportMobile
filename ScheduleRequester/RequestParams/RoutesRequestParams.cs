using Shared.Models.ModelTypes;

namespace ScheduleRequester.RequestParams
{
    public class RoutesRequestParams : BaseRequestParams
    {
        public TransportType TransportType { get; set; }
    }
}