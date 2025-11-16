using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    using HeroFight.Core;
    using System.Collections.Generic;
    using System.Reflection;

    [TestClass]
    public class BusinessLogic
    {

        //01CreateHeroTests ========================================================
        //T01.cs
        private Type sut01 = typeof(ArenaController);
        private object[] createHeroArgs01 = { new List<string>() { "Assassin", "Gosho" } };
        private ArenaController arenaController01 = new ArenaController();
        private string expectedOutput01 =
            $"Assassin: Gosho joined the Arena!";

        [TestMethod]
        public void TestCreateHero()
        {
            var createHero = sut01.GetMethod("CreateHero");

            string checkMessage = (string)createHero.Invoke(arenaController01, createHeroArgs01);

            Assert.AreEqual(expectedOutput01, checkMessage);
        }

        //T02.cs
        private Type sut02 = typeof(ArenaController);
        private object[] createHeroArgs02 = { new List<string>() { "InvalidType", "Gosho" } };
        private ArenaController arenaController02 = new ArenaController();
        private string expectedOutput02 =
            $"Invalid type hero: InvalidType.";

        [TestMethod]
        public void TestCreateHeroWithInvalidType()
        {
            var createHero = sut02.GetMethod("CreateHero");

            string checkMessage = (string)createHero.Invoke(arenaController02, createHeroArgs02);

            Assert.AreEqual(expectedOutput02, checkMessage);
        }


        //T03.cs
        private Type sut03 = typeof(ArenaController);
        private object[] createHeroArgs03 = { new List<string>() { "Assassin", "Gosho" } };
        private ArenaController arenaController03 = new ArenaController();
        private string expectedOutput03 =
            $"Hero with name: Gosho already exists!";

        [TestMethod]
        public void TestCreateHeroWithDuplicatedName()
        {
            var createHero = sut03.GetMethod("CreateHero");

            createHero.Invoke(arenaController03, createHeroArgs03);
            string checkMessage = (string)createHero.Invoke(arenaController03, createHeroArgs03);

            Assert.AreEqual(expectedOutput03, checkMessage);
        }


        //T04.cs
        private Type sut04 = typeof(ArenaController);
        private object[] createHeroArgs04 = { new List<string>() { "Assassin", "" } };
        private ArenaController arenaController04 = new ArenaController();
        private string expectedOutput04 =
            $"Hero name cannot be null, empty or whitespace.";

        [TestMethod]
        public void TestCreateHeroWithEmptyName()
        {
            var createHero = sut04.GetMethod("CreateHero");

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createHero.Invoke(arenaController04, createHeroArgs04));

            Type expectedException = typeof(ArgumentException);
            string checkMessage = ex.InnerException.Message;

            Assert.IsTrue(expectedException == ex.InnerException.GetType());
            Assert.AreEqual(expectedOutput04, checkMessage);
        }


        //T05.cs
        private Type sut05 = typeof(ArenaController);
        private object[] createHeroArgs05 = { new List<string>() { "Assassin", "   " } };
        private ArenaController arenaController05 = new ArenaController();
        private string expectedOutput05 =
            $"Hero name cannot be null, empty or whitespace.";

        [TestMethod]
        public void TestCreateHeroWithNameWhitespaces()
        {
            var createHero = sut05.GetMethod("CreateHero");

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createHero.Invoke(arenaController05, createHeroArgs05));

            Type expectedException = typeof(ArgumentException);
            string checkMessage = ex.InnerException.Message;

            Assert.IsTrue(expectedException == ex.InnerException.GetType());
            Assert.AreEqual(expectedOutput05, checkMessage);
        }


        //02CreateWeaponTests ========================================================
        //T01.cs
        private Type sut06 = typeof(ArenaController);
        private object[] createHeroArgs06 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createWeaponArgs06 = { new List<string>() { "Gosho", "Bow", "WrathOfTheTitans", "5", "5", "5", } };
        private ArenaController arenaController06 = new ArenaController();
        private string expectedOutput06 =
           $"Successfully armed hero Gosho with weapon Bow!";

        [TestMethod]
        public void TestCreateWeapon()
        {
            var createHero = sut06.GetMethod("CreateHero");
            var createWeapon = sut06.GetMethod("CreateWeapon");

            createHero.Invoke(arenaController06, createHeroArgs06);

            string checkMessage = (string)createWeapon.Invoke(arenaController06, createWeaponArgs06);

            Assert.AreEqual(expectedOutput06, checkMessage);
        }

        //T02.cs
        private Type sut07 = typeof(ArenaController);
        private object[] createWeaponArgs07 = { new List<string>() { "Gosho", "Bow", "WrathOfTheTitans", "5", "5", "5", } };
        private ArenaController arenaController07 = new ArenaController();
        private string expectedOutput07 =
           $"Hero with name: Gosho does not exist!";

        [TestMethod]
        public void TestCreateWeaponWithInvalidHeroName()
        {
            var createWeapon = sut07.GetMethod("CreateWeapon");

            string checkMessage = (string)createWeapon.Invoke(arenaController07, createWeaponArgs07);

            Assert.AreEqual(expectedOutput07, checkMessage);
        }


        //T03.cs
        private Type sut08 = typeof(ArenaController);
        private object[] createHeroArgs08 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createWeaponArgs08 = { new List<string>() { "Gosho", "InvalidType", "WrathOfTheTitans", "5", "5", "5", } };
        private ArenaController arenaController08 = new ArenaController();
        private string expectedOutput08 =
           $"Invalid type weapon: InvalidType.";

        [TestMethod]
        public void TestCreateWeaponWithInvalidType()
        {
            var createHero = sut08.GetMethod("CreateHero");
            var createWeapon = sut08.GetMethod("CreateWeapon");

            createHero.Invoke(arenaController08, createHeroArgs08);

            string checkMessage = (string)createWeapon.Invoke(arenaController08, createWeaponArgs08);

            Assert.AreEqual(expectedOutput08, checkMessage);
        }


        //T04.cs
        private Type sut09 = typeof(ArenaController);
        private object[] createHeroArgs09 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createWeaponArgs09 = { new List<string>() { "Gosho", "Bow", null, "5", "5", "5", } };
        private ArenaController arenaController09 = new ArenaController();
        private string expectedOutput09 =
           $"Weapon name cannot be null, empty or whitespace.";

        [TestMethod]
        public void TestCreateWeaponWithInvalidNameNull04()
        {
            var createHero = sut09.GetMethod("CreateHero");
            var createWeapon = sut09.GetMethod("CreateWeapon");

            createHero.Invoke(arenaController09, createHeroArgs09);

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createWeapon.Invoke(arenaController09, createWeaponArgs09));

            Type expectedException = typeof(ArgumentException);
            string checkMessage = ex.InnerException.Message;

            Assert.IsTrue(expectedException == ex.InnerException.GetType());
            Assert.AreEqual(expectedOutput09, checkMessage);


            Assert.AreEqual(expectedOutput09, checkMessage);
        }

        //T05.cs
        private Type sut10 = typeof(ArenaController);
        private object[] createHeroArgs10 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createWeaponArgs10 = { new List<string>() { "Gosho", "Bow", "", "5", "5", "5", } };
        private ArenaController arenaController10 = new ArenaController();
        private string expectedOutput10 =
           $"Weapon name cannot be null, empty or whitespace.";

        [TestMethod]
        public void TestCreateWeaponWithInvalidNameEmpty()
        {
            var createHero = sut10.GetMethod("CreateHero");
            var createWeapon = sut10.GetMethod("CreateWeapon");

            createHero.Invoke(arenaController10, createHeroArgs10);

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createWeapon.Invoke(arenaController10, createWeaponArgs10));

            Type expectedException = typeof(ArgumentException);
            string checkMessage = ex.InnerException.Message;

            Assert.IsTrue(expectedException == ex.InnerException.GetType());
            Assert.AreEqual(expectedOutput10, checkMessage);


            Assert.AreEqual(expectedOutput10, checkMessage);
        }

        //T06.cs
        private Type sut11 = typeof(ArenaController);
        private object[] createHeroArgs11 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createWeaponArgs11 = { new List<string>() { "Gosho", "Bow", "  ", "5", "5", "5", } };
        private ArenaController arenaController11 = new ArenaController();
        private string expectedOutput11 =
           $"Weapon name cannot be null, empty or whitespace.";

        [TestMethod]
        public void TestCreateWeaponWithInvalidNameNull()
        {
            var createHero = sut11.GetMethod("CreateHero");
            var createWeapon = sut11.GetMethod("CreateWeapon");

            createHero.Invoke(arenaController11, createHeroArgs11);

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createWeapon.Invoke(arenaController11, createWeaponArgs11));

            Type expectedException = typeof(ArgumentException);
            string checkMessage = ex.InnerException.Message;

            Assert.IsTrue(expectedException == ex.InnerException.GetType());
            Assert.AreEqual(expectedOutput11, checkMessage);


            Assert.AreEqual(expectedOutput11, checkMessage);
        }

        //T07.cs
        private Type sut12 = typeof(ArenaController);
        private object[] createHeroArgs12 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createWeaponArgs12 = { new List<string>() { "Gosho", "Bow", "WrathOfTheTitans", "-25", "5", "5", } };
        private ArenaController arenaController12 = new ArenaController();
        private string expectedOutput12 =
           $"Strength cannot be less than 0!";

        [TestMethod]
        public void TestCreateWeaponWithInvalidNegativeStrength()
        {
            var createHero = sut12.GetMethod("CreateHero");
            var createWeapon = sut12.GetMethod("CreateWeapon");

            createHero.Invoke(arenaController12, createHeroArgs12);

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createWeapon.Invoke(arenaController12, createWeaponArgs12));

            Type expectedException = typeof(ArgumentException);
            string checkMessage = ex.InnerException.Message;

            Assert.IsTrue(expectedException == ex.InnerException.GetType());
            Assert.AreEqual(expectedOutput12, checkMessage);


            Assert.AreEqual(expectedOutput12, checkMessage);
        }

        //T08.cs
        private Type sut13 = typeof(ArenaController);
        private object[] createHeroArgs13 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createWeaponArgs13 = { new List<string>() { "Gosho", "Bow", "WrathOfTheTitans", "5", "-25", "5", } };
        private ArenaController arenaController13 = new ArenaController();
        private string expectedOutput13 =
           $"Agility cannot be less than 0!";

        [TestMethod]
        public void TestCreateWeaponWithInvalidNegativeStrength08()
        {
            var createHero = sut13.GetMethod("CreateHero");
            var createWeapon = sut13.GetMethod("CreateWeapon");

            createHero.Invoke(arenaController13, createHeroArgs13);

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createWeapon.Invoke(arenaController13, createWeaponArgs13));

            Type expectedException = typeof(ArgumentException);
            string checkMessage = ex.InnerException.Message;

            Assert.IsTrue(expectedException == ex.InnerException.GetType());
            Assert.AreEqual(expectedOutput13, checkMessage);


            Assert.AreEqual(expectedOutput13, checkMessage);
        }

        //T09.cs
        private Type sut14 = typeof(ArenaController);
        private object[] createHeroArgs14 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createWeaponArgs14 = { new List<string>() { "Gosho", "Bow", "WrathOfTheTitans", "5", "5", "-25", } };
        private ArenaController arenaController14 = new ArenaController();
        private string expectedOutput14 =
           $"Intelligence cannot be less than 0!";

        [TestMethod]
        public void TestCreateWeaponWithInvalidNegativeStrength09()
        {
            var createHero = sut14.GetMethod("CreateHero");
            var createWeapon = sut14.GetMethod("CreateWeapon");

            createHero.Invoke(arenaController14, createHeroArgs14);

            TargetInvocationException ex = Assert.ThrowsException<TargetInvocationException>(() => createWeapon.Invoke(arenaController14, createWeaponArgs14));

            Type expectedException = typeof(ArgumentException);
            string checkMessage = ex.InnerException.Message;

            Assert.IsTrue(expectedException == ex.InnerException.GetType());
            Assert.AreEqual(expectedOutput14, checkMessage);


            Assert.AreEqual(expectedOutput14, checkMessage);
        }


        //03FightTests ========================================================    	
        //T01.cs
        private Type sut15 = typeof(ArenaController);
        private object[] createFirstHeroArgs15 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createSecondHeroArgs15 = { new List<string>() { "Assassin", "Pesho" } };

        private object[] createFirstWeaponArgs15 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "15", "10", "5", } };

        private object[] createSecondWeaponArgs15 = { new List<string>() { "Pesho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] fightArgs15 = { new List<string>() { "Gosho", "Pesho" } };

        private ArenaController arenaController15 = new ArenaController();
        private string expectedOutput15 =
           $"Winner in the battle between Gosho and Pesho is Gosho with 90.00.";

        [TestMethod]
        public void TestFightWithWinner()
        {
            var createHero = sut15.GetMethod("CreateHero");
            var createWeapon = sut15.GetMethod("CreateWeapon");
            var fight = sut15.GetMethod("Fight");

            createHero.Invoke(arenaController15, createFirstHeroArgs15);
            createHero.Invoke(arenaController15, createSecondHeroArgs15);

            createWeapon.Invoke(arenaController15, createFirstWeaponArgs15);
            createWeapon.Invoke(arenaController15, createSecondWeaponArgs15);

            string checkMessage = (string)fight.Invoke(arenaController15, fightArgs15);

            Assert.AreEqual(expectedOutput15, checkMessage);
        }

        //T02.cs
        private Type sut16 = typeof(ArenaController);
        private object[] createFirstHeroArgs16 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createSecondHeroArgs16 = { new List<string>() { "Assassin", "Pesho" } };

        private object[] createFirstWeaponArgs16 = { new List<string>() { "Pesho", "Sword", "WrathOfTheTitans", "15", "10", "5", } };

        private object[] createSecondWeaponArgs16 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] fightArgs16 = { new List<string>() { "Gosho", "Pesho" } };

        private ArenaController arenaController16 = new ArenaController();
        private string expectedOutput16 =
           $"Winner in the battle between Gosho and Pesho is Pesho with 90.00.";

        [TestMethod]
        public void TestFightWithWinner02()
        {
            var createHero = sut16.GetMethod("CreateHero");
            var createWeapon = sut16.GetMethod("CreateWeapon");
            var fight = sut16.GetMethod("Fight");

            createHero.Invoke(arenaController16, createFirstHeroArgs16);
            createHero.Invoke(arenaController16, createSecondHeroArgs16);

            createWeapon.Invoke(arenaController16, createFirstWeaponArgs16);
            createWeapon.Invoke(arenaController16, createSecondWeaponArgs16);

            string checkMessage = (string)fight.Invoke(arenaController16, fightArgs16);

            Assert.AreEqual(expectedOutput16, checkMessage);
        }


        //T03.cs
        private Type sut17 = typeof(ArenaController);
        private object[] createFirstHeroArgs17 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createSecondHeroArgs17 = { new List<string>() { "Assassin", "Pesho" } };

        private object[] createFirstWeaponArgs17 = { new List<string>() { "Pesho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] createSecondWeaponArgs17 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] fightArgs17 = { new List<string>() { "Gosho", "Pesho" } };

        private ArenaController arenaController17 = new ArenaController();
        private string expectedOutput17 =
           $"No winner in battle between Gosho and Pesho!";

        [TestMethod]
        public void TestFightWithEqualPower()
        {
            var createHero = sut17.GetMethod("CreateHero");
            var createWeapon = sut17.GetMethod("CreateWeapon");
            var fight = sut17.GetMethod("Fight");

            createHero.Invoke(arenaController17, createFirstHeroArgs17);
            createHero.Invoke(arenaController17, createSecondHeroArgs17);

            createWeapon.Invoke(arenaController17, createFirstWeaponArgs17);
            createWeapon.Invoke(arenaController17, createSecondWeaponArgs17);

            string checkMessage = (string)fight.Invoke(arenaController17, fightArgs17);

            Assert.AreEqual(expectedOutput17, checkMessage);
        }


        //T04.cs
        private Type sut18 = typeof(ArenaController);
        private object[] createFirstHeroArgs18 = { new List<string>() { "Assassin", "Pesho" } };

        private object[] createFirstWeaponArgs18 = { new List<string>() { "Pesho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] fightArgs18 = { new List<string>() { "Gosho", "Pesho" } };

        private ArenaController arenaController18 = new ArenaController();
        private string expectedOutput18 =
           $"Hero with name: Gosho does not exist!";

        [TestMethod]
        public void TestFightWithMissingFirstHeroName()
        {
            var createHero = sut18.GetMethod("CreateHero");
            var createWeapon = sut18.GetMethod("CreateWeapon");
            var fight = sut18.GetMethod("Fight");

            createHero.Invoke(arenaController18, createFirstHeroArgs18);

            createWeapon.Invoke(arenaController18, createFirstWeaponArgs18);

            string checkMessage = (string)fight.Invoke(arenaController18, fightArgs18);

            Assert.AreEqual(expectedOutput18, checkMessage);
        }


        //T05.cs
        private Type sut19 = typeof(ArenaController);
        private object[] createFirstHeroArgs19 = { new List<string>() { "Assassin", "Gosho" } };

        private object[] createFirstWeaponArgs19 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] fightArgs19 = { new List<string>() { "Gosho", "Pesho" } };

        private ArenaController arenaController19 = new ArenaController();
        private string expectedOutput19 =
           $"Hero with name: Pesho does not exist!";

        [TestMethod]
        public void TestFightWithMissingSecondHeroName()
        {
            var createHero = sut19.GetMethod("CreateHero");
            var createWeapon = sut19.GetMethod("CreateWeapon");
            var fight = sut19.GetMethod("Fight");

            createHero.Invoke(arenaController19, createFirstHeroArgs19);

            createWeapon.Invoke(arenaController19, createFirstWeaponArgs19);

            string checkMessage = (string)fight.Invoke(arenaController19, fightArgs19);

            Assert.AreEqual(expectedOutput19, checkMessage);
        }


        //04HeroInfoTests =============================================================
        //T01.cs
        private Type sut20 = typeof(ArenaController);

        private object[] heroInfoArgs20 = { new List<string>() { "Gosho" } };

        private ArenaController arenaController20 = new ArenaController();
        private string expectedOutput20 =
           $"Hero with name: Gosho does not exist!";


        [TestMethod]
        public void TestHeroInfoWithInvalidHero()
        {
            var heroInfo = sut20.GetMethod("HeroInfo");

            string checkMessage = (string)heroInfo.Invoke(arenaController20, heroInfoArgs20);

            Assert.AreEqual(expectedOutput20, checkMessage);
        }

        //T02.cs
        private Type sut21 = typeof(ArenaController);
        private object[] createHeroArgs21 = { new List<string>() { "Assassin", "Gosho" } };

        private object[] heroInfoArgs21 = { new List<string>() { "Gosho" } };

        private ArenaController arenaController21 = new ArenaController();
        private string expectedOutput21 =
           $"Assassin: Gosho - Level: 0" + Environment.NewLine +
            "Experience: 0" + Environment.NewLine +
            "Power: 0.00";


        [TestMethod]
        public void TestHeroInfoWithValidHeroWithoutWeapon()
        {
            var createHero = sut21.GetMethod("CreateHero");
            var heroInfo = sut21.GetMethod("HeroInfo");

            createHero.Invoke(arenaController21, createHeroArgs21);

            string checkMessage = (string)heroInfo.Invoke(arenaController21, heroInfoArgs21);

            Assert.AreEqual(expectedOutput21, checkMessage);
        }

        //T03.cs
        private Type sut22 = typeof(ArenaController);
        private object[] createHeroArgs22 = { new List<string>() { "Assassin", "Gosho" } };

        private object[] createWeaponArgs22 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] heroInfoArgs22 = { new List<string>() { "Gosho" } };

        private ArenaController arenaController22 = new ArenaController();
        private string expectedOutput22 =
           $"Assassin: Gosho - Level: 0" + Environment.NewLine +
            "Experience: 0" + Environment.NewLine +
            "Sword: WrathOfTheTitans" + Environment.NewLine +
            "  *Strength: 20" + Environment.NewLine +
            "  *Agility: 5" + Environment.NewLine +
            "  *Intelligence: 5" + Environment.NewLine +
            "Power: 60.00";


        [TestMethod]
        public void TestHeroInfoWithValidHeroWithWeapon()
        {
            var createHero = sut22.GetMethod("CreateHero");
            var createWeapon = sut22.GetMethod("CreateWeapon");
            var heroInfo = sut22.GetMethod("HeroInfo");

            createHero.Invoke(arenaController22, createHeroArgs22);
            createWeapon.Invoke(arenaController22, createWeaponArgs22);

            string checkMessage = (string)heroInfo.Invoke(arenaController22, heroInfoArgs22);

            Assert.AreEqual(expectedOutput22, checkMessage);
        }


        //T04.cs
        private Type sut23 = typeof(ArenaController);
        private object[] createFirstHeroArgs23 = { new List<string>() { "Assassin", "Gosho" } };

        private object[] createSecondHeroArgs23 = { new List<string>() { "Assassin", "Pesho" } };

        private object[] createFirstWeaponArgs23 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] createSecondWeaponArgs23 = { new List<string>() { "Pesho", "Sword", "WrathOfTheTitans", "0", "0", "5", } };



        private object[] fightArgs23 = { new List<string>() { "Gosho", "Pesho" } };
        private object[] heroInfoArgs23 = { new List<string>() { "Gosho" } };

        private ArenaController arenaController23 = new ArenaController();
        private string expectedOutput23 =
           $"Assassin: Gosho - Level: 0" + Environment.NewLine +
            "Experience: 30" + Environment.NewLine +
            "Sword: WrathOfTheTitans" + Environment.NewLine +
            "  *Strength: 20" + Environment.NewLine +
            "  *Agility: 5" + Environment.NewLine +
            "  *Intelligence: 5" + Environment.NewLine +
            "Power: 60.00";


        [TestMethod]
        public void TestHeroInfoWithValidHeroWithWeaponAndWinningExp()
        {
            var createHero = sut23.GetMethod("CreateHero");
            var createWeapon = sut23.GetMethod("CreateWeapon");
            var fight = sut23.GetMethod("Fight");
            var heroInfo = sut23.GetMethod("HeroInfo");

            createHero.Invoke(arenaController23, createFirstHeroArgs23);
            createHero.Invoke(arenaController23, createSecondHeroArgs23);

            createWeapon.Invoke(arenaController23, createFirstWeaponArgs23);
            createWeapon.Invoke(arenaController23, createSecondWeaponArgs23);

            fight.Invoke(arenaController23, fightArgs23);

            string checkMessage = (string)heroInfo.Invoke(arenaController23, heroInfoArgs23);

            Assert.AreEqual(expectedOutput23, checkMessage);
        }


        //T05.cs
        private Type sut24 = typeof(ArenaController);
        private object[] createFirstHeroArgs24 = { new List<string>() { "Assassin", "Gosho" } };

        private object[] createSecondHeroArgs24 = { new List<string>() { "Assassin", "Pesho" } };

        private object[] createFirstWeaponArgs24 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] createSecondWeaponArgs24 = { new List<string>() { "Pesho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };



        private object[] fightArgs24 = { new List<string>() { "Gosho", "Pesho" } };
        private object[] heroInfoArgs24 = { new List<string>() { "Gosho" } };

        private ArenaController arenaController24 = new ArenaController();
        private string expectedOutput24 =
           $"Assassin: Gosho - Level: 0" + Environment.NewLine +
            "Experience: 15" + Environment.NewLine +
            "Sword: WrathOfTheTitans" + Environment.NewLine +
            "  *Strength: 20" + Environment.NewLine +
            "  *Agility: 5" + Environment.NewLine +
            "  *Intelligence: 5" + Environment.NewLine +
            "Power: 60.00";


        [TestMethod]
        public void TestHeroInfoWithValidHeroWithWeaponAndEqualExp()
        {
            var createHero = sut24.GetMethod("CreateHero");
            var createWeapon = sut24.GetMethod("CreateWeapon");
            var fight = sut24.GetMethod("Fight");
            var heroInfo = sut24.GetMethod("HeroInfo");

            createHero.Invoke(arenaController24, createFirstHeroArgs24);
            createHero.Invoke(arenaController24, createSecondHeroArgs24);

            createWeapon.Invoke(arenaController24, createFirstWeaponArgs24);
            createWeapon.Invoke(arenaController24, createSecondWeaponArgs24);

            fight.Invoke(arenaController24, fightArgs24);

            string checkMessage = (string)heroInfo.Invoke(arenaController24, heroInfoArgs24);

            Assert.AreEqual(expectedOutput24, checkMessage);
        }


        //T06.cs
        private Type sut25 = typeof(ArenaController);
        private object[] createFirstHeroArgs25 = { new List<string>() { "Assassin", "Gosho" } };

        private object[] createSecondHeroArgs25 = { new List<string>() { "Assassin", "Pesho" } };

        private object[] createFirstWeaponArgs25 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] createSecondWeaponArgs25 = { new List<string>() { "Pesho", "Sword", "WrathOfTheTitans", "0", "0", "5", } };



        private object[] fightArgs25 = { new List<string>() { "Gosho", "Pesho" } };
        private object[] heroInfoArgs25 = { new List<string>() { "Gosho" } };

        private ArenaController arenaController25 = new ArenaController();
        private string expectedOutput25 =
           $"Assassin: Gosho - Level: 1" + Environment.NewLine +
            "Experience: 20" + Environment.NewLine +
            "Sword: WrathOfTheTitans" + Environment.NewLine +
            "  *Strength: 20" + Environment.NewLine +
            "  *Agility: 5" + Environment.NewLine +
            "  *Intelligence: 5" + Environment.NewLine +
            "Power: 60.00";


        [TestMethod]
        public void TestHeroInfoWithValidHeroWithWeaponWinningExpAndLevel()
        {
            var createHero = sut25.GetMethod("CreateHero");
            var createWeapon = sut25.GetMethod("CreateWeapon");
            var fight = sut25.GetMethod("Fight");
            var heroInfo = sut25.GetMethod("HeroInfo");

            createHero.Invoke(arenaController25, createFirstHeroArgs25);
            createHero.Invoke(arenaController25, createSecondHeroArgs25);

            createWeapon.Invoke(arenaController25, createFirstWeaponArgs25);
            createWeapon.Invoke(arenaController25, createSecondWeaponArgs25);

            for (int i = 0; i < 4; i++)
            {
                fight.Invoke(arenaController25, fightArgs25);
            }

            string checkMessage = (string)heroInfo.Invoke(arenaController25, heroInfoArgs25);

            Assert.AreEqual(expectedOutput25, checkMessage);
        }

        // 05CloseArenaTests ======================
        //T01.cs
        private Type sut26 = typeof(ArenaController);
        private object[] createHeroArgs26 = { new List<string>() { "Assassin", "Gosho" } };

        private ArenaController arenaController26 = new ArenaController();
        private string expectedOutput26 =
           $"Heroes: 1" + Environment.NewLine +
            "Assassin: Gosho - Level: 0" + Environment.NewLine +
            "Experience: 0" + Environment.NewLine +
            "Power: 0.00";


        [TestMethod]
        public void TestCloseArenaWithOneHero()
        {
            var createHero = sut26.GetMethod("CreateHero");
            var closeArena = sut26.GetMethod("CloseArena");

            createHero.Invoke(arenaController26, createHeroArgs26);

            string checkMessage = (string)closeArena.Invoke(arenaController26, new object[] { });

            Assert.AreEqual(expectedOutput26, checkMessage);
        }

        //T02.cs
        private Type sut27 = typeof(ArenaController);
        private object[] createHeroArgs27 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createWeaponArgs27 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private ArenaController arenaController27 = new ArenaController();
        private string expectedOutput27 =
           $"Heroes: 1" + Environment.NewLine +
            "Assassin: Gosho - Level: 0" + Environment.NewLine +
            "Experience: 0" + Environment.NewLine +
            "Sword: WrathOfTheTitans" + Environment.NewLine +
            "  *Strength: 20" + Environment.NewLine +
            "  *Agility: 5" + Environment.NewLine +
            "  *Intelligence: 5" + Environment.NewLine +
            "Power: 60.00";


        [TestMethod]
        public void TestCloseArenaWithOneHeroWithWeapon()
        {
            var createHero = sut27.GetMethod("CreateHero");
            var createWeapon = sut27.GetMethod("CreateWeapon");
            var closeArena = sut27.GetMethod("CloseArena");

            createHero.Invoke(arenaController27, createHeroArgs27);
            createWeapon.Invoke(arenaController27, createWeaponArgs27);

            string checkMessage = (string)closeArena.Invoke(arenaController27, new object[] { });

            Assert.AreEqual(expectedOutput27, checkMessage);
        }

        //T03.cs
        private Type sut28 = typeof(ArenaController);
        private object[] createFirsHeroArgs28 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createSecondHeroArgs28 = { new List<string>() { "Assassin", "Pesho" } };

        private ArenaController arenaController28 = new ArenaController();
        private string expectedOutput28 =
           $"Heroes: 2" + Environment.NewLine +
            "Assassin: Gosho - Level: 0" + Environment.NewLine +
            "Experience: 0" + Environment.NewLine +
            "Power: 0.00" + Environment.NewLine +
            "Assassin: Pesho - Level: 0" + Environment.NewLine +
            "Experience: 0" + Environment.NewLine +
            "Power: 0.00";


        [TestMethod]
        public void TestCloseArenaWithTwoHeroesOrderedByName()
        {
            var createHero = sut28.GetMethod("CreateHero");
            var closeArena = sut28.GetMethod("CloseArena");

            createHero.Invoke(arenaController28, createFirsHeroArgs28);
            createHero.Invoke(arenaController28, createSecondHeroArgs28);

            string checkMessage = (string)closeArena.Invoke(arenaController28, new object[] { });

            Assert.AreEqual(expectedOutput28, checkMessage);
        }

        //T04.cs
        private Type sut29 = typeof(ArenaController);
        private object[] createFirsHeroArgs29 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createSecondHeroArgs29 = { new List<string>() { "Assassin", "Pesho" } };

        private object[] createWeaponArgs29 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private ArenaController arenaController29 = new ArenaController();
        private string expectedOutput29 =
           $"Heroes: 2" + Environment.NewLine +
            "Assassin: Gosho - Level: 0" + Environment.NewLine +
            "Experience: 0" + Environment.NewLine +
            "Sword: WrathOfTheTitans" + Environment.NewLine +
            "  *Strength: 20" + Environment.NewLine +
            "  *Agility: 5" + Environment.NewLine +
            "  *Intelligence: 5" + Environment.NewLine +
            "Power: 60.00" + Environment.NewLine +
            "Assassin: Pesho - Level: 0" + Environment.NewLine +
            "Experience: 0" + Environment.NewLine +
            "Power: 0.00";


        [TestMethod]
        public void TestCloseArenaWithTwoHeroesOrderedByPower()
        {
            var createHero = sut29.GetMethod("CreateHero");
            var createWeapon = sut29.GetMethod("CreateWeapon");
            var closeArena = sut29.GetMethod("CloseArena");

            createHero.Invoke(arenaController29, createSecondHeroArgs29);
            createHero.Invoke(arenaController29, createFirsHeroArgs29);

            createWeapon.Invoke(arenaController29, createWeaponArgs29);

            string checkMessage = (string)closeArena.Invoke(arenaController29, new object[] { });

            Assert.AreEqual(expectedOutput29, checkMessage);
        }

        //T05.cs
        private Type sut30 = typeof(ArenaController);
        private object[] createFirsHeroArgs30 = { new List<string>() { "Assassin", "Gosho" } };
        private object[] createSecondHeroArgs30 = { new List<string>() { "Assassin", "Pesho" } };

        private object[] createWeaponArgs30 = { new List<string>() { "Gosho", "Sword", "WrathOfTheTitans", "5", "5", "5", } };

        private object[] fightArgs30 = { new List<string>() { "Gosho", "Pesho" } };

        private ArenaController arenaController30 = new ArenaController();
        private string expectedOutput30 =
           $"Heroes: 2" + Environment.NewLine +
            "Assassin: Gosho - Level: 1" + Environment.NewLine +
            "Experience: 20" + Environment.NewLine +
            "Sword: WrathOfTheTitans" + Environment.NewLine +
            "  *Strength: 20" + Environment.NewLine +
            "  *Agility: 5" + Environment.NewLine +
            "  *Intelligence: 5" + Environment.NewLine +
            "Power: 60.00" + Environment.NewLine +
            "Assassin: Pesho - Level: 0" + Environment.NewLine +
            "Experience: 0" + Environment.NewLine +
            "Power: 0.00";

        [TestMethod]
        public void TestCloseArenaWithTwoHeroesOrderedByLevel()
        {
            var createHero = sut30.GetMethod("CreateHero");
            var createWeapon = sut30.GetMethod("CreateWeapon");
            var fight = sut30.GetMethod("Fight");
            var closeArena = sut30.GetMethod("CloseArena");

            createHero.Invoke(arenaController30, createSecondHeroArgs30);
            createHero.Invoke(arenaController30, createFirsHeroArgs30);

            createWeapon.Invoke(arenaController30, createWeaponArgs30);

            for (int i = 0; i < 4; i++)
            {
                fight.Invoke(arenaController30, fightArgs30);
            }

            string checkMessage = (string)closeArena.Invoke(arenaController30, new object[] { });

            Assert.AreEqual(expectedOutput30, checkMessage);
        }


    }
}
