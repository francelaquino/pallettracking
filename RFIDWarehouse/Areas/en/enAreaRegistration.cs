﻿using System.Web.Mvc;

namespace RFIDWarehouse.Areas.en
{
    public class enAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "en";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "en_default",
                "en/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "en_default1",
               "en/{controller}/{action}/{id}/{gid}",
               new { action = "Index", id = UrlParameter.Optional, gid = UrlParameter.Optional }
           );
        }
    }
}