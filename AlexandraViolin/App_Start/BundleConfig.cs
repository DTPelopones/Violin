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

            bundles.Add(new ScriptBundle("~/bundles/bar-ui").Include(
                    "~/Scripts/bar-ui.js"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/soundmanager2").Include(
                    "~/Scripts/soundmanager2-nodebug-jsmin.js"
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

            bundles.Add(new StyleBundle("~/bundles/css/bar-ui").Include(
                      "~/css/bar-ui.css",
                      new CssRewriteUrlTransform()
                      ));

            BundleTable.EnableOptimizations = true;

        }
    }
}
