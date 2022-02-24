﻿using System;
using Microsoft.AspNetCore.Http;

namespace Bookstore.Infrastructure
{
    public static class UrlExtensions
    {
        //this bundles up all the info about the path
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }
}