using ScheduleRequester.RequestParams;

namespace ScheduleRequester.Requesters
{
    public abstract class BaseRequester<TRequest, TResponse> 
        where TRequest : BaseRequestParams
        where TResponse : class 
    {
        protected abstract TResponse Request(TRequest request);
    }
}