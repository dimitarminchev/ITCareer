using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    using HeroFight;

    [TestClass]
    public class StructureTests
    {

        private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

        // Class names
        private Type[] classes01 =
        {
            GetType01("Hero"),
        };


        [TestMethod]
        public void TestFieldIsPrivate()
        {
            foreach (var className in classes01)
            {
                AssertFields(className);
            }
        }

        private void AssertFields(Type className)
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

        //T02.cs
        private Type[] classes02 =
            {
            GetType02("Hero"),
        };

        private Dictionary<string, Type> propertiesTypes = new Dictionary<string, Type>()
        {
            { "Name", typeof(string)},
            { "Level",typeof(int)},
            { "Experience", typeof(int)},
            { "Weapon", GetType02("Weapon")},
            { "Power", typeof(double)},
        };

        [TestMethod]
        public void TestPropertiesExist()
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
                Assert.IsTrue(this.propertiesTypes.ContainsKey(propertyInfo.Name), $"{propertyInfo.Name} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType02(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //T03.cs
        private Type[] classes03 =
        {
            GetType03("Hero"),
        };

        private string propertyName = "Name";

        [TestMethod]
        public void TestNameSetMethodIsPrivate()
        {
            foreach (var className in classes03)
            {
                AssertPropertySetMethodIsPrivate(className);
            }
        }

        private void AssertPropertySetMethodIsPrivate(Type className)
        {
            var property = className
                .GetProperty(propertyName);

            Assert.IsTrue(property.SetMethod.IsPrivate,
                $"Property {propertyName} set method is not private");
        }

        private static Type GetType03(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T04.cs
        private Type[] classes04 =
        {
            GetType04("Hero"),
        };

        private string propertyName04 = "Level";

        [TestMethod]
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
                $"Property {propertyName} set method is not private");
        }

        private static Type GetType04(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T05.cs
        private Type[] classes05 =
        {
            GetType05("Hero"),
        };

        private Type[] constructorParametersTypes =
        {
            typeof(string),
        };

        [TestMethod]
        public void TestConstructorParametersAndAccessModifier()
        {
            foreach (var className in classes05)
            {
                AssertConstructorIsFamily05(className);
            }
        }

        private void AssertConstructorIsFamily05(Type className)
        {
            ConstructorInfo constructor = className
                .GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null,
                constructorParametersTypes, null);

            Assert.IsNotNull(constructor);
            Assert.IsTrue(constructor.IsFamily);
        }

        private static Type GetType05(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T06.cs
        private Type[] classes06 =
        {
            GetType06("Hero"),
        };

        [TestMethod]
        public void TestClassIsAbstract()
        {
            foreach (var className in classes06)
            {
                AssertClassIsAbstract06(className);
            }
        }

        private void AssertClassIsAbstract06(Type className)
        {
            Assert.IsTrue(className.IsAbstract);
        }

        private static Type GetType06(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T07.cs
        private Type[] classes07 =
        {
            GetType07("Assassin"),
        };

        private Type baseClass = GetType07("Hero");

        [TestMethod]
        public void TestSwordBaseClass()
        {
            foreach (var className in classes07)
            {
                AssertBaseClass07(className);
            }
        }

        private void AssertBaseClass07(Type className)
        {
            Assert.IsTrue(className.BaseType == baseClass);
        }

        private static Type GetType07(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T08.cs
        private Type[] classes08 =
        {
            GetType08("Priest"),
        };

        private Type baseClass08 = GetType08("Hero");

        [TestMethod]
        public void TestSwordBaseClass08()
        {
            foreach (var className in classes08)
            {
                AssertBaseClass08(className);
            }
        }

        private void AssertBaseClass08(Type className)
        {
            Assert.IsTrue(className.BaseType == baseClass08);
        }

        private static Type GetType08(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T09.cs
        private Type[] classes09 =
        {
            GetType09("Warrior"),
        };

        private Type baseClass09 = GetType09("Hero");

        [TestMethod]
        public void TestSwordBaseClass09()
        {
            foreach (var className in classes09)
            {
                AssertBaseClass09(className);
            }
        }

        private void AssertBaseClass09(Type className)
        {
            Assert.IsTrue(className.BaseType == baseClass09);
        }

        private static Type GetType09(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }


        //WeaponTests ========================================================    	
        //T01.cs
        private Type[] classes10 =
            {
            GetType10("Weapon"),
        };


        [TestMethod]
        public void TestFieldIsPrivate01()
        {
            foreach (var className in classes10)
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

        private static Type GetType10(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T02.cs
        private Type[] classes11 =
        {
            GetType11("Weapon"),
        };

        private Dictionary<string, Type> propertiesTypes11 = new Dictionary<string, Type>()
        {
            { "Name", typeof(string)},
            { "Strength",typeof(int)},
            { "Agility", typeof(int)},
            { "Intelligence", typeof(int)},
        };

        [TestMethod]
        public void TestPropertiesExist02()
        {
            foreach (var className in classes11)
            {
                AssertFields02W(className);
            }
        }

        private void AssertFields02W(Type className)
        {
            var properties = className
                .GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var propertyInfo in properties)
            {
                Assert.IsTrue(this.propertiesTypes11.ContainsKey(propertyInfo.Name), $"{propertyInfo.Name} in {className.Name} is NOT Defined");
            }
        }

        private static Type GetType11(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T03.cs
        private Type[] classes12 =
        {
            GetType12("Weapon"),
        };

        private string propertyName12 = "Name";

        [TestMethod]
        public void TestNameSetMethodIsPrivate03()
        {
            foreach (var className in classes12)
            {
                AssertPropertySetMethodIsPrivate03(className);
            }
        }

        private void AssertPropertySetMethodIsPrivate03(Type className)
        {
            var property = className
                .GetProperty(propertyName12);

            Assert.IsTrue(property.SetMethod.IsPrivate,
                $"Property {propertyName} set method is not private");
        }

        private static Type GetType12(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T04.cs
        private Type[] classes13 =
        {
            GetType13("Weapon"),
        };

        private string propertyName13 = "Strength";

        [TestMethod]
        public void TestStrengthSetMethodIsPrivateOrIsFamily()
        {
            foreach (var className in classes13)
            {
                AssertPropertySetMethodIsPrivateOrIsFamily(className);
            }
        }

        private void AssertPropertySetMethodIsPrivateOrIsFamily(Type className)
        {
            var property = className
                .GetProperty(propertyName13);

            Assert.IsTrue(property.SetMethod.IsPrivate || property.SetMethod.IsFamily);
        }

        private static Type GetType13(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T05.cs
        private Type[] classes14 =
        {
            GetType14("Weapon"),
        };

        private string propertyName14 = "Agility";

        [TestMethod]
        public void TesAgilitySetMethodIsPrivateOrIsFamily05()
        {
            foreach (var className in classes14)
            {
                AssertPropertySetMethodIsPrivateOrFamily(className);
            }
        }

        private void AssertPropertySetMethodIsPrivateOrFamily(Type className)
        {
            var property = className
                .GetProperty(propertyName14);

            Assert.IsTrue(property.SetMethod.IsPrivate || property.SetMethod.IsFamily);
        }

        private static Type GetType14(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T06.cs
        private Type[] classes15 =
        {
            GetType15("Weapon"),
        };

        private string propertyName15 = "Intelligence";

        [TestMethod]
        public void TestIntelligenceSetMethodIsPrivateOrIsFamily()
        {
            foreach (var className in classes15)
            {
                AssertPropertySetMethodIsPrivate06(className);
            }
        }

        private void AssertPropertySetMethodIsPrivate06(Type className)
        {
            var property = className
                .GetProperty(propertyName15);

            Assert.IsTrue(property.SetMethod.IsPrivate || property.SetMethod.IsFamily);
        }

        private static Type GetType15(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T07.cs
        private Type[] classes16 =
        {
            GetType16("Weapon"),
        };

        private Type[] constructorParametersTypes16 =
        {
            typeof(string),
            typeof(int),
            typeof(int),
            typeof(int),
        };

        [TestMethod]
        public void TestConstructorParametersAndAccessModifier07()
        {
            foreach (var className in classes16)
            {
                AssertConstructorIsFamily(className);
            }
        }

        private void AssertConstructorIsFamily(Type className)
        {
            ConstructorInfo constructor = className
                .GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null,
                constructorParametersTypes16, null);

            Assert.IsNotNull(constructor);
            Assert.IsTrue(constructor.IsFamily);
        }

        private static Type GetType16(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T08.cs
        private Type[] classes17 =
            {
            GetType17("Weapon"),
        };

        [TestMethod]
        public void TestClassIsAbstract08()
        {
            foreach (var className in classes17)
            {
                AssertClassIsAbstract(className);
            }
        }

        private void AssertClassIsAbstract(Type className)
        {
            Assert.IsTrue(className.IsAbstract);
        }

        private static Type GetType17(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T09.cs
        private Type[] classes18 =
        {
            GetType18("Sword"),
        };

        private Type baseClass18 = GetType18("Weapon");

        [TestMethod]
        public void TestSwordBaseClass09W()
        {
            foreach (var className in classes18)
            {
                AssertBaseClass18(className);
            }
        }

        private void AssertBaseClass18(Type className)
        {
            Assert.IsTrue(className.BaseType == baseClass18);
        }

        private static Type GetType18(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T10.cs
        private Type[] classes19 =
        {
            GetType19("Bow"),
        };

        private Type baseClass19 = GetType19("Weapon");

        [TestMethod]
        public void TestBowBaseClass()
        {
            foreach (var className in classes19)
            {
                AssertBaseClass10(className);
            }
        }

        private void AssertBaseClass10(Type className)
        {
            Assert.IsTrue(className.BaseType == baseClass19);
        }

        private static Type GetType19(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }

        //T11.cs
        private Type[] classes20 =
        {
            GetType20("MagicWand"),
        };

        private Type baseClass20 = GetType20("Weapon");

        [TestMethod]
        public void TestMagicWandBaseClass()
        {
            foreach (var className in classes20)
            {
                AssertBaseClass11(className);
            }
        }

        private void AssertBaseClass11(Type className)
        {
            Assert.IsTrue(className.BaseType == baseClass20);
        }

        private static Type GetType20(string name)
        {
            var type = ProjectAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == name);

            return type;
        }
    }
}
