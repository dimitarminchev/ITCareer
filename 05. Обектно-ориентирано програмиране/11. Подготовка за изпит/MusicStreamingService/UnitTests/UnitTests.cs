using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System;

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
                        case "AddUser":
                            result.AppendLine(controller.AddUser(arguments));
                            break;
                        case "AddPlaylist":
                            result.AppendLine(controller.AddPlaylist(arguments));
                            break;
                        case "AddSongToPlaylist":
                            result.AppendLine(controller.AddSongToPlaylist(arguments));
                            break;
                        case "GetTotalDurationOfPlaylist":
                            result.AppendLine(controller.GetTotalDurationOfPlaylist(arguments)); ;
                            break;
                        case "GetSongsByArtistFromPlaylist":
                            result.AppendLine(controller.GetSongsByArtistFromPlaylist(arguments));
                            break;
                        case "GetSongsByGenreFromPlaylist":
                            result.AppendLine(controller.GetSongsByGenreFromPlaylist(arguments));
                            break;
                        case "GetSongsAboveDurationFromPlaylist":
                            result.AppendLine(controller.GetSongsAboveDurationFromPlaylist(arguments));
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
    }
}
