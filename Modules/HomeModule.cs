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
    }
  }
}
