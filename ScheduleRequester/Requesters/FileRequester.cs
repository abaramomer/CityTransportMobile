using ScheduleRequester.RequestParams;

namespace ScheduleRequester.Requesters
{
    public class FileRequester<TRequest, TResponse> : BaseRequester<TRequest, TResponse> 
        where TRequest : BaseRequestParams
        where TResponse : class
    {
        protected override TResponse Request(TRequest request)
        {
            //read from file
            return null;
        }
    }
}