using System.Web;
using System.Web.Optimization;

namespace AlexandraViolin
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            BundleTable.Bundles.UseCdn = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js")
                        .Include(
                        "~/Scripts/jquery-1.7.2.min.js"
                        )); 

            bundles.Add(new ScriptBundle("~/bundles/ajax", "http://ajax.aspnetcdn.com/ajax/mvc/3.0/jquery.unobtrusive-ajax.min.js").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.min.js" 
                        ));  

            bundles.Add(new ScriptBundle("~/bundles/jqueryvalidate").Include(
                        "~/Scripts/jquery.validate.min.js"
                        )); 

            bundles.Add(new ScriptBundle("~/bundles/jqueryunobtrusiveajax", "http://ajax.aspnetcdn.com/ajax/mvc/3.0/jquery.unobtrusive-ajax.min.js").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryvalidateunobtrusive", "http://ajax.aspnetcdn.com/ajax/mvc/5.0/jquery.validate.unobtrusive.min.js").Include(
                        "~/Scripts/jquery.validate.unobtrusive.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs", "https://yastatic.net/bootstrap/3.1.1/js/bootstrap.min.js")
                        .Include(
                        "~/js/bootstrap.min.js"
                        )
                        );

            bundles.Add(new ScriptBundle("~/bundles/violin").Include(
                        "~/js/violin.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/medi").Include(
                        "~/js/medi.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/photoswipejs").Include(
                        "~/PhotoSwipe/photoswipe.min.js",
                        "~/PhotoSwipe/photoswipe-ui-default.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/photoswipemanjs").Include(
                    "~/js/photoswipe.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/videojs").Include(
                        "~/js/youtube-video-player.jquery.js",
                        "~/js/jquery.mousewheel.js",
                        "~/js/perfect-scrollbar.js",
                        "~/js/jquery.powertip.js"
                        ));

            StyleBundle photoswipecss = new StyleBundle("~/bundles/photoswipecss");

            photoswipecss.Include(
                      "~/PhotoSwipe/photoswipe.css",
                      new CssRewriteUrlTransform()
                      );

            photoswipecss.Include(
                      "~/PhotoSwipe/default-skin/default-skin.css",
                      new CssRewriteUrlTransform()
                      );

            bundles.Add(photoswipecss);

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/css/bootstrap.css",
                      "~/css/modern-business.css", 
                      "~/css/bootstrap-social.css"
                      ));

            bundles.Add(new StyleBundle("~/bundles/css/violin").Include(
                      "~/css/violin.css",
                      new CssRewriteUrlTransform()
                      ));

            StyleBundle videocss = new StyleBundle("~/bundles/css/videocss");

            videocss.Include(
                      "~/css/youtube-video-player.css",
                      new CssRewriteUrlTransform()
                      );

            videocss.Include(
                      "~/css/perfect-scrollbar.css",
                      new CssRewriteUrlTransform()
                      );

            videocss.Include(
                      "~/css/jquery.powertip-dark.css",
                      new CssRewriteUrlTransform()
                      );

            bundles.Add(videocss);

            bundles.Add(new StyleBundle("~/bundles/material-icons", "https://fonts.googleapis.com/icon?family=Material+Icons")
                        .Include(
                        "~/css/material-icons-debug.css"
                        ));

            BundleTable.EnableOptimizations = true;

        }
    }
}
