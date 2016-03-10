using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ShoeStore
{
  public class BrandTest : IDisposable
  {
    public BrandTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=shoe_stores_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void Test_DatabaseEmptyAtFirst()
    {
        int result = Brand.GetAll().Count;

        Assert.Equal(0, result);
    }

    [Fact]
    public void Test_Equal_overrideTrueForSameDescription()
    {
      Brand firstBrand = new Brand("Nike");
      Brand secondBrand = new Brand("Nike");

      Assert.Equal(firstBrand, secondBrand);
    }

    [Fact]
    public void Test_Save()
    {
      Brand testBrand = new Brand("Nike");
      testBrand.Save();

      List<Brand> result = Brand.GetAll();
      List<Brand> testList = new List<Brand>{testBrand};

      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_Save_AssignsIdToObject()
    {
      Brand testBrand = new Brand("Nike");
      testBrand.Save();

      Brand savedBrand = Brand.GetAll()[0];

      int result = savedBrand.GetId();
      int testId = testBrand.GetId();

      //Assert
      Assert.Equal(testId, result);
    }

    [Fact]
    public void Test_Find_FindsBrandInDatabase()
    {
      Brand testBrand = new Brand("Nike");
      testBrand.Save();

      Brand foundBrand = Brand.Find(testBrand.GetId());

      Assert.Equal(testBrand, foundBrand);
    }

    [Fact]
    public void Test_AddStore_AddsStoreToBrand()
    {
      Brand testBrand = new Brand("Nike");
      testBrand.Save();

      Store testStore1 = new Store("FootLocker");
      testStore1.Save();

      Store testStore2 = new Store("Amazon");
      testStore2.Save();

      testBrand.AddStore(testStore1);
      testBrand.AddStore(testStore2);

      List<Store> result = testBrand.GetStores();
      List<Store> testList = new List<Store> {testStore1, testStore2};

      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_GetStores_ReturnsAllBrandStores()
    {
      Brand testBrand = new Brand("Nike");
      testBrand.Save();

      Store testStore1 = new Store("FootLocker");
      testStore1.Save();

      Store testStore2 = new Store("Amazon");
      testStore2.Save();

      testBrand.AddStore(testStore1);
      List<Store> savedList = testBrand.GetStores();
      List<Store> testList = new List<Store> {testStore1};

      Assert.Equal(testList, savedList);
    }

    [Fact]
    public void Test_Update_UpdateBrandInDatabase()
    {
      Brand testBrand = new Brand("Adidas");
      testBrand.Save();

      string newName = "Nike";
      testBrand.Update(newName);

      string result = testBrand.GetName();

      Assert.Equal(newName, result);
    }

    [Fact]
    public void Test_Delete_DeletesBrandFromDatabase()
    {
      Brand testBrand1 = new Brand("Nike");
      testBrand1.Save();

      Brand testBrand2 = new Brand("Adidas");
      testBrand2.Save();

      testBrand2.Delete();
      List<Brand> resultBrands = Brand.GetAll();
      List<Brand> testList = new List<Brand> {testBrand1};

      Assert.Equal(testList, resultBrands);
    }

    [Fact]
    public void Test_Delete_DeleteBrandAssociationFromDatabase()
    {
      Brand testBrand = new Brand("Nike");
      testBrand.Save();

      Store testStore = new Store("FootLocker");
      testStore.Save();

      testBrand.AddStore(testStore);
      testBrand.Delete();

      List<Brand> resultStoreBrands = testStore.GetBrands();
      List<Brand> testStoreBrands = new List<Brand> {};

      Assert.Equal(testStoreBrands, resultStoreBrands);
    }

    public void Dispose()
    {
      Brand.DeleteAll();
      Store.DeleteAll();
    }
  }
}
