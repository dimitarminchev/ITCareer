using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class BusinessLogicTests
    {
        //01CreateStore
        private Type sut01 = typeof(StoreController);
        private object[] createStoreArgs01 = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private StoreController arenaController01 = new StoreController();
        private string expectedOutput01 =
            $"Store Valid Store Name was successfully registerd in the system!";

        [Test]
        public void TestCreateStore01()
        {
            var createHero = sut01.GetMethod("CreateStore");

            string checkMessage = (string)createHero.Invoke(arenaController01, createStoreArgs01);

            Assert.AreEqual(expectedOutput01, checkMessage);
        }

        //==========================================================================
        private Type sut02 = typeof(StoreController);
        private object[] createStoreArgs02 = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private StoreController arenaController02 = new StoreController();
        private string expectedOutput02 =
            $"Store Valid Store Name is already registered!";

        [Test]
        public void TestCreateStore02()
        {
            var createStore = sut02.GetMethod("CreateStore");

            createStore.Invoke(arenaController02, createStoreArgs02);
            string checkMessage = (string)createStore.Invoke(arenaController02, createStoreArgs02);

            Assert.AreEqual(expectedOutput02, checkMessage);
        }

        //02ReceiveProduct
        private Type sut03 = typeof(StoreController);
        private object[] createStoreArgs03 = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private object[] receiveProductArgs03 = { new List<string>() { "Food", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private StoreController arenaController03 = new StoreController();
        private string expectedOutput03 =
                $"Product FoodName was successfully delivered to Valid Store Name!";

        [Test]
        public void TestCreateStore03()
        {
            var receiveProduct = sut03.GetMethod("ReceiveProduct");
            var createStore = sut03.GetMethod("CreateStore");

            createStore.Invoke(arenaController03, createStoreArgs03);
            string checkMessage = (string)receiveProduct.Invoke(arenaController03, receiveProductArgs03);

            Assert.AreEqual(expectedOutput03, checkMessage);
        }

        //==========================================================================
        private Type sut04 = typeof(StoreController);
        private object[] receiveProductArgs04 = { new List<string>() { "Food", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private StoreController arenaController04 = new StoreController();
        private string expectedOutput04 =
             $"Invalid Store: Valid Store Name. Cannot find it in system!";

        [Test]
        public void TestCreateStore04()
        {
            var receiveProduct = sut04.GetMethod("ReceiveProduct");

            string checkMessage = (string)receiveProduct.Invoke(arenaController04, receiveProductArgs04);

            Assert.AreEqual(expectedOutput04, checkMessage);
        }

        //==========================================================================
        private Type sut05 = typeof(StoreController);
        private object[] createStoreArgs05 = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private object[] receiveProductArgs05 = { new List<string>() { "Invalid Type", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private StoreController arenaController05 = new StoreController();
        private string expectedOutput05 =
                $"Product Invalid Type is invalid!";

        [Test]
        public void TestCreateStore05()
        {
            var receiveProduct = sut05.GetMethod("ReceiveProduct");
            var createStore = sut05.GetMethod("CreateStore");

            createStore.Invoke(arenaController05, createStoreArgs05);
            string checkMessage = (string)receiveProduct.Invoke(arenaController05, receiveProductArgs05);

            Assert.AreEqual(expectedOutput05, checkMessage);
        }

        //==========================================================================
        private Type sut06 = typeof(StoreController);
        private object[] createStoreArgs06 = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private object[] receiveProductArgs06 = { new List<string>() { "Food", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private StoreController arenaController06 = new StoreController();
        private string expectedOutput06 =
                $"Product FoodName was already delivered to Valid Store Name!";

        [Test]
        public void TestCreateStore06()
        {
            var receiveProduct = sut06.GetMethod("ReceiveProduct");
            var createStore = sut06.GetMethod("CreateStore");

            createStore.Invoke(arenaController06, createStoreArgs06);
            receiveProduct.Invoke(arenaController06, receiveProductArgs06);
            string checkMessage = (string)receiveProduct.Invoke(arenaController06, receiveProductArgs06);

            Assert.AreEqual(expectedOutput06, checkMessage);
        }

        //==========================================================================
        private Type sut07 = typeof(StoreController);
        private object[] createStoreArgs07 = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private object[] receiveProductArgs07 = { new List<string>() { "Food", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private object[] sellProductArgs07 = { new List<string>() { "FoodName", "10", "Valid Store Name" } };
        private StoreController arenaController07 = new StoreController();
        private string expectedOutput07 =
                $"Product FoodName was successfully bought from Valid Store Name!";

        [Test]
        public void TestCreateStore07()
        {
            var sellProduct = sut07.GetMethod("SellProduct");
            var receiveProduct = sut07.GetMethod("ReceiveProduct");
            var createStore = sut07.GetMethod("CreateStore");

            createStore.Invoke(arenaController07, createStoreArgs07);
            receiveProduct.Invoke(arenaController07, receiveProductArgs07);
            string checkMessage = (string)sellProduct.Invoke(arenaController07, sellProductArgs07);

            Assert.AreEqual(expectedOutput07, checkMessage);
        }

        //==========================================================================
        private Type sut08 = typeof(StoreController);
        private object[] sellProductArgs08 = { new List<string>() { "FoodName", "10", "Valid Store Name" } };
        private StoreController arenaController08 = new StoreController();
        private string expectedOutput08 =
                $"Invalid Store: Valid Store Name. Cannot find it in system!";

        [Test]
        public void TestCreateStore08()
        {
            var sellProduct = sut08.GetMethod("SellProduct");
            string checkMessage = (string)sellProduct.Invoke(arenaController08, sellProductArgs08);

            Assert.AreEqual(expectedOutput08, checkMessage);
        }

        //==========================================================================
        private Type sut09 = typeof(StoreController);
        private object[] createStoreArgs09 = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private object[] sellProductArgs09 = { new List<string>() { "FoodName", "10", "Valid Store Name" } };
        private StoreController arenaController09 = new StoreController();
        private string expectedOutput09 =
                $"Product FoodName was already sold out!";

        [Test]
        public void TestCreateStore09()
        {
            var sellProduct = sut09.GetMethod("SellProduct");
            var createStore = sut09.GetMethod("CreateStore");

            createStore.Invoke(arenaController09, createStoreArgs09);
            string checkMessage = (string)sellProduct.Invoke(arenaController09, sellProductArgs09);

            Assert.AreEqual(expectedOutput09, checkMessage);
        }

        //==========================================================================
        private Type sut10 = typeof(StoreController);
        private object[] createStoreArgs10 = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private object[] receiveProductArgs10 = { new List<string>() { "Food", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private object[] sellProductArgs10 = { new List<string>() { "FoodName", "10", "Valid Store Name" } };
        private object[] storeInfoArgs10 = { new List<string>() { "Valid Store Name" } };
        private StoreController arenaController10 = new StoreController();
        private string expectedOutput10 =
                $"****Store: Valid Store Name <Valid Type Store>" + Environment.NewLine +
                $"****Available products: <1>" + Environment.NewLine +
                $"****** FoodName (10)" + Environment.NewLine +
                $"****Revenue: <170.50BGN>";

        [Test]
        public void TestCreateStore10()
        {
            var sellProduct = sut10.GetMethod("SellProduct");
            var receiveProduct = sut10.GetMethod("ReceiveProduct");
            var createStore = sut10.GetMethod("CreateStore");
            var storeInfo = sut10.GetMethod("StoreInfo");

            createStore.Invoke(arenaController10, createStoreArgs10);
            receiveProduct.Invoke(arenaController10, receiveProductArgs10);
            sellProduct.Invoke(arenaController10, sellProductArgs10);
            string checkMessage = (string)storeInfo.Invoke(arenaController10, storeInfoArgs10);

            Assert.AreEqual(expectedOutput10, checkMessage);
        }

        //==========================================================================
        private Type sut11 = typeof(StoreController);
        private object[] createStoreArgs11 = { new List<string>() { "Valid Store Name", "Valid Type Store" } };
        private object[] receiveProductArgs11 = { new List<string>() { "Food", "FoodName", "20", "15.50", "10", "Valid Store Name" } };
        private object[] sellProductArgs11 = { new List<string>() { "FoodName", "10", "Valid Store Name" } };
        // private object[] storeInfoArgs11 = { new List<string>() { "Valid Store Name" } };
        private StoreController arenaController11 = new StoreController();
        private string expectedOutput11 =
                $"Stores: 1" + Environment.NewLine +
                $"****Store: Valid Store Name <Valid Type Store>" + Environment.NewLine +
                $"****Available products: <1>" + Environment.NewLine +
                $"****** FoodName (10)" + Environment.NewLine +
                $"****Revenue: <170.50BGN>" + Environment.NewLine +
                $"System Store Revenues: 170.50BGN";

        [Test]
        public void TestCreateStore11()
        {
            var sellProduct = sut11.GetMethod("SellProduct");
            var receiveProduct = sut11.GetMethod("ReceiveProduct");
            var createStore = sut11.GetMethod("CreateStore");
            var shutdown = sut11.GetMethod("Shutdown");

            createStore.Invoke(arenaController11, createStoreArgs11);
            receiveProduct.Invoke(arenaController11, receiveProductArgs11);
            sellProduct.Invoke(arenaController11, sellProductArgs11);
            string checkMessage = (string)shutdown.Invoke(arenaController11, new object[] { });

            Assert.AreEqual(expectedOutput11, checkMessage);
        }
    }
}