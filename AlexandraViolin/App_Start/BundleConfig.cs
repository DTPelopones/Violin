using System.Web;
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
                        "~/Scripts/jquery.validate.unobtrusive.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapviolin").Include(
                        "~/js/bootstrap.min.js",
                        "~/js/violin.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/js/bootstrap.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/photoswipejs").Include(
                        "~/PhotoSwipe/photoswipe.min.js",
                        "~/PhotoSwipe/photoswipe-ui-default.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/photoswipemanjs").Include(
                    "~/js/photoswipe.js"
            ));

            bundles.Add(new StyleBundle("~/photoswipecss").Include(
                      "~/PhotoSwipe/photoswipe.css",
                      "~/PhotoSwipe/default-skin/default-skin.css"
                      ));

            bundles.Add(new StyleBundle("~/css").Include(
                      "~/css/bootstrap.css",
                      "~/css/modern-business.css",
                      "~/css/font-awesome.min.css",
                      "~/css/bootstrap-social.css"
                      ));

            bundles.Add(new StyleBundle("~/css/violin").Include(
                      "~/css/violin.css"
                      ));

            BundleTable.EnableOptimizations = false;
        }
    }
}
