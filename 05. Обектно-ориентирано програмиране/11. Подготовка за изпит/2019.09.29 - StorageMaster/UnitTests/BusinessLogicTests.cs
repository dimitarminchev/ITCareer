using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StorageMaster;

namespace UnitTests
{
    [TestClass]
    public class BusinessLogicTests
    {
        // MUST exist within project, otherwise a Compile Time Error will be thrown.
        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        // Test 01
        [TestMethod]
        public void ValidateControllerExists()
        {
            var typesToAssert = new[] { "StorageMaster" };
            foreach (var typeName in typesToAssert)
            {
                Assert.IsNotNull(GetType(typeName), $"{typeName} type doesn't exist!");
            }
        }

        private static Type GetType(string name)
        {
            var type = ProjectAssembly.GetTypes().FirstOrDefault(t => t.Name == name);
            return type;
        }
        
        private class Method
        {
            public Method(Type returnType, string name, params Type[] parameterTypes)
            {
                this.ReturnType = returnType;
                this.Name = name;
                this.ParameterTypes = parameterTypes;
            }

            public Type ReturnType { get; }

            public string Name { get; }

            public Type[] ParameterTypes { get; }
        }

        // Test 2
        [TestMethod]
        public void ValidateDungeonMasterMethodsExist()
        {
            var storageMasterType = GetType("StorageMaster");

            Assert.IsNotNull(storageMasterType, "DungeonMaster class doesn\'t exist!");

            var methodsToAssert = new[]
            {
            new Method(typeof(string), "AddProduct"),
            new Method(typeof(string), "RegisterStorage"),
            new Method(typeof(string), "SelectVehicle"),
            new Method(typeof(string), "LoadVehicle"),
            new Method(typeof(string), "SendVehicleTo"),
            new Method(typeof(string), "UnloadVehicle"),
            new Method(typeof(string), "GetStorageStatus"),
            new Method(typeof(string), "GetSummary"),
            };

            foreach (var expectedMethod in methodsToAssert)
            {
                var expectedReturnType = expectedMethod.ReturnType;
                var methodName = expectedMethod.Name;

                var method = storageMasterType.GetMethod(methodName);

                Assert.IsNotNull(method, $"{storageMasterType}.{methodName} doesn't exist!");

                var actualReturnType = method.ReturnType;
                Assert.AreEqual(actualReturnType, expectedReturnType,
                    $"{storageMasterType}.{methodName} returns {actualReturnType} instead of {expectedReturnType}");
            }
        }

        // Test 03
        [TestMethod]
        public void CreateValidProduct()
        {
            var types = new[]
            {
            GetType("Gpu"),
            GetType("HardDrive"),
            GetType("Ram"),
            GetType("SolidStateDrive"),
            };

            var parameters = new object[]
            {
            2.5
            };

            foreach (var type in types)
            {
                object instance = null;

                try
                {
                    Action act = () => instance = CreateObjectInstance(type, parameters);
                    act.Invoke();
                }
                catch (Exception)
                {
                    Assert.Fail($"Exception occurred while attempting to create a {type}");
                }

                Assert.AreEqual(GetPropertyValue(instance, "Price"), 2.5, "Price isn't set correctly");
            }
        }

        private static object GetPropertyValue(object instance, string name)
        {
            var value = instance.GetType().GetProperty(name).GetValue(instance);
            return value;
        }

        private static object CreateObjectInstance(Type type, params object[] parameters)
        {
            var obj = Activator.CreateInstance(type, parameters);
            return obj;
        }

        // Test 04
        [TestMethod]
        public void CreateInvalidProduct()
        {
            var types = new[]
            {
            GetType("Gpu"),
            GetType("HardDrive"),
            GetType("Ram"),
            GetType("SolidStateDrive"),
            };

            var parameters = new object[] { -2.5 };

            foreach (var type in types)
            {
                Action act = () => CreateObjectInstance1(type, parameters);
                Assert.IsNotNull(act, $"No exception was thrown attempting to create a {type} with invalid price");            
            }
        }
        private static object CreateObjectInstance1(Type type, params object[] parameters)
        {
            try
            {
                var obj = Activator.CreateInstance(type, parameters);
                return obj;
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }

        // Test 05
        [TestMethod]
        public void CreateValidStorage()
        {
            var types = new[]
              {
            GetType("Warehouse"),
            GetType("DistributionCenter"),
            GetType("AutomatedWarehouse"),
        };

            var parameters = new object[]
            {
            "TestStorage"
            };

            foreach (var type in types)
            {
                object instance = null;

                try
                {
                    Action act = () => instance = CreateObjectInstance(type, parameters);
                    act.Invoke();                   
                }
                catch (Exception)
                {
                    Assert.Fail("Exception occurred while attempting to create a {type}");
                }

                Assert.AreEqual(GetPropertyValue(instance, "Name"), "TestStorage", "Name isn't set correctly");
            }
        }


        // Test 06
        [TestMethod]
        public void CreateInvalidStorage1()
        {
            var types = new[]
             {
            GetType("Warehouse"),
            GetType("DistributionCenter"),
            GetType("AutomatedWarehouse"),
        };

            var expectedStorageGarageSlots = new[]
            {
            10, 5, 2
        };

            var parameters = new object[]
            {
            "TestStorage"
            };

            for (var typeIndex = 0; typeIndex < types.Length; typeIndex++)
            {
                var storageType = types[typeIndex];
                var instance = CreateObjectInstance(storageType, parameters);

                var expectedGarageSlots = expectedStorageGarageSlots[typeIndex];
                var actualGarageSlots = GetPropertyValue(instance, "GarageSlots");

                Assert.AreEqual(actualGarageSlots, expectedGarageSlots, $"{storageType} has incorrect garage slot count!");
            }
        }


        // Test 07
        [TestMethod]
        public void CreateInvalidStorage2()
        {
            var types = new[]
              {
            GetType("Warehouse"),
            GetType("DistributionCenter"),
            GetType("AutomatedWarehouse"),
        };

            var defaultVehiclesForTypes = new[]
            {
            new[]
            {
                GetType("Semi"),
                GetType("Semi"),
                GetType("Semi"),
            },
            new[]
            {
                GetType("Van"),
                GetType("Van"),
                GetType("Van"),
            },
            new[]
            {
                GetType("Truck"),
            },
        };

            var parameters = new object[]
            {
            "TestStorage"
            };

            for (var typeIndex = 0; typeIndex < types.Length; typeIndex++)
            {
                var storageType = types[typeIndex];
                var instance = CreateObjectInstance(storageType, parameters);

                var garage = GetPropertyValue(instance, "Garage");

                var defaultVehiclesForType = defaultVehiclesForTypes[typeIndex];
                for (int garageIndex = 0; garageIndex < defaultVehiclesForType.Length; garageIndex++)
                {
                    var expectedVehicleType = defaultVehiclesForType[garageIndex];

                    var actualVehicleType = ((IEnumerable)garage)
                        .Cast<object>()
                        .ElementAt(garageIndex)
                        .GetType();

                    Assert.AreEqual(actualVehicleType,expectedVehicleType, $"Default vehicle at slot {typeIndex} is incorrect!");
                }
            }
        }


        // Test 08
        [TestMethod]
        public void TestGetVehicle1()
        {
            var storage = CreateObjectInstance(GetType("Warehouse"), "Test");

            var vehicle = InvokeMethod(storage, "GetVehicle", 0);

            var expectedType = GetType("Semi");
            var actualType = vehicle.GetType();

            Assert.AreEqual(actualType, expectedType);
        }

        private object InvokeMethod(object instance, string type, params object[] parameters)
        {
            try
            {
                var result = instance.GetType().GetMethod(type).Invoke(instance, parameters);
                return result;
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }


        // Test 09
        [TestMethod]
        public void TestGetVehicle2()
        {
            var storage = CreateObjectInstance(GetType("Warehouse"), "Test");
            Assert.ThrowsException<InvalidOperationException>(() => InvokeMethod(storage, "GetVehicle", 11));
        }


        // Test 10
        [TestMethod]
        public void TestGetVehicle3()
        {
            var storage = CreateObjectInstance(GetType("Warehouse"), "Test");
            Assert.ThrowsException<InvalidOperationException>(() => InvokeMethod(storage, "GetVehicle", 4));
        }


        // Test 11
        [TestMethod]
        public void SendVehicleTo1()
        {
            var sourceStorage = CreateObjectInstance(GetType("DistributionCenter"), "Source");
            var destinationStorage = CreateObjectInstance(GetType("Warehouse"), "Destination");

            try
            {
                Action act = () => InvokeMethod(sourceStorage, "SendVehicleTo", 0, destinationStorage);
                act.Invoke();
            }
            catch
            {
                Assert.Fail("Exception thrown while invoking SendVehicleTo method!");
            }

            var expectedSourceVehicleTypes = new[]
            {
            null,
            GetType("Van"),
            GetType("Van"),
        };

            var actualSourceVehicleTypes = ((IEnumerable)GetPropertyValue(sourceStorage, "Garage"))
                .Cast<object>()
                .Select(vehicle => vehicle?.GetType())
                .ToArray();

            for (int slot = 0; slot < expectedSourceVehicleTypes.Length; slot++)
            {
                var expectedSourceVehicleType = expectedSourceVehicleTypes[slot];
                var actualSourceVehicleType = actualSourceVehicleTypes[slot];

                Assert.AreEqual(actualSourceVehicleType, expectedSourceVehicleType, $"Storage isn't removing vehicle correctly after SendVehicleTo method!");
            }

            var expectedDestinationVehicleTypes = new[]
            {
            GetType("Semi"),
            GetType("Semi"),
            GetType("Semi"),
            GetType("Van"),
        };

            var actualDestinationVehicleTypes = ((IEnumerable)GetPropertyValue(destinationStorage, "Garage"))
                .Cast<object>()
                .Select(vehicle => vehicle?.GetType())
                .ToArray();

            for (int slot = 0; slot < expectedDestinationVehicleTypes.Length; slot++)
            {
                var expectedSourceVehicleType = expectedDestinationVehicleTypes[slot];
                var actualSourceVehicleType = actualDestinationVehicleTypes[slot];

                Assert.AreEqual(actualSourceVehicleType, expectedSourceVehicleType, $"Storage isn't removing vehicle correctly after SendVehicleTo method!");
            }
        }

        // Test 12
        [TestMethod]
        public void SendVehicleTo2()
        {
            var sourceStorage = CreateObjectInstance(GetType("Warehouse"), "Source");

            var destinationStorage = CreateObjectInstance(GetType("DistributionCenter"), "Destination");

            InvokeMethod(sourceStorage, "SendVehicleTo", 0, destinationStorage);
            InvokeMethod(sourceStorage, "SendVehicleTo", 1, destinationStorage);

            Assert.ThrowsException<InvalidOperationException>(() => InvokeMethod(sourceStorage, "SendVehicleTo", 2, destinationStorage),
                 "Storage doesn't throw exception on full garage!");
        }

        // Test 13
        [TestMethod]
        public void UnloadVehicle1()
        {
            var storage = CreateObjectInstance(GetType("DistributionCenter"), "Source");

            var vehicle = InvokeMethod(storage, "GetVehicle", 0);

            var productsToAdd = new[]
            {
            CreateObjectInstance(GetType("HardDrive"), 1),
            CreateObjectInstance(GetType("HardDrive"), 1),
        };

            foreach (var product in productsToAdd)
            {
                InvokeMethod(vehicle, "LoadProduct", product);
            }

            try
            {
                Action act = () => InvokeMethod(storage, "UnloadVehicle", 0);
            }
            catch
            {
                Assert.Fail($"Exception thrown while executing UnloadVehicle!");
            }

            var expectedProductTypes = new[]
            {
                GetType("HardDrive"),
                GetType("HardDrive"),
            };

            var actualProductTypes = ((IEnumerable)GetPropertyValue(storage, "Products"))
                .Cast<object>()
                .Select(p => p.GetType());

            Assert.AreNotEqual(actualProductTypes, expectedProductTypes, "Products are not added correctly!");
        }


        // Test 14
        [TestMethod]
        public void UnloadVehicle2()
        {
            var storage = CreateObjectInstance(GetType("DistributionCenter"), "Source");

            var vehicle = InvokeMethod(storage, "GetVehicle", 0);
            var vehicle2 = InvokeMethod(storage, "GetVehicle", 1);

            var productsToAdd = new[]
            {
            CreateObjectInstance(GetType("HardDrive"), 1),
            CreateObjectInstance(GetType("HardDrive"), 1),
        };

            foreach (var product in productsToAdd)
            {
                InvokeMethod(vehicle, "LoadProduct", product);
                InvokeMethod(vehicle2, "LoadProduct", product);
            }

            InvokeMethod(storage, "UnloadVehicle", 0);

            Assert.ThrowsException<InvalidOperationException>(() => InvokeMethod(storage, "UnloadVehicle", 1),
                $"UnloadVehicle does not throw exception when the storage is full.");
        }


    }
}
