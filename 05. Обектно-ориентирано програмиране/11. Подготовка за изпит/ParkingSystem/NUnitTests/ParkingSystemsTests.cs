using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace NUnitTests
{
    public class ParkingSystemsTests
    {
        private string TestParkingController(List<string> input, string output)
        {
            StringBuilder answer = new StringBuilder();

            ParkingController controller = new ParkingController();

            foreach (var line in input)
            {
                switch (line.Split(":").Take(1).First())
                {
                    case "CreateParkingSpot":
                        answer.AppendLine(controller.CreateParkingSpot(line.Split(":").Skip(1).ToList()));
                        break;
                    case "ParkVehicle":
                        answer.AppendLine(controller.ParkVehicle(line.Split(":").Skip(1).ToList()));
                        break;
                    case "FreeParkingSpot":
                        answer.AppendLine(controller.FreeParkingSpot(line.Split(":").Skip(1).ToList()));
                        break;
                    case "GetParkingSpotById":
                        answer.AppendLine(controller.GetParkingSpotById(line.Split(":").Skip(1).ToList()));
                        break;
                    case "GetParkingIntervalsByParkingSpotIdAndRegistrationPlate":
                        answer.AppendLine(controller.GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(line.Split(":").Skip(1).ToList()));
                        break;
                    case "CalculateTotal":
                        answer.AppendLine(controller.CalculateTotal(line.Split(":").Skip(1).ToList()));
                        break;
                    default:
                        // Assert.Fail("Not implemented");
                        break;
                }
            }

            return answer.ToString().TrimEnd();
        }

        [Test]
        public void Test01()
        {
            List<string> input = File.ReadAllText("test.01.in").Split().ToList();

            string output = File.ReadAllText("test.01.out");

            string answer = TestParkingController(input, output);

            Assert.IsTrue(output == answer.ToString());
        }

        [Test]
        public void Test02()
        {
            List<string> input = File.ReadAllText("test.02.in").Split().ToList();

            string output = File.ReadAllText("test.02.out");

            string answer = TestParkingController(input, output);

            Assert.IsTrue(output == answer.ToString());
        }

        [Test]
        public void Test03()
        {
            List<string> input = File.ReadAllText("test.03.in").Split().ToList();

            string output = File.ReadAllText("test.03.out");

            string answer = TestParkingController(input, output);

            Assert.IsTrue(output == answer.ToString()); 
        }

        [Test]
        public void Test04()
        {
            List<string> input = File.ReadAllText("test.04.in").Split().ToList();

            string output = File.ReadAllText("test.04.out");

            string answer = TestParkingController(input, output);

            Assert.IsTrue(output == answer.ToString());
        }

        [Test]
        public void Test05()
        {
            List<string> input = File.ReadAllText("test.05.in").Split().ToList();

            string output = File.ReadAllText("test.05.out");

            string answer = TestParkingController(input, output);

            Assert.IsTrue(output == answer.ToString());
        }

        [Test]
        public void Test06()
        {
            List<string> input = File.ReadAllText("test.06.in").Split().ToList();

            string output = File.ReadAllText("test.06.out");

            string answer = TestParkingController(input, output);

            Assert.IsTrue(output == answer.ToString());
        }

        [Test]
        public void Test07()
        {
            List<string> input = File.ReadAllText("test.07.in").Split().ToList();

            string output = File.ReadAllText("test.07.out");

            string answer = TestParkingController(input, output);

            Assert.IsTrue(output == answer.ToString());
        }

        [Test]
        public void Test08()
        {
            List<string> input = File.ReadAllText("test.08.in").Split().ToList();

            string output = File.ReadAllText("test.08.out");

            string answer = TestParkingController(input, output);

            Assert.IsTrue(output == answer.ToString());
        }

        [Test]
        public void Test09()
        {
            List<string> input = File.ReadAllText("test.09.in").Split().ToList();

            string output = File.ReadAllText("test.09.out");

            string answer = TestParkingController(input, output);

            Assert.IsTrue(output == answer.ToString());
        }

        [Test]
        public void Test10()
        {
            List<string> input = File.ReadAllText("test.10.in").Split().ToList();

            string output = File.ReadAllText("test.10.out");

            string answer = TestParkingController(input, output);

            Assert.IsTrue(output == answer.ToString());
        }
    }
}