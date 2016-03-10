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
      //Arrange
      Brand testBrand = new Brand("Nike");

      //Act
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

    public void Dispose()
    {
      Brand.DeleteAll();
    }
  }
}
