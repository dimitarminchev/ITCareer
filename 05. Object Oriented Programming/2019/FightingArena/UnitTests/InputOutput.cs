using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{   
    using HeroFight.Core;
    using HeroFight.Core.Contracts;
    using HeroFight.Entities.Heroes;
    using HeroFight.Entities.Weapons;
    using System.IO;

    // Engine Test
    public class EngineTest 
    {
        private ArenaController arenaController;
        private StringBuilder resultString;

        public EngineTest(ArenaController arenaController)
        {
            this.arenaController = arenaController;
            this.resultString = new StringBuilder();
        }

        public string Test(string input)
        {
            string[] newline = { Environment.NewLine }; 
            var lines = input.ToString().Split(newline, StringSplitOptions.None);
            foreach (var line in lines)
            {
                List<string> commandArgs = line.Split(':').Select(p => p.Trim()).ToList();
                string command = commandArgs[0];
                commandArgs.RemoveAt(0);
                string result = "";
                try
                {
                    if (command == "CreateHero")
                    {
                        result = arenaController.CreateHero(commandArgs);
                    }
                    else if (command == "CreateWeapon")
                    {
                        result = arenaController.CreateWeapon(commandArgs);
                    }
                    else if (command == "Fight")
                    {
                        result = arenaController.Fight(commandArgs);
                    }
                    else if (command == "HeroInfo")
                    {
                        result = arenaController.HeroInfo(commandArgs);
                    }
                    else if (command == "CloseArena")
                    {
                        result = arenaController.CloseArena();
                    }
                }
                catch (ArgumentException ex)
                {
                    result = ex.Message;
                }

                resultString.AppendLine(result);
            }

            return resultString.ToString().Trim();
        }
    }


    [TestClass]
    public class InputOutput
    {
        [TestMethod]
        public void TestMethod01()
        {
            // Input
            var inputReader = new StreamReader("tests/01.in");
            var inputText = inputReader.ReadToEnd();

            // Output
            var outputReader = new StreamReader("tests/01.out");
            var outputText = outputReader.ReadToEnd();

            // Execute
            ArenaController arenaController = new ArenaController();
            EngineTest engine = new EngineTest(arenaController);
            var messageText = engine.Test(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }

        [TestMethod]
        public void TestMethod02()
        {
            // Input
            var inputReader = new StreamReader("tests/02.in");
            var inputText = inputReader.ReadToEnd();

            // Output
            var outputReader = new StreamReader("tests/02.out");
            var outputText = outputReader.ReadToEnd();

            // Execute
            ArenaController arenaController = new ArenaController();
            EngineTest engine = new EngineTest(arenaController);
            var messageText = engine.Test(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }

        [TestMethod]
        public void TestMethod03()
        {
            // Input
            var inputReader = new StreamReader("tests/03.in");
            var inputText = inputReader.ReadToEnd();

            // Output
            var outputReader = new StreamReader("tests/03.out");
            var outputText = outputReader.ReadToEnd();

            // Execute
            ArenaController arenaController = new ArenaController();
            EngineTest engine = new EngineTest(arenaController);
            var messageText = engine.Test(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }

        [TestMethod]
        public void TestMethod04()
        {
            // Input
            var inputReader = new StreamReader("tests/04.in");
            var inputText = inputReader.ReadToEnd();

            // Output
            var outputReader = new StreamReader("tests/04.out");
            var outputText = outputReader.ReadToEnd();

            // Execute
            ArenaController arenaController = new ArenaController();
            EngineTest engine = new EngineTest(arenaController);
            var messageText = engine.Test(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }

        [TestMethod]
        public void TestMethod05()
        {
            // Input
            var inputReader = new StreamReader("tests/05.in");
            var inputText = inputReader.ReadToEnd();

            // Output
            var outputReader = new StreamReader("tests/05.out");
            var outputText = outputReader.ReadToEnd();

            // Execute
            ArenaController arenaController = new ArenaController();
            EngineTest engine = new EngineTest(arenaController);
            var messageText = engine.Test(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }

        [TestMethod]
        public void TestMethod06()
        {
            // Input
            var inputReader = new StreamReader("tests/06.in");
            var inputText = inputReader.ReadToEnd();

            // Output
            var outputReader = new StreamReader("tests/06.out");
            var outputText = outputReader.ReadToEnd();

            // Execute
            ArenaController arenaController = new ArenaController();
            EngineTest engine = new EngineTest(arenaController);
            var messageText = engine.Test(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }

        [TestMethod]
        public void TestMethod07()
        {
            // Input
            var inputReader = new StreamReader("tests/07.in");
            var inputText = inputReader.ReadToEnd();

            // Output
            var outputReader = new StreamReader("tests/07.out");
            var outputText = outputReader.ReadToEnd();

            // Execute
            ArenaController arenaController = new ArenaController();
            EngineTest engine = new EngineTest(arenaController);
            var messageText = engine.Test(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }

        [TestMethod]
        public void TestMethod08()
        {
            // Input
            var inputReader = new StreamReader("tests/08.in");
            var inputText = inputReader.ReadToEnd();

            // Output
            var outputReader = new StreamReader("tests/08.out");
            var outputText = outputReader.ReadToEnd();

            // Execute
            ArenaController arenaController = new ArenaController();
            EngineTest engine = new EngineTest(arenaController);
            var messageText = engine.Test(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }

        [TestMethod]
        public void TestMethod09()
        {
            // Input
            var inputReader = new StreamReader("tests/09.in");
            var inputText = inputReader.ReadToEnd();

            // Output
            var outputReader = new StreamReader("tests/09.out");
            var outputText = outputReader.ReadToEnd();

            // Execute
            ArenaController arenaController = new ArenaController();
            EngineTest engine = new EngineTest(arenaController);
            var messageText = engine.Test(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }

        [TestMethod]
        public void TestMethod10()
        {
            // Input
            var inputReader = new StreamReader("tests/10.in");
            var inputText = inputReader.ReadToEnd();

            // Output
            var outputReader = new StreamReader("tests/10.out");
            var outputText = outputReader.ReadToEnd();

            // Execute
            ArenaController arenaController = new ArenaController();
            EngineTest engine = new EngineTest(arenaController);
            var messageText = engine.Test(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }
    }
}
