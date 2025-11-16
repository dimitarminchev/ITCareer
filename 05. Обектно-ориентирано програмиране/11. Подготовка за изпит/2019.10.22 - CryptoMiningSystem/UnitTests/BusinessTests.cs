using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using CryptoMiningSystem.Core;
using CryptoMiningSystem.Entities;

namespace UnitTests
{
    [TestClass]
    public class BusinessTests
    {

        //T01TestRegister.cs
        private Type sut01 = typeof(PCController);
        private object[] user01 = { new List<string>() { "Gosho", "1234.56" } };
        PCController manager01 = new PCController();
        private string expectedOutput01 =
            $"Successfully registered user - Gosho!";

        [TestMethod]
        public void TestMethod01()
        {
            var register = sut01.GetMethod("RegisterUser");

            string checkMessage = (string)register.Invoke(manager01, user01);

            Assert.AreEqual(expectedOutput01, checkMessage);
        }

        //T02TestRegister.cs
        private Type sut02 = typeof(PCController);
        private object[] user02 = { new List<string>() { "Gosho", "0" } };
        PCController manager02 = new PCController();
        private string expectedOutput02 =
            $"Successfully registered user - Gosho!";

        [TestMethod]
        public void TestMethod02()
        {
            var register = sut02.GetMethod("RegisterUser");

            string checkMessage = (string)register.Invoke(manager02, user02);

            Assert.AreEqual(expectedOutput02, checkMessage);
        }

        //T03TestRegister.cs
        private Type sut03 = typeof(PCController);
        private object[] user03 = { new List<string>() { "Gosho", "1234.56" } };
        PCController manager03 = new PCController();
        private string expectedOutput03 =
            $"Username: Gosho already exists!";

        [TestMethod]
        public void TestMethod03()
        {
            var register = sut03.GetMethod("RegisterUser");

            register.Invoke(manager03, user03);
            string checkMessage = (string)register.Invoke(manager03, user03);

            Assert.AreEqual(expectedOutput03, checkMessage);
        }

        //T04TestRegister.cs
        private Type sut04 = typeof(PCController);
        private object[] user04 = { new List<string>() { "Gosho", "-1542" } };
        PCController manager04 = new PCController();
        private string expectedOutput04 =
            $"User's money cannot be less than 0!";

        [TestMethod]
        public void TestMethod04()
        {
            var register = sut04.GetMethod("RegisterUser");

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => register.Invoke(manager04, user04));

            Assert.AreEqual(ex.InnerException.GetType(), typeof(ArgumentException));

            string checkMessage = ex.InnerException.Message;

            Assert.AreEqual(expectedOutput04, checkMessage);
        }

        //T05TestRegister.cs
        private Type sut05 = typeof(PCController);
        private object[] user05 = { new List<string>() { "", "1234.56" } };
        PCController manager05 = new PCController();
        private string expectedOutput05 =
            $"Username must not be null or empty!";

        [TestMethod]
        public void TestMethod05()
        {
            var register = sut05.GetMethod("RegisterUser");

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => register.Invoke(manager05, user05));

            Assert.AreEqual(ex.InnerException.GetType(), typeof(ArgumentException));

            string checkMessage = ex.InnerException.Message;

            Assert.AreEqual(expectedOutput05, checkMessage);
        }

        //02CreateComputerTests --------------------------------------------------------
        //T01TestCreateComputer.cs
        private Type controllerType06 = typeof(PCController);
        private List<List<string>> users06 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers06 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "ProcModel", "3", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller06 = new PCController();

        private string expectedOutput06 = "Successfully created computer for user: Gosho!";

        [TestMethod]
        public void TestMethod06()
        {
            CreateUsers06();

            MethodInfo createComputer = controllerType06.GetMethod("CreateComputer");

            object[] param = new object[] { computers06[0] };

            string result = (string)createComputer.Invoke(controller06, param);

            Assert.AreEqual(expectedOutput06, result);
        }

        private void CreateUsers06()
        {
            var register = controllerType06.GetMethod("RegisterUser");

            for (int i = 0; i < users06.Count; i++)
            {
                object[] param = new object[] { users06[i] };

                register.Invoke(controller06, param);
            }
        }

        //T02TestCreateComputerUserNoMoney.cs
        private Type controllerType07 = typeof(PCController);
        private List<List<string>> users07 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "123.56" } },
    };

        private List<List<string>> computers07 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "ProcModel", "3", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller07 = new PCController();

        private string expectedOutput07 = "User: Gosho - insufficient funds!";

        [TestMethod]
        public void TestMethod07()
        {
            CreateUsers07();

            MethodInfo createComputer = controllerType07.GetMethod("CreateComputer");

            object[] param = new object[] { computers07[0] };

            string result = (string)createComputer.Invoke(controller07, param);

            Assert.AreEqual(expectedOutput07, result);
        }

        private void CreateUsers07()
        {
            var register = controllerType07.GetMethod("RegisterUser");

            for (int i = 0; i < users07.Count; i++)
            {
                object[] param = new object[] { users07[i] };

                register.Invoke(controller07, param);
            }
        }

        //T03TestCreateComputerInvalidTypeProcessor.cs
        private Type controllerType08 = typeof(PCController);
        private List<List<string>> users08 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "123.56" } },
    };

        private List<List<string>> computers08 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "LowProc", "ProcModel", "3", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller08 = new PCController();

        private string expectedOutput08 = "Invalid type processor!";

        [TestMethod]
        public void TestMethod08()
        {
            CreateUsers08();

            MethodInfo createComputer = controllerType08.GetMethod("CreateComputer");

            object[] param = new object[] { computers08[0] };

            string result = (string)createComputer.Invoke(controller08, param);

            Assert.AreEqual(expectedOutput08, result);
        }

        private void CreateUsers08()
        {
            var register = controllerType08.GetMethod("RegisterUser");

            for (int i = 0; i < users08.Count; i++)
            {
                object[] param = new object[] { users08[i] };

                register.Invoke(controller08, param);
            }
        }

        //T04TestCreateComputerInvalidTypeVideoCard.cs
        private Type controllerType09 = typeof(PCController);
        private List<List<string>> users09 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "123.56" } },
    };

        private List<List<string>> computers09 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "ProcModel", "3", "124.56", "GameInvalid", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller09 = new PCController();

        private string expectedOutput09 = "Invalid type video card!";

        [TestMethod]
        public void TestMethod09()
        {
            CreateUsers09();

            MethodInfo createComputer = controllerType09.GetMethod("CreateComputer");

            object[] param = new object[] { computers09[0] };

            string result = (string)createComputer.Invoke(controller09, param);

            Assert.AreEqual(expectedOutput09, result);
        }

        private void CreateUsers09()
        {
            var register = controllerType09.GetMethod("RegisterUser");

            for (int i = 0; i < users09.Count; i++)
            {
                object[] param = new object[] { users09[i] };

                register.Invoke(controller09, param);
            }
        }

        //T05TestCreateComputerMissingUser.cs
        private Type controllerType10 = typeof(PCController);
        private List<List<string>> users10 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "123.56" } },
    };

        private List<List<string>> computers10 = new List<List<string>>()
    {
        {new List<string>(){ "Ivan", "Low", "ProcModel", "3", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller10 = new PCController();

        private string expectedOutput10 = "Username: Ivan does not exist!";

        [TestMethod]
        public void TestMethod10()
        {
            CreateUsers10();

            MethodInfo createComputer = controllerType10.GetMethod("CreateComputer");

            object[] param = new object[] { computers10[0] };

            string result = (string)createComputer.Invoke(controller10, param);

            Assert.AreEqual(expectedOutput10, result);
        }

        private void CreateUsers10()
        {
            var register = controllerType10.GetMethod("RegisterUser");

            for (int i = 0; i < users10.Count; i++)
            {
                object[] param = new object[] { users10[i] };

                register.Invoke(controller10, param);
            }
        }

        //Exceptions -------------------------------------------------------------------
        //T06TestCreateComputerProcessorModelNull*/
        private Type controllerType11 = typeof(PCController);
        private List<List<string>> users11 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers11 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", null, "3", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller11 = new PCController();

        private string expectedOutput11 = "Model cannot be null or empty!";

        [TestMethod]
        public void TestMethod11()
        {
            CreateUsers11();

            MethodInfo createComputer = controllerType11.GetMethod("CreateComputer");

            object[] param = new object[] { computers11[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller11, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput11, ex.InnerException.Message);
        }

        private void CreateUsers11()
        {
            var register = controllerType11.GetMethod("RegisterUser");

            for (int i = 0; i < users11.Count; i++)
            {
                object[] param = new object[] { users11[i] };

                register.Invoke(controller11, param);
            }
        }

        //T07TestCreateComputerProcessorModelIsEmpty.cs
        private Type controllerType12 = typeof(PCController);
        private List<List<string>> users12 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "", "3", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller12 = new PCController();

        private string expectedOutput12 = "Model cannot be null or empty!";

        [TestMethod]
        public void TestMethod12()
        {
            CreateUsers12();

            MethodInfo createComputer = controllerType12.GetMethod("CreateComputer");

            object[] param = new object[] { computers[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller12, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput12, ex.InnerException.Message);
        }

        private void CreateUsers12()
        {
            var register = controllerType12.GetMethod("RegisterUser");

            for (int i = 0; i < users12.Count; i++)
            {
                object[] param = new object[] { users12[i] };

                register.Invoke(controller12, param);
            }
        }

        /*T08TestCreateComputerProcessorInvalidGenerationBelowZero.cs*/
        private Type controllerType13 = typeof(PCController);
        private List<List<string>> users13 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers13 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "-5", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller13 = new PCController();

        private string expectedOutput13 = "Generation cannot be 0 or negative!";

        [TestMethod]
        public void TestMethod13()
        {
            CreateUsers13();

            MethodInfo createComputer = controllerType13.GetMethod("CreateComputer");

            object[] param = new object[] { computers13[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller13, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput13, ex.InnerException.Message);
        }

        private void CreateUsers13()
        {
            var register = controllerType13.GetMethod("RegisterUser");

            for (int i = 0; i < users13.Count; i++)
            {
                object[] param = new object[] { users13[i] };

                register.Invoke(controller13, param);
            }
        }

        /*T09TestCreateComputerProcessorInvalidGenerationAboveNine.cs*/
        private Type controllerType14 = typeof(PCController);
        private List<List<string>> users14 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers14 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "12", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller14 = new PCController();

        private string expectedOutput14 = "LowPerformanceProcessor generation cannot be more than 9!";

        [TestMethod]
        public void TestMethod14()
        {
            CreateUsers14();

            MethodInfo createComputer = controllerType14.GetMethod("CreateComputer");

            object[] param = new object[] { computers14[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller14, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput14, ex.InnerException.Message);
        }

        private void CreateUsers14()
        {
            var register = controllerType14.GetMethod("RegisterUser");

            for (int i = 0; i < users14.Count; i++)
            {
                object[] param = new object[] { users14[i] };

                register.Invoke(controller14, param);
            }
        }

        /*T10TestCreateComputerPriceOfProcessorOrVideoCardBelowZero.cs*/
        private Type controllerType15 = typeof(PCController);
        private List<List<string>> users15 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers15 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "5", "-256", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller15 = new PCController();

        private string expectedOutput15 = "Price cannot be less or equal to 0 and more than 10000!";

        [TestMethod]
        public void TestMethod15()
        {
            CreateUsers15();

            MethodInfo createComputer = controllerType15.GetMethod("CreateComputer");

            object[] param = new object[] { computers15[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller15, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput15, ex.InnerException.Message);
        }

        private void CreateUsers15()
        {
            var register = controllerType15.GetMethod("RegisterUser");

            for (int i = 0; i < users15.Count; i++)
            {
                object[] param = new object[] { users15[i] };

                register.Invoke(controller15, param);
            }
        }


        /*T11TestCreateComputerPriceOfProcessorOrVideoCardEqualToZero.cs*/
        private Type controllerType16 = typeof(PCController);
        private List<List<string>> users16 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers16 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "5", "0", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller16 = new PCController();

        private string expectedOutput16 = "Price cannot be less or equal to 0 and more than 10000!";

        [TestMethod]
        public void TestMethod16()
        {
            CreateUsers16();

            MethodInfo createComputer = controllerType16.GetMethod("CreateComputer");

            object[] param = new object[] { computers16[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller16, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput16, ex.InnerException.Message);
        }

        private void CreateUsers16()
        {
            var register = controllerType16.GetMethod("RegisterUser");

            for (int i = 0; i < users16.Count; i++)
            {
                object[] param = new object[] { users16[i] };

                register.Invoke(controller16, param);
            }
        }

        //T12TestCreateComputerPriceOfProcessorOrVideoCardAboveTenThousand.cs
        private Type controllerType17 = typeof(PCController);
        private List<List<string>> users17 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers17 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "5", "12000", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller17 = new PCController();

        private string expectedOutput17 = "Price cannot be less or equal to 0 and more than 10000!";

        [TestMethod]
        public void TestMethod17()
        {
            CreateUsers17();

            MethodInfo createComputer = controllerType17.GetMethod("CreateComputer");

            object[] param = new object[] { computers17[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller17, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput17, ex.InnerException.Message);
        }

        private void CreateUsers17()
        {
            var register = controllerType17.GetMethod("RegisterUser");

            for (int i = 0; i < users17.Count; i++)
            {
                object[] param = new object[] { users17[i] };

                register.Invoke(controller17, param);
            }
        }

        //T13TestCreateComputerVideoCardRamBelowZero.cs
        private Type controllerType18 = typeof(PCController);
        private List<List<string>> users18 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers18 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "5", "120", "Game", "VideoModel", "5", "-25", "258", "8"  } },
    };
        private PCController controller18 = new PCController();

        private string expectedOutput18 = "GameVideoCard ram cannot be less or equal to 0 and more than 32!";

        [TestMethod]
        public void TestMethod18()
        {
            CreateUsers18();

            MethodInfo createComputer = controllerType18.GetMethod("CreateComputer");

            object[] param = new object[] { computers18[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller18, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput18, ex.InnerException.Message);
        }

        private void CreateUsers18()
        {
            var register = controllerType18.GetMethod("RegisterUser");

            for (int i = 0; i < users18.Count; i++)
            {
                object[] param = new object[] { users18[i] };

                register.Invoke(controller18, param);
            }
        }

        //T14TestCreateComputerVideoCardRamEqualToZero.cs
        private Type controllerType19 = typeof(PCController);
        private List<List<string>> users19 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers19 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "5", "120", "Game", "VideoModel", "5", "0", "258", "8"  } },
    };
        private PCController controller19 = new PCController();

        private string expectedOutput19 = "GameVideoCard ram cannot be less or equal to 0 and more than 32!";

        [TestMethod]
        public void TestMethod19()
        {
            CreateUsers19();

            MethodInfo createComputer = controllerType19.GetMethod("CreateComputer");

            object[] param = new object[] { computers19[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller19, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput19, ex.InnerException.Message);
        }

        private void CreateUsers19()
        {
            var register = controllerType19.GetMethod("RegisterUser");

            for (int i = 0; i < users19.Count; i++)
            {
                object[] param = new object[] { users19[i] };

                register.Invoke(controller19, param);
            }
        }

        //T15TestCreateComputerVideoCardRamAboveThirtyTwo.cs
        private Type controllerType20 = typeof(PCController);
        private List<List<string>> users20 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers20 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "5", "120", "Game", "VideoModel", "5", "64", "258", "8"  } },
    };
        private PCController controller20 = new PCController();

        private string expectedOutput20 = "GameVideoCard ram cannot be less or equal to 0 and more than 32!";

        [TestMethod]
        public void TestMethod20()
        {
            CreateUsers20();

            MethodInfo createComputer = controllerType20.GetMethod("CreateComputer");

            object[] param = new object[] { computers20[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller20, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput20, ex.InnerException.Message);
        }

        private void CreateUsers20()
        {
            var register = controllerType20.GetMethod("RegisterUser");

            for (int i = 0; i < users20.Count; i++)
            {
                object[] param = new object[] { users20[i] };

                register.Invoke(controller20, param);
            }
        }

        //T16TestCreateComputerComputerRamBelowZero.cs
        private Type controllerType21 = typeof(PCController);
        private List<List<string>> users21 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers21 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "5", "120", "Game", "VideoModel", "5", "8", "258", "-8"  } },
    };
        private PCController controller21 = new PCController();

        private string expectedOutput21 = "PC Ram cannot be less or equal to 0 and more than 32!";

        [TestMethod]
        public void TestMethod21()
        {
            CreateUsers21();

            MethodInfo createComputer = controllerType21.GetMethod("CreateComputer");

            object[] param = new object[] { computers21[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller21, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput21, ex.InnerException.Message);
        }

        private void CreateUsers21()
        {
            var register = controllerType21.GetMethod("RegisterUser");

            for (int i = 0; i < users21.Count; i++)
            {
                object[] param = new object[] { users21[i] };

                register.Invoke(controller21, param);
            }
        }

        //T17TestCreateComputerComputerRamEqualToZero.cs
        private Type controllerType22 = typeof(PCController);
        private List<List<string>> users22 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers22 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "5", "120", "Game", "VideoModel", "5", "8", "258", "0"  } },
    };
        private PCController controller22 = new PCController();

        private string expectedOutput22 = "PC Ram cannot be less or equal to 0 and more than 32!";

        [TestMethod]
        public void TestMethod22()
        {
            CreateUsers22();

            MethodInfo createComputer = controllerType22.GetMethod("CreateComputer");

            object[] param = new object[] { computers22[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller22, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput22, ex.InnerException.Message);
        }

        private void CreateUsers22()
        {
            var register = controllerType22.GetMethod("RegisterUser");

            for (int i = 0; i < users22.Count; i++)
            {
                object[] param = new object[] { users22[i] };

                register.Invoke(controller22, param);
            }
        }

        //T18TestCreateComputerComputerRamAboveThirtyTwo.cs
        private Type controllerType23 = typeof(PCController);
        private List<List<string>> users23 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers23 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "Model", "5", "120", "Game", "VideoModel", "5", "8", "258", "64"  } },
    };
        private PCController controller23 = new PCController();

        private string expectedOutput23 = "PC Ram cannot be less or equal to 0 and more than 32!";

        [TestMethod]
        public void TestMethod23()
        {
            CreateUsers23();

            MethodInfo createComputer = controllerType23.GetMethod("CreateComputer");

            object[] param = new object[] { computers23[0] };

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createComputer.Invoke(controller23, param));

            Assert.AreEqual(typeof(ArgumentException), ex.InnerException.GetType());

            Assert.AreEqual(expectedOutput23, ex.InnerException.Message);
        }

        private void CreateUsers23()
        {
            var register = controllerType23.GetMethod("RegisterUser");

            for (int i = 0; i < users23.Count; i++)
            {
                object[] param = new object[] { users23[i] };

                register.Invoke(controller23, param);
            }
        }

        //03MineTests ------------------------------------------------------------------
        //T01TestMineWithoutAnyUsers.cs
        private Type controllerType24 = typeof(PCController);
        private PCController controller24 = new PCController();
        private string expectedOutput24 = "Daily profits: 0!";

        [TestMethod]
        public void TestMethod24()
        {
            MethodInfo mine = controllerType24.GetMethod("Mine");

            string result = (string)mine.Invoke(controller24, new object[] { });

            Assert.AreEqual(expectedOutput24, result);
        }
        //T02TestMineWithOneUsersWithoutComputer.cs
        private Type controllerType25 = typeof(PCController);
        private List<List<string>> users25 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };
        private PCController controller25 = new PCController();

        private string expectedOutput25 = "Daily profits: 0!";

        [TestMethod]
        public void TestMethod25()
        {
            CreateUsers25();

            MethodInfo mine = controllerType25.GetMethod("Mine");

            string result = (string)mine.Invoke(controller25, new object[] { });

            Assert.AreEqual(expectedOutput25, result);
        }

        private void CreateUsers25()
        {
            var register = controllerType25.GetMethod("RegisterUser");

            for (int i = 0; i < users25.Count; i++)
            {
                object[] param = new object[] { users25[i] };

                register.Invoke(controller25, param);
            }
        }
        //T03TestMineWithOneUsersWithComputer.cs
        private Type controllerType26 = typeof(PCController);
        private List<List<string>> users26 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers26 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "ProcModel", "3", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller26 = new PCController();

        private string expectedOutput26 = "Daily profits: 192!";

        [TestMethod]
        public void TestMethod26()
        {
            CreateUsers26();
            CreateComputers26();

            MethodInfo mine = controllerType26.GetMethod("Mine");

            string result = (string)mine.Invoke(controller26, new object[] { });

            Assert.AreEqual(expectedOutput26, result);
        }

        private void CreateComputers26()
        {
            MethodInfo createComputer = controllerType26.GetMethod("CreateComputer");

            for (int i = 0; i < users26.Count; i++)
            {
                object[] param = new object[] { computers26[i] };

                createComputer.Invoke(controller26, param);
            }
        }

        private void CreateUsers26()
        {
            var register = controllerType26.GetMethod("RegisterUser");

            for (int i = 0; i < users26.Count; i++)
            {
                object[] param = new object[] { users26[i] };

                register.Invoke(controller26, param);
            }
        }
        //T04TestMineWithOneUsersWithDeadProcessor.cs
        private Type controllerType27 = typeof(PCController);
        private List<List<string>> users27 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers27 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "ProcModel", "3", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller27 = new PCController();

        private string expectedOutput27 = "Daily profits: 0!";

        [TestMethod]
        public void TestMethod27()
        {
            CreateUsers27();
            CreateComputers27();

            User user27 = ((Dictionary<string, User>)controllerType27
                .GetField("users", BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(controller27))["Gosho"];

            user27.Computer.Processor.LifeWorkingHours = 0;

            MethodInfo mine = controllerType27.GetMethod("Mine");

            string result = (string)mine.Invoke(controller27, new object[] { });

            Assert.AreEqual(expectedOutput27, result);
        }

        private void CreateComputers27()
        {
            MethodInfo createComputer = controllerType27.GetMethod("CreateComputer");

            for (int i = 0; i < users27.Count; i++)
            {
                object[] param = new object[] { computers27[i] };

                createComputer.Invoke(controller27, param);
            }
        }

        private void CreateUsers27()
        {
            var register = controllerType27.GetMethod("RegisterUser");

            for (int i = 0; i < users27.Count; i++)
            {
                object[] param = new object[] { users27[i] };

                register.Invoke(controller27, param);
            }
        }
        //T05TestMineWithOneUsersWithDeadVideoCard.cs
        private Type controllerType28 = typeof(PCController);
        private List<List<string>> users28 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };

        private List<List<string>> computers28 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "ProcModel", "3", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller28 = new PCController();

        private string expectedOutput28 = "Daily profits: 0!";

        [TestMethod]
        public void TestMethod28()
        {
            CreateUsers28();
            CreateComputers28();

            User user28 = ((Dictionary<string, User>)controllerType28
                .GetField("users", BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(controller28))["Gosho"];

            user28.Computer.VideoCard.LifeWorkingHours = 0;

            MethodInfo mine = controllerType28.GetMethod("Mine");

            string result = (string)mine.Invoke(controller28, new object[] { });

            Assert.AreEqual(expectedOutput28, result);
        }

        private void CreateComputers28()
        {
            MethodInfo createComputer = controllerType28.GetMethod("CreateComputer");

            for (int i = 0; i < users28.Count; i++)
            {
                object[] param = new object[] { computers28[i] };

                createComputer.Invoke(controller28, param);
            }
        }

        private void CreateUsers28()
        {
            var register = controllerType28.GetMethod("RegisterUser");

            for (int i = 0; i < users28.Count; i++)
            {
                object[] param = new object[] { users28[i] };

                register.Invoke(controller28, param);
            }
        }
        //04UserInfoTests --------------------------------------------------------------
        //T01TestUserInfoWithoutAnyUsers.cs
        private Type controllerType29 = typeof(PCController);
        private PCController controller29 = new PCController();

        private string expectedOutput29 = "Username: Gosho does not exist!";

        [TestMethod]
        public void TestMethod29()
        {
            MethodInfo userInfo = controllerType29.GetMethod("UserInfo");

            string result = (string)userInfo.Invoke(controller29, new object[] { new List<string>() { "Gosho" } });

            Assert.AreEqual(expectedOutput29, result);
        }
        //T02TestUserInfoWithUsers.cs
        private Type controllerType30 = typeof(PCController);
        private List<List<string>> users30 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };
        private PCController controller30 = new PCController();

        private string expectedOutput30 = $"Name: Gosho - Stars: {(int)1234.56 / 100}{Environment.NewLine}Balance: 1234.56";

        [TestMethod]
        public void TestMethod30()
        {
            CreateUsers30();

            MethodInfo userInfo = controllerType30.GetMethod("UserInfo");

            string result = (string)userInfo.Invoke(controller30, new object[] { new List<string>() { "Gosho" } });

            Assert.AreEqual(expectedOutput30, result);
        }

        private void CreateUsers30()
        {
            var register = controllerType30.GetMethod("RegisterUser");

            for (int i = 0; i < users30.Count; i++)
            {
                object[] paramss = { users30[i] };

                register.Invoke(controller30, paramss);
            }
        }
        //T03TestUserInfoWithUsersAndComputer.cs
        private Type controllerType31 = typeof(PCController);
        private List<List<string>> users31 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };
        private List<List<string>> computers31 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "Low", "ProcModel", "3", "124.56", "Game", "VideoModel", "5", "4", "258", "8"  } },
    };
        private PCController controller31 = new PCController();

        private string expectedOutput31 = $"Name: Gosho - Stars: 8{Environment.NewLine}Balance: 852.00{Environment.NewLine}PC Ram: 8{Environment.NewLine}  - LowPerformanceProcessor - ProcModel - 3{Environment.NewLine}  - GameVideoCard - VideoModel - 5{Environment.NewLine}    * Video card Ram: 4";

        [TestMethod]
        public void TestMethod31()
        {
            CreateUsers31();
            CreateComputers31();

            MethodInfo userInfo = controllerType31.GetMethod("UserInfo");

            string result = (string)userInfo.Invoke(controller31, new object[] { new List<string>() { "Gosho" } });

            Assert.AreEqual(expectedOutput31, result);
        }

        private void CreateComputers31()
        {
            MethodInfo createComputer = controllerType31.GetMethod("CreateComputer");

            for (int i = 0; i < users31.Count; i++)
            {
                object[] param = new object[] { computers31[i] };

                createComputer.Invoke(controller31, param);
            }
        }

        private void CreateUsers31()
        {
            var register = controllerType31.GetMethod("RegisterUser");

            for (int i = 0; i < users31.Count; i++)
            {
                object[] paramss = { users31[i] };

                register.Invoke(controller31, paramss);
            }
        }

        // 05ShutdownTests -------------------------------------------------------------
        //T01TestShutdownWithoutUsers.cs
        private Type controllerType32 = typeof(PCController);
        private List<List<string>> users32 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };
        private PCController controller32 = new PCController();

        private string expectedOutput32 = "System total profits: 0!!!";

        [TestMethod]
        public void TestMethod32()
        {
            MethodInfo mine = controllerType32.GetMethod("Shutdown");

            string result = (string)mine.Invoke(controller32, new object[] { });

            Assert.AreEqual(expectedOutput32, result);
        }

        private void CreateUsers32()
        {
            var register = controllerType32.GetMethod("RegisterUser");

            for (int i = 0; i < users32.Count; i++)
            {
                object[] param = new object[] { users32[i] };

                register.Invoke(controller32, param);
            }
        }
        //T02TestShutdownWithOneUsers.cs
        private Type controllerType33 = typeof(PCController);
        private List<List<string>> users33 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
    };
        private PCController controller33 = new PCController();

        private string expectedOutput33 = $"Name: Gosho - Stars: {(int)1234.56 / 100}{Environment.NewLine}Balance: 1234.56{Environment.NewLine}System total profits: 0!!!";

        [TestMethod]
        public void TestMethod33()
        {
            CreateUsers33();

            MethodInfo mine = controllerType33.GetMethod("Shutdown");

            string result = (string)mine.Invoke(controller33, new object[] { });

            Assert.AreEqual(expectedOutput33, result);
        }

        private void CreateUsers33()
        {
            var register = controllerType33.GetMethod("RegisterUser");

            for (int i = 0; i < users33.Count; i++)
            {
                object[] param = new object[] { users33[i] };

                register.Invoke(controller33, param);
            }
        }
        //T03TestShutdownOrderedUsersByStars.cs
        private Type controllerType34 = typeof(PCController);
        private List<List<string>> users34 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
        {new List<string>(){ "Ivan", "12340.56" } },
    };
        private PCController controller34 = new PCController();

        private string expectedOutput34 = $"Name: Ivan - Stars: {(int)12340.56 / 100}{Environment.NewLine}Balance: 12340.56{Environment.NewLine}Name: Gosho - Stars: {(int)1234.56 / 100}{Environment.NewLine}Balance: 1234.56{Environment.NewLine}System total profits: 0!!!";

        [TestMethod]
        public void TestMethod34()
        {
            CreateUsers34();

            MethodInfo mine = controllerType34.GetMethod("Shutdown");

            string result = (string)mine.Invoke(controller34, new object[] { });

            Assert.AreEqual(expectedOutput34, result);
        }

        private void CreateUsers34()
        {
            var register = controllerType34.GetMethod("RegisterUser");

            for (int i = 0; i < users34.Count; i++)
            {
                object[] param = new object[] { users34[i] };

                register.Invoke(controller34, param);
            }
        }
        //T04TestShutdownOrderedUsersThenByName.cs
        private Type controllerType35 = typeof(PCController);
        private List<List<string>> users35 = new List<List<string>>()
    {
        {new List<string>(){ "Gosho", "1234.56" } },
        {new List<string>(){ "Ivan", "1234.56" } },
    };
        private PCController controller35 = new PCController();

        private string expectedOutput35 = $"Name: Gosho - Stars: {(int)1234.56 / 100}{Environment.NewLine}Balance: 1234.56{Environment.NewLine}Name: Ivan - Stars: {(int)1234.56 / 100}{Environment.NewLine}Balance: 1234.56{Environment.NewLine}System total profits: 0!!!";

        [TestMethod]
        public void TestMethod35()
        {
            CreateUsers35();

            MethodInfo mine = controllerType35.GetMethod("Shutdown");

            string result = (string)mine.Invoke(controller35, new object[] { });

            Assert.AreEqual(expectedOutput35, result);
        }

        private void CreateUsers35()
        {
            var register = controllerType35.GetMethod("RegisterUser");

            for (int i = 0; i < users35.Count; i++)
            {
                object[] param = new object[] { users35[i] };

                register.Invoke(controller35, param);
            }
        }
    }
}
