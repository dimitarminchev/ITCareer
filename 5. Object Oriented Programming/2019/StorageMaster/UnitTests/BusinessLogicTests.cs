using System;
using System.Linq;
using System.Reflection;
using System.Collections;
using NUnit.Framework;
using StorageMaster;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming

[TestFixture]
public class BusinessLogicTests
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    // test.000.001.in
    [Test]
    public void ValidateControllerExists()
    {
        var typesToAssert = new[]
         {
            "StorageMaster",
        };

        foreach (var typeName in typesToAssert)
        {
            Assert.That(GetType(typeName), Is.Not.Null, $"{typeName} type doesn't exist!");
        }
    }
    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == name);

        return type;
    }

    //test.000.002.in
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
    [Test]
    public void ValidateDungeonMasterMethodsExist()
    {
        var storageMasterType = GetType("StorageMaster");

        Assert.That(storageMasterType, Is.Not.Null,
            "DungeonMaster class doesn\'t exist!");

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

            Assert.That(method, Is.Not.Null,
                $"{storageMasterType}.{methodName} doesn't exist!");

            var actualReturnType = method.ReturnType;
            Assert.That(actualReturnType, Is.EqualTo(expectedReturnType),
                $"{storageMasterType}.{methodName} returns {actualReturnType} instead of {expectedReturnType}");
        }
    }

    //test.001.in
    [Test]
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

            Assert.That(() => instance = CreateObjectInstance(type, parameters), Throws.Nothing,
                $"Exception occurred while attempting to create a {type}");

            Assert.That(GetPropertyValue(instance, "Price"), Is.EqualTo(2.5), "Price isn't set correctly");
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


    // test.002.in
    [Test]
    public void CreateInvalidProduct()
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
            -2.5
        };

        foreach (var type in types)
        {
            Assert.That(() => CreateObjectInstance1(type, parameters), Throws.InvalidOperationException,
                $"No exception was thrownattempting to create a {type} with invalid price");
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


    // test.003.in
    [Test]
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

            Assert.That(() => instance = CreateObjectInstance(type, parameters), Throws.Nothing,
                $"Exception occurred while attempting to create a {type}");

            Assert.That(GetPropertyValue(instance, "Name"), Is.EqualTo("TestStorage"), "Name isn't set correctly");
        }
    }


    // test.004.in
    [Test]
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

            Assert.That(actualGarageSlots, Is.EqualTo(expectedGarageSlots),
                $"{storageType} has incorrect garage slot count!");
        }
    }


    // test.005.in
    [Test]
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

                Assert.That(actualVehicleType, Is.EqualTo(expectedVehicleType),
                    $"Default vehicle at slot {typeIndex} is incorrect!");
            }
        }
    }


    // test.006.in
    [Test]
    public void TestGetVehicle1()
    {
        var storage = CreateObjectInstance(GetType("Warehouse"), "Test");

        var vehicle = InvokeMethod(storage, "GetVehicle", 0);

        var expectedType = GetType("Semi");
        var actualType = vehicle.GetType();

        Assert.That(actualType, Is.EqualTo(expectedType));
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




    // test.007.in
    [Test]
    public void TestGetVehicle2()
    {
        var storage = CreateObjectInstance(GetType("Warehouse"), "Test");

        Assert.That(() => InvokeMethod(storage, "GetVehicle", 11), Throws.InvalidOperationException);
    }


    // test.008.in
    [Test]
    public void TestGetVehicle3()
    {
        var storage = CreateObjectInstance(GetType("Warehouse"), "Test");

        Assert.That(() => InvokeMethod(storage, "GetVehicle", 4), Throws.InvalidOperationException);
    }


    // test.009.in
    [Test]
    public void SendVehicleTo1()
    {
        var sourceStorage = CreateObjectInstance(GetType("DistributionCenter"), "Source");
        var destinationStorage = CreateObjectInstance(GetType("Warehouse"), "Destination");

        Assert.That(() => InvokeMethod(sourceStorage, "SendVehicleTo", 0, destinationStorage), Throws.Nothing,
            "Exception thrown while invoking SendVehicleTo method!");

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

            Assert.That(actualSourceVehicleType, Is.EqualTo(expectedSourceVehicleType),
                $"Storage isn't removing vehicle correctly after SendVehicleTo method!");
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

            Assert.That(actualSourceVehicleType, Is.EqualTo(expectedSourceVehicleType),
                $"Storage isn't removing vehicle correctly after SendVehicleTo method!");
        }
    }


    // test.010.in
    [Test]
    public void SendVehicleTo2()
    {
        var sourceStorage = CreateObjectInstance(GetType("Warehouse"), "Source");

        var destinationStorage = CreateObjectInstance(GetType("DistributionCenter"), "Destination");

        InvokeMethod(sourceStorage, "SendVehicleTo", 0, destinationStorage);
        InvokeMethod(sourceStorage, "SendVehicleTo", 1, destinationStorage);

        Assert.That(() => InvokeMethod(sourceStorage, "SendVehicleTo", 2, destinationStorage), Throws.InvalidOperationException,
            "Storage doesn't throw exception on full garage!");
    }

    // test.011.in
    [Test]
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

        Assert.That(() => InvokeMethod(storage, "UnloadVehicle", 0), Throws.Nothing,
            $"Exception thrown while executing UnloadVehicle!");

        var expectedProductTypes = new[]
        {
            GetType("HardDrive"),
            GetType("HardDrive"),
        };

        var actualProductTypes = ((IEnumerable)GetPropertyValue(storage, "Products"))
            .Cast<object>()
            .Select(p => p.GetType());

        Assert.That(actualProductTypes, Is.EquivalentTo(expectedProductTypes),
            "Products are not added correctly!");
    }


    // test.012.in
    [Test]
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

        Assert.That(() => InvokeMethod(storage, "UnloadVehicle", 1), Throws.InvalidOperationException,
            $"UnloadVehicle does not throw exception when the storage is full.");
    }


}