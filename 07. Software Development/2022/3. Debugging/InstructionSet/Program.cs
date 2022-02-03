namespace InstructionSet
{
    internal class Program
    {
        static void Main()
        {

            string opCode = System.Console.ReadLine();

            // fix: end => END
            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            // fix: increment
                            int operandOne = int.Parse(codeArgs[1]) + 1;
                            result = operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            // fix: decrement
                            int operandOne = int.Parse(codeArgs[1]) - 1;
                            result = operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            // fix: int -> long
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (long)(operandOne * operandTwo);
                            break;
                        }
                }

                Console.WriteLine(result);

                // fix: Read next opCode
                opCode = System.Console.ReadLine();
            }
        }
    }
}