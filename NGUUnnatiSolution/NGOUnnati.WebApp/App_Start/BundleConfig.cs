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
            thirdPartyStyles
                .Include("~/Content/Bootstrap/css/bootstrap.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/Font-Awesome/font-awesome.min.css", new CssRewriteUrlTransform());

            ///Apllication Wide styles
            ///
            StyleBundle applicationWideStyles = new StyleBundle("~/Styles/ApplicationWide");
            thirdPartyStyles.Include(
                "~/Content/CSS/Application/appStyle.css",
                "~/Content/CSS/Application/Pretty-Footer.css",
                "~/Content/CSS/Application/Google-Style-Login.css"
                );

            bundles.Add(thirdPartyScripts);
            bundles.Add(thirdPartyStyles);
            bundles.Add(applicationWideStyles);

            BundleTable.EnableOptimizations = true;
        }
    }
}