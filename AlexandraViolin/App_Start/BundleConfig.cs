using System.Web;
using System.Web.Optimization;
using AlexandraViolin.ScriptHelpers;
using AlexandraViolin.Extensions; 

namespace AlexandraViolin
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.Bundles.UseCdn = true;

            bundles.Add(new LicensedScriptBundle("~/bundles/jquery", "https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js")
                        .Include(
                        "~/Scripts/jquery-1.7.2.min.js"
                        )); 

            bundles.Add(new LicensedScriptBundle("~/bundles/ajax", "http://ajax.aspnetcdn.com/ajax/mvc/3.0/jquery.unobtrusive-ajax.min.js").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.min.js" 
                        ));  

            bundles.Add(new LicensedScriptBundle("~/bundles/jqueryvalidate").Include(
                        "~/Scripts/jquery.validate.min.js"
                        )); 

            bundles.Add(new LicensedScriptBundle("~/bundles/jqueryunobtrusiveajax", "http://ajax.aspnetcdn.com/ajax/mvc/3.0/jquery.unobtrusive-ajax.min.js").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"
                        ));

            bundles.Add(new LicensedScriptBundle("~/bundles/jqueryvalidateunobtrusive", "http://ajax.aspnetcdn.com/ajax/mvc/5.0/jquery.validate.unobtrusive.min.js").Include(
                        "~/Scripts/jquery.validate.unobtrusive.min.js"
                        ));

            bundles.Add(new LicensedScriptBundle("~/bundles/bootstrapjs", "https://yastatic.net/bootstrap/3.1.1/js/bootstrap.min.js")
                        .Include(
                        "~/js/bootstrap.min.js"
                        )
                        );

            bundles.Add(new LicensedScriptBundle("~/bundles/violin").Include(
                        "~/js/violin.js"
                        ));

            bundles.Add(new LicensedScriptBundle("~/bundles/medi").Include(
                        "~/js/medi.js"
                        ));

            bundles.Add(new LicensedScriptBundle("~/bundles/photoswipejs").Include(
                        "~/PhotoSwipe/photoswipe.min.js",
                        "~/PhotoSwipe/photoswipe-ui-default.min.js"
                        ));

            bundles.Add(new LicensedScriptBundle("~/bundles/photoswipemanjs").Include(
                    "~/js/photoswipe.js"
                        ));

            bundles.Add(new LicensedScriptBundle("~/bundles/videojs").Include(
                        "~/js/youtube-video-player.jquery.js",
                        "~/js/jquery.mousewheel.js",
                        "~/js/perfect-scrollbar.js",
                        "~/js/jquery.powertip.js"
                        ));

            bundles.Add(new LicensedScriptBundle("~/bundles/bar-ui").Include(
                    "~/Scripts/bar-ui.js"
                    ));

            bundles.Add(new LicensedScriptBundle("~/bundles/soundmanager2").Include(
                    "~/Scripts/soundmanager2-nodebug-jsmin.js"
                    ));

            bundles.Add(new LicensedStyleBundle("~/bundles/photoswipecss").IncludeWithCssRewriteUrlTransform(
                        "~/PhotoSwipe/photoswipe.css", 
                        "~/PhotoSwipe/default-skin/default-skin.css" 
                      ));

            bundles.Add(new LicensedStyleBundle("~/bundles/css").Include(
                      "~/css/bootstrap.css",
                      "~/css/modern-business.css", 
                      "~/css/bootstrap-social.css"
                      ));

            bundles.Add(new LicensedStyleBundle("~/bundles/css/violin").IncludeWithCssRewriteUrlTransform( 
                      "~/css/violin.css" 
                      )); 

            bundles.Add(new LicensedStyleBundle("~/bundles/css/videocss").IncludeWithCssRewriteUrlTransform( 
                        "~/css/youtube-video-player.css", 
                        "~/css/perfect-scrollbar.css", 
                        "~/css/jquery.powertip-dark.css" 
                    )); 

            bundles.Add(new LicensedStyleBundle("~/bundles/css/material-icons", "https://fonts.googleapis.com/icon?family=Material+Icons")
                        .Include(
                        "~/css/material-icons-debug.css"
                      ));

            bundles.Add(new LicensedStyleBundle("~/bundles/css/bar-ui").IncludeWithCssRewriteUrlTransform(
                      "~/css/bar-ui.css"
                      ));

            if (!HttpContext.Current.IsDebuggingEnabled)
            {
                BundleTable.EnableOptimizations = true;
            }
        }
    }
}
