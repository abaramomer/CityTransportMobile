using System;
using System.Collections.Generic;
using ScheduleRequester.RequestParams;
using Shared.Models;

namespace ScheduleRequester.Requesters
{
    public class RoutesRequester : FileRequester<RoutesRequestParams, List<RouteModel>>
    {
        protected override List<RouteModel> Request(RoutesRequestParams request)
        {
            var routes = base.Request(request);

            routes = new List<RouteModel>()
            {
                new RouteModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "123",
                    Number = "12",
                    UniqueId = "12"
                }
            };

            return routes;
        }
    }
}