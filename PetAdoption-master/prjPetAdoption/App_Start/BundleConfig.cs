﻿using System.Web;
using System.Web.Optimization;

namespace prjPetAdoption
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                       ));
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/imgup/imgUpload.js"
                         ));

            bundles.Add(new ScriptBundle("~/bundles/masonry").Include(
                       "~/Scripts/masonry.pkgd*"
                       ));
            bundles.Add(new ScriptBundle("~/bundles/index").Include(
                       "~/Scripts/index.js"
                       ));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"

                      ));
            bundles.Add(new ScriptBundle("~/bundles/FAQ/FAQ").Include(
                     "~/Scripts/FAQ/FAQ.js"
                     ));
            bundles.Add(new ScriptBundle("~/bundles/animalDetail/animalDetailJS").Include(
                    "~/Scripts/animalDetailjs/animalDetail.js",
                    "~/Scripts/animalDetailjs/bootstrap-lightbox.js",
                    "~/Scripts/animalDetailjs/bootstrap-lightbox.min.js"
                    ));
            bundles.Add(new ScriptBundle("~/bundles/showForAdopt").Include(
                      "~/Scripts/showForAdopt/AdoptedNavigate.js"                    
                     )); 

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/masonry.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/font-awesome.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/showForAdopt").Include(
                    "~/Content/showForAdopt/AdoptedNavigate.css"  
                        ));

            bundles.Add(new StyleBundle("~/Content/anidetail").Include(
                    "~/Content/animalDetailcss/animalDetails.css",
                    "~/Content/animalDetailcss/bootstrap-lightbox.css",
                    "~/Content/animalDetailcss/bootstrap-lightbox.min.css"
                        ));
        }
    }
}
