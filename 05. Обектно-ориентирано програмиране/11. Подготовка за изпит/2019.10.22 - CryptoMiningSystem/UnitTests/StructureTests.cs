using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CryptoMiningSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StructureTests
    {

        //UserTests ========================================================
        //T01TestUserFields.cs
        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        // Class names
        private Type[] classes01 = { GetType01("User"), };


        [TestMethod]
        public void TestMethod01()
        {
            foreach (var className in classes01)
            {
                AssertFields01(className);
            }
        }

        private void AssertFields01(Type className)
        {
            var fields = className.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var fieldInfo in fields)
            {
                Assert.IsTrue(fieldInfo.IsPrivate, $"{fieldInfo.Name} in {className.Name} is NOT Private");
            }
        }

        private static Type GetType01(string name)
        {
            var type = ProjectAssembly
                .GetTypes()                
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T02TestUserProperties.cs
        private Type[] classes02 =
            {
            GetType02("User"),
        };

        private Dictionary<string, Type> propertiesTypes = new Dictionary<string, Type>()
        {
            { "Name", typeof(string)},
            { "Money", typeof(decimal)},
            { "Stars", typeof(int)},
            { "Computer", GetType02("Computer")},
        };

        [TestMethod]
        public void TestMethod02()
        {
            foreach (var className in classes02)
            {
                AssertProperties02(className);
            }
        }

        private void AssertProperties02(Type className)
        {
            var properties = className.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                string propName = propertyInfo.Name;
                Type propType = propertyInfo.PropertyType;

                Assert.IsTrue(propertiesTypes.ContainsKey(propName) && propertiesTypes[propName] == propType, $"{propName} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType02(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T03TestUserSetMethodProperties.cs
        private Type[] classes03 =
            {
            GetType03("User"),
        };

        private List<string> privateSetMethodProperties = new List<string>()
        {
            "Name",
        };

        [TestMethod]
        public void TestMethod03()
        {
            foreach (var className in classes03)
            {
                AssertProperties03(className);
            }
        }

        private void AssertProperties03(Type className)
        {
            var properties = className.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(x => privateSetMethodProperties.Contains(x.Name));

            foreach (var propertyInfo in properties)
            {
                string propName = propertyInfo.Name;

                Assert.IsTrue(propertyInfo.SetMethod.IsPrivate, $"{propName} in {className.Name} is NOT Defined");

            }
        }

        private static Type GetType03(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T04TestUserConstructor.cs
        private Type[] classes04 =
        {
            GetType04("User"),
        };

        private Type[] constructorParametersTypes =
        {
            typeof(string),
            typeof(decimal),
        };

        [TestMethod]
        public void TestMethod04()
        {
            foreach (var className in classes04)
            {
                AssertConstructor04(className);
            }
        }

        private void AssertConstructor04(Type className)
        {
            ConstructorInfo constructor = className
                .GetConstructor(constructorParametersTypes);

            Assert.IsNotNull(constructor);
        }

        private static Type GetType04(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //ComputerTests ====================================================

        //T01TestComputerFields.cs
        // Class names
        private Type[] classes05 =
        {
            GetType05("Computer"),
        };


        [TestMethod]
        public void TestMethod05()
        {
            foreach (var className in classes05)
            {
                AssertFields05(className);
            }
        }

        private void AssertFields05(Type className)
        {
            var fields = className.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var fieldInfo in fields)
            {
                Assert.IsTrue(fieldInfo.IsPrivate, $"{fieldInfo.Name} in {className.Name} is NOT Private");
            }
        }

        private static Type GetType05(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //T02TestComputerProperties.cs
        // Class names
        private Type[] classes06 =
        {
            GetType06("Computer"),
        };

        private Dictionary<string, Type> propertiesTypes06 = new Dictionary<string, Type>()
        {
            { "Processor", GetType06("Processor")},
            { "VideoCard", GetType06("VideoCard")},
            { "Ram", typeof(int)},
            { "MinedAmountPerHour", typeof(decimal)},
        };

        [TestMethod]
        public void TestMethod06()
        {
            foreach (var className in classes06)
            {
                AssertProperties06(className);
            }
        }

        private void AssertProperties06(Type className)
        {
            var properties = className.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                string propName = propertyInfo.Name;
                Type propType = propertyInfo.PropertyType;

                Assert.IsTrue(propertiesTypes06.ContainsKey(propName) && propertiesTypes06[propName] == propType, $"{propName} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType06(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //T03TestComputerSetMethodProperties.cs
        // Class names
        private Type[] classes07 =
        {
            GetType07("Computer"),
        };

        private List<string> privateSetMethodProperties07 = new List<string>()
        {
            "Ram",
        };

        [TestMethod]
        public void TestMethod07()
        {
            foreach (var className in classes07)
            {
                AssertProperties07(className);
            }
        }

        private void AssertProperties07(Type className)
        {
            var properties = className.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(x => privateSetMethodProperties07.Contains(x.Name));

            foreach (var propertyInfo in properties)
            {
                string propName = propertyInfo.Name;

                Assert.IsTrue(propertyInfo.SetMethod.IsPrivate, $"{propName} in {className.Name} is NOT Defined");

            }
        }

        private static Type GetType07(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //T04TestComputerConstructor.cs
        // Class names
        private Type[] classes08 =
        {
            GetType08("Computer"),
        };

        private Type[] constructorParametersTypes08 =
        {
            GetType08("Processor"),
            GetType08("VideoCard"),
            typeof(int),
        };

        [TestMethod]
        public void TestMethod08()
        {
            foreach (var className in classes08)
            {
                AssertConstructor08(className);
            }
        }

        private void AssertConstructor08(Type className)
        {
            ConstructorInfo constructor = className
                .GetConstructor(constructorParametersTypes08);

            Assert.IsNotNull(constructor);
        }

        private static Type GetType08(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //ComponentTests ===================================================
        //ComponentTests -> Component

        //T01TestComponentFields.cs
        // Class names
        private Type[] classes09 =
        {
            GetType09("Component"),
        };


        [TestMethod]
        public void TestMethod09()
        {
            foreach (var className in classes09)
            {
                AssertFields09(className);
            }
        }

        private void AssertFields09(Type className)
        {
            var fields = className.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var fieldInfo in fields)
            {
                Assert.IsTrue(fieldInfo.IsPrivate, $"{fieldInfo.Name} in {className.Name} is NOT Private");
            }
        }

        private static Type GetType09(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //T02TestComponentProperties.cs
        // Class names
        private Type[] classes10 =
        {
            GetType10("Component"),
        };

        private Dictionary<string, Type> propertiesTypes10 = new Dictionary<string, Type>()
        {
            { "Model", typeof(string)},
            { "Price", typeof(decimal)},
            { "Generation", typeof(int)},
            { "LifeWorkingHours", typeof(int)},
        };

        [TestMethod]
        public void TestMethod10()
        {
            foreach (var className in classes10)
            {
                AssertProperties10(className);
            }
        }

        private void AssertProperties10(Type className)
        {
            var properties = className.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                string propName = propertyInfo.Name;
                Type propType = propertyInfo.PropertyType;

                Assert.IsTrue(propertiesTypes10.ContainsKey(propName) && propertiesTypes10[propName] == propType, $"{propName} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType10(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //T03TestComponentSetMethodProperties.cs
        // Class names
        private Type[] classes11 =
        {
            GetType11("Component"),
        };

        private List<string> privateSetMethodProperties11 = new List<string>()
        {
            "Model",
            "Price",
        };

        [TestMethod]
        public void TestMethod11()
        {
            foreach (var className in classes11)
            {
                AssertProperties11(className);
            }
        }

        private void AssertProperties11(Type className)
        {
            var properties = className.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(x => privateSetMethodProperties11.Contains(x.Name));

            foreach (var propertyInfo in properties)
            {
                string propName = propertyInfo.Name;

                Assert.IsTrue(propertyInfo.SetMethod.IsPrivate, $"{propName} setter in {className.Name} is NOT Private");

            }
        }

        private static Type GetType11(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //T04TestComponentConstructor.cs
        // Class names
        private Type[] classes12 =
        {
            GetType12("Component"),
        };

        private Type[] constructorParametersTypes12 =
        {
            typeof(string),
            typeof(int),
            typeof(decimal),
        };

        [TestMethod]
        public void TestMethod12()
        {
            foreach (var className in classes12)
            {
                AssertConstructor12(className);
            }
        }

        private void AssertConstructor12(Type className)
        {
            ConstructorInfo constructor = className
                .GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, constructorParametersTypes12, null);

            Assert.IsTrue(constructor.IsFamily);
            Assert.IsNotNull(constructor);
        }

        private static Type GetType12(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T05TestComponentProtectedSetMethodProperties.cs
        // Class names
        private Type[] classes13 =
        {
            GetType13("Component"),
        };

        private List<string> privateSetMethodProperties13 = new List<string>()
        {
            "Generation",
        };

        [TestMethod]
        public void TestMethod13()
        {
            foreach (var className in classes13)
            {
                AssertProperties13(className);
            }
        }

        private void AssertProperties13(Type className)
        {
            var properties = className.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(x => privateSetMethodProperties13.Contains(x.Name));

            foreach (var propertyInfo in properties)
            {
                string propName = propertyInfo.Name;

                Assert.IsTrue(propertyInfo.SetMethod.IsFamily, $"{propName} in {className.Name} is NOT Defined");

            }
        }

        private static Type GetType13(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //ComponentTests -> Processor
        //T01TestProcessorProperties.cs
        // Class names
        private Type[] classes14 =
        {
            GetType14("Processor"),
        };

        private Dictionary<string, Type> propertiesTypes14 = new Dictionary<string, Type>()
        {
            { "Model", typeof(string)},
            { "Price", typeof(decimal)},
            { "Generation", typeof(int)},
            { "LifeWorkingHours", typeof(int)},
            { "MineMultiplier", typeof(int)},
        };

        [TestMethod]
        public void TestMethod14()
        {
            foreach (var className in classes14)
            {
                AssertProperties14(className);
            }
        }

        private void AssertProperties14(Type className)
        {
            var properties = className.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                string propName = propertyInfo.Name;
                Type propType = propertyInfo.PropertyType;

                Assert.IsTrue(propertiesTypes14.ContainsKey(propName) && propertiesTypes14[propName] == propType, $"{propName} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType14(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T02TestProcessorConstructor.cs
        // Class names
        private Type[] classes15 =
        {
            GetType15("Processor"),
        };

        private Type[] constructorParametersTypes15 =
        {
            typeof(string),
            typeof(int),
            typeof(decimal),
        };

        [TestMethod]
        public void TestMethod15()
        {
            foreach (var className in classes15)
            {
                AssertConstructor15(className);
            }
        }

        private void AssertConstructor15(Type className)
        {
            ConstructorInfo constructor = className
                .GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, constructorParametersTypes15, null);

            Assert.IsTrue(constructor.IsFamily);
            Assert.IsNotNull(constructor);
        }

        private static Type GetType15(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T03TestProcessorBaseClass.cs
        // Class names
        private Type[] classes16 =
        {
            GetType16("Processor"),
        };

        private Type baseClassType = GetType16("Component");

        [TestMethod]
        public void TestMethod16()
        {
            foreach (var className in classes16)
            {
                AssertBaseClass16(className);
            }
        }

        private void AssertBaseClass16(Type className)
        {
            Type baseClass = className.BaseType;

            Assert.AreEqual(baseClass, baseClassType);
        }

        private static Type GetType16(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //T04TestProcessorChilds.cs 
        // Class names
        private Type[] classes17 =
        {
            GetType17("LowPerformanceProcessor"),
            GetType17("HighPerformanceProcessor"),
        };

        private Type baseClassType17 = GetType17("Processor");

        [TestMethod]
        public void TestMethod17()
        {
            foreach (var className in classes17)
            {
                AssertBaseClass17(className);
            }
        }

        private void AssertBaseClass17(Type className)
        {
            Type baseClass = className.BaseType;

            Assert.AreEqual(baseClass, baseClassType17);
        }

        private static Type GetType17(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //ComponentTests -> Video Card
        //T01TestVideoCardFields.cs
        // Class names
        private Type[] classes18 =
        {
            GetType18("VideoCard"),
        };


        [TestMethod]
        public void TestMethod18()
        {
            foreach (var className in classes18)
            {
                AssertFields18(className);
            }
        }

        private void AssertFields18(Type className)
        {
            var fields = className.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var fieldInfo in fields)
            {
                Assert.IsTrue(fieldInfo.IsPrivate, $"{fieldInfo.Name} in {className.Name} is NOT Private");
            }
        }

        private static Type GetType18(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T02TestVideoCardConstructor.cs
        // Class names
        private Type[] classes19 =
        {
            GetType19("VideoCard"),
        };

        private Type[] constructorParametersTypes19 =
        {
            typeof(string),
            typeof(int),
            typeof(int),
            typeof(decimal),
        };

        [TestMethod]
        public void TestMethod19()
        {
            foreach (var className in classes19)
            {
                AssertConstructor19(className);
            }
        }

        private void AssertConstructor19(Type className)
        {
            ConstructorInfo constructor = className
                .GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, constructorParametersTypes19, null);

            Assert.IsTrue(constructor.IsFamily);
            Assert.IsNotNull(constructor);
        }

        private static Type GetType19(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T03TestVideoCardProperties.cs
        // Class names
        private Type[] classes20 =
        {
            GetType20("VideoCard"),
        };

        private Dictionary<string, Type> propertiesTypes20 = new Dictionary<string, Type>()
        {
            { "Model", typeof(string)},
            { "Price", typeof(decimal)},
            { "Generation", typeof(int)},
            { "LifeWorkingHours", typeof(int)},
            { "Ram", typeof(int)},
            { "MinedMoneyPerHour", typeof(decimal)},
        };

        [TestMethod]
        public void TestMethod20()
        {
            foreach (var className in classes20)
            {
                AssertProperties20(className);
            }
        }

        private void AssertProperties20(Type className)
        {
            var properties = className.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                string propName = propertyInfo.Name;
                Type propType = propertyInfo.PropertyType;

                Assert.IsTrue(propertiesTypes20.ContainsKey(propName) && propertiesTypes20[propName] == propType, $"{propName} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType20(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T04TestVideoCardBaseClass.cs
        // Class names
        private Type[] classes21 =
        {
            GetType21("VideoCard"),
        };

        private Type baseClassType21 = GetType21("Component");

        [TestMethod]
        public void TestMethod21()
        {
            foreach (var className in classes21)
            {
                AssertBaseClass21(className);
            }
        }

        private void AssertBaseClass21(Type className)
        {
            Type baseClass = className.BaseType;

            Assert.AreEqual(baseClass, baseClassType21);
        }

        private static Type GetType21(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T05TestVideoCardSetMethodProperties.cs
        // Class names
        private Type[] classes22 =
        {
            GetType22("VideoCard"),
        };

        private List<string> privateSetMethodProperties22 = new List<string>()
        {
            "Ram",
        };

        [TestMethod]
        public void TestMethod22()
        {
            foreach (var className in classes22)
            {
                AssertProperties22(className);
            }
        }

        private void AssertProperties22(Type className)
        {
            var properties = className.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                .Where(x => privateSetMethodProperties22.Contains(x.Name));

            foreach (var propertyInfo in properties)
            {
                string propName = propertyInfo.Name;

                Assert.IsTrue(propertyInfo.SetMethod.IsPrivate, $"{propName} setter in {className.Name} is NOT Private");

            }
        }

        private static Type GetType22(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T06TestVideoCardChilds.cs
        // Class names
        private Type[] classes23 =
        {
            GetType23("GameVideoCard"),
            GetType23("MineVideoCard"),
        };

        private Type baseClassType23 = GetType23("VideoCard");

        [TestMethod]
        public void TestMethod23()
        {
            foreach (var className in classes23)
            {
                AssertBaseClass(className);
            }
        }

        private void AssertBaseClass(Type className)
        {
            Type baseClass = className.BaseType;

            Assert.AreEqual(baseClass, baseClassType23);
        }

        private static Type GetType23(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //AbstactMembers ===================================================
        //T01TestAllAbstractMembers.cs
        // Class names
        private Type[] classes24 =
        {
            GetType24("Component"),
            GetType24("Processor"),
            GetType24("VideoCard"),
        };

        [TestMethod]
        public void TestMethod24()
        {
            foreach (var className in classes24)
            {
                Assert.IsTrue(className.IsAbstract);
            }
        }

        private static Type GetType24(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

    }
}