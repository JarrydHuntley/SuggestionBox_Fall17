﻿using System.Web;
using System.Web.Mvc;

namespace SuggestionBox_Fall17
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
