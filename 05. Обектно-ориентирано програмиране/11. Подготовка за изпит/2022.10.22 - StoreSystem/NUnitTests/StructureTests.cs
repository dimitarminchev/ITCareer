using System.Reflection;
using NUnit.Framework;

namespace NUnitTests
{
    public class StructureTests
    {
        private static readonly Assembly ProjectAssembly = typeof(Store).Assembly;

        /*.............................*/
        private Type[] classes01 =
        {
            GetType01("Store"),
    };

        [Test]
        //    [TestMethod]
        public void TestStoreFieldIsPrivate()
        {
            foreach (var className in classes01)
            {
                AssertFields01(className);
            }
        }
        private void AssertFields01(Type className)
        {
            var fields = className
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var fieldInfo in fields)
            {
                Assert.IsTrue(fieldInfo.IsPrivate,
                    $"{fieldInfo.Name} in {className.Name} is NOT Private");
            }
        }

        private static Type GetType01(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);
            return type;
        }

        //==========================================================================
        private Type[] classes02 =
        {
        GetType02("Store"),
    };

        private Dictionary<string, Type> propertiesTypes02 = new Dictionary<string, Type>()
    {
            { "Name", typeof(string) },
            { "Type", typeof(string) },
            { "Revenue", typeof(double) },
    };

        [Test]
        public void TestStorePropertiesExist02()
        {
            foreach (var className in classes02)
            {
                AssertFields02(className);
            }
        }
        private void AssertFields02(Type className)
        {
            var properties = className
                .GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var propertyInfo in properties)
            {
                Assert.IsTrue(this.propertiesTypes02.ContainsKey(propertyInfo.Name), $"{propertyInfo.Name} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType02(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);
            return type;
        }

        //==========================================================================
        private Type[] classes03 =
        {
        GetType03("Store"),
    };

        private Dictionary<string, Type> propertiesTypes03 = new Dictionary<string, Type>()
    {
        { "Name", typeof(string) },
        { "Type", typeof(string) },
        { "Revenue", typeof(double) },
    };

        [Test]
        public void TestStorePropertiesExist03()
        {
            foreach (var className in classes03)
            {
                AssertFields03(className);
            }
        }
        private void AssertFields03(Type className)
        {
            var properties = className
                .GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var propertyInfo in properties)
            {
                Assert.IsTrue(this.propertiesTypes03.ContainsKey(propertyInfo.Name), $"{propertyInfo.Name} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType03(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);
            return type;
        }


        //==========================================================================
        private Type[] classes04 =
            {
            GetType04("Store"),
        };

        private string propertyName04 = "Name";

        [Test]
        public void TestNameSetMethodIsPrivate04()
        {
            foreach (var className in classes04)
            {
                AssertPropertySetMethodIsPrivate04(className);
            }
        }
        private void AssertPropertySetMethodIsPrivate04(Type className)
        {
            var property = className
                .GetProperty(propertyName04);
            Assert.IsTrue(property.SetMethod.IsPrivate,
            $"Property {propertyName04} set method is not private");
        }

        private static Type GetType04(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type[] classes05 =
        {
        GetType05("Store"),
    };

        private string propertyName05 = "Type";

        [Test]
        public void TestNameSetMethodIsPrivate05()
        {
            foreach (var className in classes05)
            {
                AssertPropertySetMethodIsPrivate05(className);
            }
        }

        private void AssertPropertySetMethodIsPrivate05(Type className)
        {
            var property = className
                .GetProperty(propertyName05);

            Assert.IsTrue(property.SetMethod.IsPrivate,
                $"Property {propertyName05} set method is not private");
        }

        private static Type GetType05(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);
            return type;
        }

        //==========================================================================    
        private Type[] classes06 =
        {
        GetType06("Store"),
    };

        private string propertyName06 = "Revenue";

        [Test]
        public void TestNameSetMethodIsPrivate06()
        {
            foreach (var className in classes06)
            {
                AssertPropertySetMethodIsPrivate06(className);
            }
        }

        private void AssertPropertySetMethodIsPrivate06(Type className)
        {
            var property = className
                .GetProperty(propertyName06);

            Assert.IsTrue(property.SetMethod.IsPrivate,
                $"Property {propertyName06} set method is not private");
        }

        private static Type GetType06(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type sut07 = GetType07("Store");

        [Test]
        public void TestReceiveProductMethodExists07()
        {
            var receiveProduct = sut07.GetMethod("ReceiveProduct");

            Assert.IsNotNull(receiveProduct);
        }
        private static Type GetType07(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type sut08 = GetType08("Store");

        [Test]
        public void TestReceiveProductMethodExists08()
        {
            var sellProduct = sut08.GetMethod("SellProduct");

            Assert.IsNotNull(sellProduct);
        }
        private static Type GetType08(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type sut09 = GetType09("Store");

        [Test]
        public void TestReceiveProductMethodExists09()
        {
            var getProduct = sut09.GetMethod("GetProduct");

            Assert.IsNotNull(getProduct);
        }
        private static Type GetType09(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);
            return type;
        }

        //==========================================================================
        private Type[] classes01D =
        {
            GetType01D("Drink"),
    };

        [Test]
        public void TestDrinkFieldIsPrivate()
        {
            foreach (var className in classes01D)
            {
                AssertFields01D(className);
            }
        }
        private void AssertFields01D(Type className)
        {
            var fields = className
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var fieldInfo in fields)
            {
                Assert.IsTrue(fieldInfo.IsPrivate,
                    $"{fieldInfo.Name} in {className.Name} is NOT Private");
            }
        }

        private static Type GetType01D(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);
            return type;
        }

        //==========================================================================
        private Type[] classes02D =
            {
            GetType02D("Drink"),
        };

        private Type baseClass = GetType02D("Product");

        [Test]
        public void TestDrinkBaseClass()
        {
            foreach (var className in classes02D)
            {
                AssertBaseClass02D(className);
            }
        }

        private void AssertBaseClass02D(Type className)
        {
            Assert.True(className.BaseType == baseClass);
        }

        private static Type GetType02D(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);
            return type;
        }

        //==========================================================================
        private Type[] classes01F =
            {
            GetType01F("Food"),
        };

        [Test]
        public void TestFoodFieldIsPrivate()
        {
            foreach (var className in classes01F)
            {
                AssertFields(className);
            }
        }

        private void AssertFields(Type className)
        {
            var fields = className
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var fieldInfo in fields)
            {
                Assert.IsTrue(fieldInfo.IsPrivate,
                    $"{fieldInfo.Name} in {className.Name} is NOT Private");
            }
        }

        private static Type GetType01F(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);
            return type;
        }

        //==========================================================================
        private Type[] classes02F =
        {
            GetType02F("Food"),
    };

        private Type baseClass02F = GetType02F("Product");

        [Test]
        public void TestFoodBaseClass()
        {
            foreach (var className in classes02F)
            {
                AssertBaseClass(className);
            }
        }

        private void AssertBaseClass(Type className)
        {
            Assert.True(className.BaseType == baseClass02F);
        }

        private static Type GetType02F(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type[] classes01P =
        {
            GetType01P("Product"),
    };

        [Test]
        public void TestProductFieldIsPrivate()
        {
            foreach (var className in classes01P)
            {
                AssertFields01P(className);
            }
        }

        private void AssertFields01P(Type className)
        {
            var fields = className
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var fieldInfo in fields)
            {
                Assert.IsTrue(fieldInfo.IsPrivate,
                    $"{fieldInfo.Name} in {className.Name} is NOT Private");
            }
        }

        private static Type GetType01P(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type[] classes02P =
        {
        GetType02P("Product"),
    };

        private Dictionary<string, Type> propertiesTypes02P = new Dictionary<string, Type>()
    {
            { "Name", typeof(string) },
            { "Quantity", typeof(int) },
            { "DeliverPrice", typeof(double) },
            { "PercentageMarkup", typeof(double) },
            { "FinalPrice", typeof(double) }
        };

        [Test]
        public void TestBuildingPropertiesExist()
        {
            foreach (var className in classes02P)
            {
                AssertFields02P(className);
            }
        }

        private void AssertFields02P(Type className)
        {
            var properties = className
                .GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var propertyInfo in properties)
            {
                Assert.IsTrue(this.propertiesTypes02P.ContainsKey(propertyInfo.Name), $"{propertyInfo.Name} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType02P(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type[] classes03P =
        {
        GetType03P("Product"),
    };

        private string propertyName03P = "Name";


        [Test]
        public void TestNameSetMethodIsPrivate()
        {
            foreach (var className in classes03P)
            {
                AssertPropertySetMethodIsPrivate(className);
            }
        }

        private void AssertPropertySetMethodIsPrivate(Type className)
        {
            var property = className
                .GetProperty(propertyName03P);
            Assert.IsTrue(property.SetMethod.IsPrivate);
        }

        private static Type GetType03P(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type[] classes04P =
        {
            GetType04P("Product"),
    };

        private string propertyName04P = "DeliverPrice";


        [Test]
        public void TestDeliverPriceSetMethodIsPrivate()
        {
            foreach (var className in classes04P)
            {
                AssertPropertySetMethodIsPrivate04P(className);
            }
        }

        private void AssertPropertySetMethodIsPrivate04P(Type className)
        {
            var property = className
                .GetProperty(propertyName04P);

            Assert.IsTrue(property.SetMethod.IsPrivate);
        }

        private static Type GetType04P(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type[] classes05P =
        {
            GetType05P("Product"),
    };

        private string propertyName05P = "PercentageMarkup";

        [Test]
        public void TestDeliverPriceSetMethodIsFamily()
        {
            foreach (var className in classes05P)
            {
                AssertPropertySetMethodIsFamily(className);
            }
        }

        private void AssertPropertySetMethodIsFamily(Type className)
        {
            var property = className
                .GetProperty(propertyName05P);

            Assert.IsTrue(property.SetMethod.IsFamily);
        }

        private static Type GetType05P(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type[] classes06P =
            {
            GetType06P("Product"),
        };

        private Type[] constructorParametersTypes =
        {
            typeof(string),
            typeof(int),
            typeof(double),
            typeof(double),
        };

        [Test]
        public void TestConstructorParametersAndAccessModifier06P()
        {
            foreach (var className in classes06P)
            {
                AssertConstructorIsFamily(className);
            }
        }

        private void AssertConstructorIsFamily(Type className)
        {
            ConstructorInfo constructor = className
                .GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null,
                constructorParametersTypes, null);

            Assert.IsNotNull(constructor);
        }

        private static Type GetType06P(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //==========================================================================
        private Type[] classes07P =
            {
            GetType07P("Product"),
        };

        private Type[] constructorParametersTypes07P =
        {
            typeof(string),
            typeof(int),
            typeof(double),
            typeof(double),
        };

        [Test]
        public void TestConstructorParametersAndAccessModifier07P()
        {
            foreach (var className in classes07P)
            {
                AssertConstructorIsFamily07P(className);
            }
        }

        private void AssertConstructorIsFamily07P(Type className)
        {
            ConstructorInfo constructor = className
                .GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null,
                constructorParametersTypes07P, null);

            Assert.IsNotNull(constructor);
            Assert.True(constructor.IsFamily);
        }

        private static Type GetType07P(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);
            return type;
        }

        //==========================================================================
        private Type[] classes08P =
        {
        GetType08P("Product"),
    };

        [Test]
        public void TestClassIsAbstract()
        {
            foreach (var className in classes08P)
            {
                AssertClassIsAbstract(className);
            }
        }

        private void AssertClassIsAbstract(Type className)
        {
            Assert.True(className.IsAbstract);
        }

        private static Type GetType08P(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);
            return type;
        }
    }
}