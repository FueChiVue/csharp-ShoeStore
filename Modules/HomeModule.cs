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

      Get["/brand/{id}"] = parameters =>
      {
        Dictionary<string, object> model = new Dictionary<string, object> ();
        Brand selectedBrand = Brand.Find(parameters.id);
        List<Store> brandStores = selectedBrand.GetStores();
        List<Store> allStores = Store.GetAll();
        model.Add("brand", selectedBrand);
        model.Add("brandStores", brandStores);
        model.Add("allStores", allStores);
        return View["brand.cshtml", model];
      };
      Post["/brand/add_store"] = _ =>
      {
        Brand brand = Brand.Find(Request.Form["brand-id"]);
        Store store = Store.Find(Request.Form["store-id"]);
        brand.AddStore(store);
        return View["success.cshtml"];
      };

      Get["/store/{id}"] = parameters =>
      {
        Dictionary<string, object> model = new Dictionary<string, object> ();
        Store selectedStore = Store.Find(parameters.id);
        List<Brand> storeBrands = selectedStore.GetBrands();
        List<Brand> allBrands = Brand.GetAll();
        model.Add("store", selectedStore);
        model.Add("storeBrands", storeBrands);
        model.Add("allBrands", allBrands);
        return View["store.cshtml", model];
      };
      Post["/store/add_brand"] = _ =>
      {
        Brand brand = Brand.Find(Request.Form["brand-id"]);
        Store store = Store.Find(Request.Form["store-id"]);
        store.AddBrand(brand);
        return View["success.cshtml"];
      };

      Get["/brand/edit/{id}"] = parameters =>
      {
        Brand selectedBrand = Brand.Find(parameters.id);
        return View["brand_edit.cshtml", selectedBrand];
      };
      Patch["/brand/edit/{id}"]= parameters =>
      {
        Brand selectedBrand = Brand.Find(parameters.id);
        selectedBrand.Update(Request.Form["brand-name"]);
        return View["success.cshtml"];
      };

      Get["/store/edit/{id}"] = parameters =>
      {
        Store selectedStore = Store.Find(parameters.id);
        return View["store_edit.cshtml", selectedStore];
      };
      Patch["/store/edit/{id}"]= parameters =>
      {
        Store selectedStore = Store.Find(parameters.id);
        selectedStore.Update(Request.Form["store-name"]);
        return View["success.cshtml"];
      };

      Get["/brand/delete/{id}"] = parameters =>
      {
        Brand selectedBrand = Brand.Find(parameters.id);
        return View["brand_delete.cshtml", selectedBrand];
      };
      Delete["/brand/delete/{id}"] = parameters =>
      {
        Brand selectedBrand = Brand.Find(parameters.id);
        selectedBrand.Delete();
        return View["success.cshtml"];
      };

      Get["/store/delete/{id}"] = parameters =>
      {
        Store selectedStore = Store.Find(parameters.id);
        return View["store_delete.cshtml", selectedStore];
      };
      Delete["/store/delete/{id}"] = parameters =>
      {
        Store selectedStore = Store.Find(parameters.id);
        selectedStore.Delete();
        return View["success.cshtml"];
      };

      Post["/brands/delete/all"] = _ =>
      {
        Brand.DeleteAll();
        return View["cleared.cshtml"];
      };
      Post["/stores/delete/all"] = _ =>
      {
        Store.DeleteAll();
        return View["cleared.cshtml"];
      };
    }
  }
}
