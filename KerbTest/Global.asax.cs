//~ Copyright (C) 2013 Zeb Bowden. zbowden@vt.edu All Rights Reserved.
//
//~ This file is part of KerbTest.
//
//~  KerbTest is distributed in the hope that it will be useful,
//~ but WITHOUT ANY WARRANTY; without even the implied warranty of
//~ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
//
//
//




using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using KerbTest;

namespace KerbTest
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
    }
}
