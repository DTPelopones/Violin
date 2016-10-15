﻿using System.Web;
using System.Web.Optimization;

namespace AlexandraViolin
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/ajax").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"
                        )); 

            bundles.Add(new ScriptBundle("~/bundles/jqueryvalidate").Include(
                        "~/Scripts/jquery.validate.min.js"
                        )); 

            bundles.Add(new ScriptBundle("~/bundles/jqueryvalidateunobstrusive").Include( 
                        "~/Scripts/jquery.validate.unobstrusive.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryajaxvalidate").Include( 
                        "~/Scripts/jquery-1.10.2.min.js", 
                        "~/Scripts/jquery.unobtrusive-ajax.min.js", 
                        "~/Scripts/jquery.validate.min.js", 
                        "~/Scripts/jquery.validate.unobstrusive.min.js" 
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapviolin").Include(
                        "~/js/bootstrap.min.js",
                        "~/js/violin.js"
                        ));

            bundles.Add(new StyleBundle("~/css").Include(
                      "~/css/bootstrap.css",
                      "~/css/modern-business.css"
                      ));
        }
    }
}