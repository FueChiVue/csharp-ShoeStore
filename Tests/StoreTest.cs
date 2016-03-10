using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ShoeStore
{
  public class StoreTest : IDisposable
  {
    public StoreTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=shoe_stores_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void Test_DatabaseEmptyAtFirst()
    {
      //Arrange, Act
      int result = Store.GetAll().Count;

      //Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void Test_ReturnsTrueForSameName()
    {
      //Arrange, Act
      Store firstStore = new Store("FootLocker");
      Store secondStore = new Store("FootLocker");

      //Assert
      Assert.Equal(firstStore, secondStore);
    }

    [Fact]
    public void Test_Save()
    {
      Store testStore = new Store("FootLocker");
      testStore.Save();

      List<Store> result = Store.GetAll();
      List<Store> testList = new List<Store> {testStore};

      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_Save_AssignsIdToObject()
    {
      Store testStore = new Store("FootLocker");
      testStore.Save();

      Store savedStore = Store.GetAll()[0];

      int resultId = savedStore.GetId();
      int testId = testStore.GetId();

      Assert.Equal(testId, resultId);
    }

    [Fact]
    public void Test_Find_FindsStoreInDatabase()
    {
      Store testStore = new Store("FootLocker");
      testStore.Save();

      Store foundStore = Store.Find(testStore.GetId());

      Assert.Equal(testStore, foundStore);
    }

    [Fact]
    public void Test_AddBrand_AddsBrandToStore()
    {
      Store testStore = new Store("Amazon");
      testStore.Save();

      Brand testBrand1 = new Brand("Nike");
      testBrand1.Save();

      Brand testBrand2 = new Brand("Under Armor");
      testBrand2.Save();

      testStore.AddBrand(testBrand1);
      testStore.AddBrand(testBrand2);

      List<Brand> result = testStore.GetBrands();
      List<Brand> testList = new List<Brand> {testBrand1, testBrand2};

      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_GetBrands_ReturnsAllStoreBrands()
    {
      Store testStore = new Store("Amazon");
      testStore.Save();

      Brand testBrand1 = new Brand("Nike");
      testBrand1.Save();

      Brand testBrand2 = new Brand("Under Armor");
      testBrand2.Save();

      testStore.AddBrand(testBrand1);
      List<Brand> savedList = testStore.GetBrands();
      List<Brand> testList = new List<Brand> {testBrand1};

      Assert.Equal(testList, savedList);
    }

    [Fact]
    public void Test_Update_UpdatesStoreInDatabase()
    {
      Store testStore = new Store("Amazon");
      testStore.Save();

      string newName = "FootLocker";
      testStore.Update(newName);

      string result = testStore.GetName();

      Assert.Equal(newName, result);
    }

    [Fact]
    public void Test_Delete_DeletesStoreFromDatabase()
    {
      Store testStore1 = new Store("FootLocker");
      testStore1.Save();

      Store testStore2 = new Store("Amazon");
      testStore2.Save();

      testStore1.Delete();
      List<Store> resultStores = Store.GetAll();
      List<Store> testList = new List<Store> {testStore2};

      Assert.Equal(testList, resultStores);
    }

    public void Dispose()
    {
      Store.DeleteAll();
      Brand.DeleteAll();
    }
  }
}
