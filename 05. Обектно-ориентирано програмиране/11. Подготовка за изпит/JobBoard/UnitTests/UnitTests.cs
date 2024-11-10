using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace UnitTests
{
    public class EngineTest
    {
        private Controller controller;
        private StringBuilder result;

        public EngineTest(Controller controller)
        {
            this.controller = controller;
            result = new StringBuilder();
        }

        public string ExecuteTest(string input)
        {
            string[] lines = input.ToString().Split(Environment.NewLine, StringSplitOptions.None);
            foreach (var line in lines)
            {
                string[] splittedLine = line.Split();
                string command = splittedLine[0];
                List<string> arguments = splittedLine.Skip(1).ToList();
                try
                {
                    switch (command)
                    {
                        case "AddCategory":
                            result.AppendLine(controller.AddCategory(arguments));
                            break;
                        case "AddJobOffer":
                            result.AppendLine(controller.AddJobOffer(arguments));
                            break;
                        case "GetAverageSalary":
                            result.AppendLine(controller.GetAverageSalary(arguments));
                            break;
                        case "GetOffersAboveSalary":
                            result.AppendLine(controller.GetOffersAboveSalary(arguments));;
                            break;
                        case "GetOffersWithoutSalary":
                            result.AppendLine(controller.GetOffersWithoutSalary(arguments));
                            break;
                        case "End":
                            break;
                        default:
                            result.AppendLine("Invalid command");
                            break;
                    }
                }
                catch (Exception e)
                {
                    result.AppendLine(e.Message);
                }
            }
            return result.ToString().Trim();
        }
    }

    [TestClass]
    public class UnitTests
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
            Controller controller = new Controller();
            EngineTest engine = new EngineTest(controller);
            var messageText = engine.ExecuteTest(inputText);

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
            Controller controller = new Controller();
            EngineTest engine = new EngineTest(controller);
            var messageText = engine.ExecuteTest(inputText);

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
            Controller controller = new Controller();
            EngineTest engine = new EngineTest(controller);
            var messageText = engine.ExecuteTest(inputText);

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
            Controller controller = new Controller();
            EngineTest engine = new EngineTest(controller);
            var messageText = engine.ExecuteTest(inputText);

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
            Controller controller = new Controller();
            EngineTest engine = new EngineTest(controller);
            var messageText = engine.ExecuteTest(inputText);

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
            Controller controller = new Controller();
            EngineTest engine = new EngineTest(controller);
            var messageText = engine.ExecuteTest(inputText);

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
            Controller controller = new Controller();
            EngineTest engine = new EngineTest(controller);
            var messageText = engine.ExecuteTest(inputText);

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
            Controller controller = new Controller();
            EngineTest engine = new EngineTest(controller);
            var messageText = engine.ExecuteTest(inputText);

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
            Controller controller = new Controller();
            EngineTest engine = new EngineTest(controller);
            var messageText = engine.ExecuteTest(inputText);

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
            Controller controller = new Controller();
            EngineTest engine = new EngineTest(controller);
            var messageText = engine.ExecuteTest(inputText);

            // Test
            Assert.AreEqual(outputText, messageText);
        }
    }
}
