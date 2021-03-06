﻿using Bit.Owin.Contracts;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;

namespace Bit.Owin.Implementations
{
    public class AspNetCoreRouteValuesProvider : IRouteValuesProvider
    {
        public virtual IDictionary<string, object?> PopulateRouteValuesDictionary(object routeValuesObj)
        {
            return new RouteValueDictionary(routeValuesObj);
        }
    }
}
