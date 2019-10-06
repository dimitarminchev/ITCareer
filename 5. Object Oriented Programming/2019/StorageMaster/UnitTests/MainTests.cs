using System;
using System.Text;


namespace UnitTests
{
    /// <summary>
    /// Description of MainTests.
    /// </summary>
    public class MainTests
    {
        public MainTests()
        {
        }
        public static void Main(String[] args)
        {
            var tests = new BusinessLogicTests();
            int grade = 0;
            int points = 3;
            try
            {
                tests.ValidateControllerExists();
                Console.WriteLine(FormatOutput("Test ValidateControllerExists", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test ValidateControllerExists", points.ToString(), e));
            }

            try
            {
                tests.ValidateDungeonMasterMethodsExist();
                Console.WriteLine(FormatOutput("Test ValidateDungeonMasterMethodsExist", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test ValidateDungeonMasterMethodsExist", points.ToString(), e));
            }

            try
            {
                tests.CreateValidProduct();
                Console.WriteLine(FormatOutput("Test CreateValidProduct", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test CreateValidProduct", points.ToString(), e));
            }

            try
            {
                tests.CreateInvalidProduct();
                Console.WriteLine(FormatOutput("Test CreateInvalidProduct", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test CreateInvalidProduct", points.ToString(), e));
            }

            try
            {
                tests.CreateValidStorage();
                Console.WriteLine(FormatOutput("Test CreateValidStorage", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test CreateValidStorage", points.ToString(), e));
            }

            try
            {
                tests.CreateInvalidStorage1();
                Console.WriteLine(FormatOutput("Test CreateInvalidStorage1", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test CreateInvalidStorage1", points.ToString(), e));
            }

            try
            {
                tests.CreateInvalidStorage2();
                Console.WriteLine(FormatOutput("Test CreateInvalidStorage2", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test CreateInvalidStorage2", points.ToString(), e));
            }

            try
            {
                tests.TestGetVehicle1();
                Console.WriteLine(FormatOutput("Test TestGetVehicle1", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test TestGetVehicle1", points.ToString(), e));
            }

            try
            {
                tests.TestGetVehicle2();
                Console.WriteLine(FormatOutput("Test TestGetVehicle2", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test TestGetVehicle2", points.ToString(), e));
            }

            try
            {
                tests.TestGetVehicle3();
                Console.WriteLine(FormatOutput("Test TestGetVehicle3", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test TestGetVehicle3", points.ToString(), e));
            }

            try
            {
                tests.SendVehicleTo1();
                Console.WriteLine(FormatOutput("Test SendVehicleTo1", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test SendVehicleTo1", points.ToString(), e));
            }

            try
            {
                tests.SendVehicleTo2();
                Console.WriteLine(FormatOutput("Test SendVehicleTo2", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test SendVehicleTo2", points.ToString(), e));
            }

            try
            {
                tests.UnloadVehicle1();
                Console.WriteLine(FormatOutput("Test UnloadVehicle1", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test UnloadVehicle1", points.ToString(), e));
            }

            try
            {
                tests.UnloadVehicle2();
                Console.WriteLine(FormatOutput("Test UnloadVehicle2", points.ToString(), null));
                grade += points;
            }
            catch (Exception e)
            {
                Console.WriteLine(FormatOutput("Test UnloadVehicle2", points.ToString(), e));
            }
            Console.WriteLine(String.Format("Grade :=>> {0} marks\n", grade.ToString()));

        }

        private static String FormatOutput(String testName, String value, Exception e)
        {
            var sb = new StringBuilder();
            String grade = (e == null ? value : "0");
            sb.Append(String.Format("Comment :=>> {0}: {1}. {2} marks\n", testName, (e == null ? "Success" : "Failure"), grade));
            if (e != null)
            {
                sb.Append(String.Format("<|-- \n{0}\n --|>\n", e.Message));
            }
            return sb.ToString();
        }
    }
}