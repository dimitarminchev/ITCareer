using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StorageMaster;

namespace UnitTests
{
    [TestClass]
    public class EngineTests
    {
        /// <summary>
        /// ConsoleReader
        /// </summary>
        public class ConsoleReader : IReader
        {
            private StreamReader stream;

            public ConsoleReader(string filename)
            {
                stream = new StreamReader(filename);
            }

            public string ReadLine()
            {
                return stream.ReadLine();
            }
        }

        /// <summary>
        /// ConsoleWriter
        /// </summary>
        public class ConsoleWriter : IWriter
        {
            private StringBuilder stream;

            public ConsoleWriter()
            {
                stream = new StringBuilder();
            }

            public void WriteLine(string message)
            {
                stream.AppendLine(message);
            }

            public override string ToString()
            {
                return stream.ToString();
            }
        }

        [TestMethod]
        public void TestMethod01()
        {
            // Arrange
            var input = new ConsoleReader("Tests\\01.in");
            var output = new ConsoleWriter();
            var result = (new StreamReader("Tests\\01.out")).ReadToEnd().ToString().Trim();

            // Act
            var engine = new Engine(input, output);
            engine.Run();

            // Assert
            Assert.AreEqual(result, output.ToString().Trim());
        }

        [TestMethod]
        public void TestMethod02()
        {
            // Arrange
            var input = new ConsoleReader("Tests\\02.in");
            var output = new ConsoleWriter();
            var result = (new StreamReader("Tests\\02.out")).ReadToEnd().ToString().Trim();

            // Act
            var engine = new Engine(input, output);
            engine.Run();

            // Assert
            Assert.AreEqual(result, output.ToString().Trim());
        }

        [TestMethod]
        public void TestMethod03()
        {
            // Arrange
            var input = new ConsoleReader("Tests\\03.in");
            var output = new ConsoleWriter();
            var result = (new StreamReader("Tests\\03.out")).ReadToEnd().ToString().Trim();

            // Act
            var engine = new Engine(input, output);
            engine.Run();

            // Assert
            Assert.AreEqual(result, output.ToString().Trim());
        }

        [TestMethod]
        public void TestMethod04()
        {
            // Arrange
            var input = new ConsoleReader("Tests\\04.in");
            var output = new ConsoleWriter();
            var result = (new StreamReader("Tests\\04.out")).ReadToEnd().ToString().Trim();

            // Act
            var engine = new Engine(input, output);
            engine.Run();

            // Assert
            Assert.AreEqual(result, output.ToString().Trim());
        }

        [TestMethod]
        public void TestMethod05()
        {
            // Arrange
            var input = new ConsoleReader("Tests\\05.in");
            var output = new ConsoleWriter();
            var result = (new StreamReader("Tests\\05.out")).ReadToEnd().ToString().Trim();

            // Act
            var engine = new Engine(input, output);
            engine.Run();

            // Assert
            Assert.AreEqual(result, output.ToString().Trim());
        }

        [TestMethod]
        public void TestMethod06()
        {
            // Arrange
            var input = new ConsoleReader("Tests\\06.in");
            var output = new ConsoleWriter();
            var result = (new StreamReader("Tests\\06.out")).ReadToEnd().ToString().Trim();

            // Act
            var engine = new Engine(input, output);
            engine.Run();

            // Assert
            Assert.AreEqual(result, output.ToString().Trim());
        }

        [TestMethod]
        public void TestMethod07()
        {
            // Arrange
            var input = new ConsoleReader("Tests\\07.in");
            var output = new ConsoleWriter();
            var result = (new StreamReader("Tests\\07.out")).ReadToEnd().ToString().Trim();

            // Act
            var engine = new Engine(input, output);
            engine.Run();

            // Assert
            Assert.AreEqual(result, output.ToString().Trim());
        }

        [TestMethod]
        public void TestMethod08()
        {
            // Arrange
            var input = new ConsoleReader("Tests\\08.in");
            var output = new ConsoleWriter();
            var result = (new StreamReader("Tests\\08.out")).ReadToEnd().ToString().Trim();

            // Act
            var engine = new Engine(input, output);
            engine.Run();

            // Assert
            Assert.AreEqual(result, output.ToString().Trim());
        }

        [TestMethod]
        public void TestMethod09()
        {
            // Arrange
            var input = new ConsoleReader("Tests\\09.in");
            var output = new ConsoleWriter();
            var result = (new StreamReader("Tests\\09.out")).ReadToEnd().ToString().Trim();

            // Act
            var engine = new Engine(input, output);
            engine.Run();

            // Assert
            Assert.AreEqual(result, output.ToString().Trim());
        }

        [TestMethod]
        public void TestMethod10()
        {
            // Arrange
            var input = new ConsoleReader("Tests\\10.in");
            var output = new ConsoleWriter();
            var result = (new StreamReader("Tests\\10.out")).ReadToEnd().ToString().Trim();

            // Act
            var engine = new Engine(input, output);
            engine.Run();

            // Assert
            Assert.AreEqual(result, output.ToString().Trim());
        }
    }
}
