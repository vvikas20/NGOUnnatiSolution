﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace NGOUnnati.WebApp.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            ///Script bundle
            ///
            ScriptBundle thirdPartyScripts = new ScriptBundle("~/Scripts/ThirdParty");
            thirdPartyScripts.Include(
                "~/Scripts/JQuery/jquery-3.3.1.js",
                "~/Scripts/Bootstrap/bootstrap.js"
                );

            ///Style bundle
            ///
            StyleBundle thirdPartyStyles = new StyleBundle("~/Styles/ThirdParty");
            thirdPartyStyles.Include(
                "~/Content/Bootstrap/css/bootstrap.css"
                );

            bundles.Add(thirdPartyScripts);
            bundles.Add(thirdPartyStyles);

            BundleTable.EnableOptimizations = true;
        }
    }
}