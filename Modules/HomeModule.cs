using System.Collections.Generic;
using Nancy;
using Nancy.ViewEngines.Razor;
using System;

namespace ShoeStore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Get["/brands"] = _ =>
      {
        List<Brand> allBrands = Brand.GetAll();
        return View["brands.cshtml", allBrands];
      };

      Get["/stores"] = _ =>
      {
        List<Store> allStores = Store.GetAll();
        return View["stores.cshtml", allStores];
      };

      Get["/brand/new"] = _ =>
      {
        return View["brand_form.cshtml"];
      };
      Post["/brand/new"] = _ =>
      {
        Brand newBrand = new Brand(Request.Form["brand-name"]);
        newBrand.Save();
        return View["success.cshtml"];
      };

      Get["/store/new"] = _ =>
      {
        return View["store_form.cshtml"];
      };
      Post["/store/new"] = _ =>
      {
        Store newStore = new Store(Request.Form["store-name"]);
        newStore.Save();
        return View["success.cshtml"]; 
      };
    }
  }
}
