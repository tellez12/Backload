﻿using System.Web;
using System.Web.Mvc;

namespace Backload.Examples.Example04
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}