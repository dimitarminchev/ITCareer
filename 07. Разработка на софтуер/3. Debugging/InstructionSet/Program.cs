namespace InstructionSet
{
    public class Program
    {
        static void Main()
        {
            string opCode = Console.ReadLine();

            while (opCode != "END") 
            {
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (long)(operandOne * operandTwo);
                            break;
                        }
                }

                Console.WriteLine(result);

                opCode = Console.ReadLine();
            }
        }
    }
}