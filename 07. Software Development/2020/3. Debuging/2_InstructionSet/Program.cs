using System;

/// <summary>
/// 3. Debuging, 2. Instruction Set
/// </summary>
namespace _2_InstructionSet
{
    /// <summary>
    /// Main Program Class: 3. Debuging, 2. Instruction Set
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Input: 
        /// ADD 1323134 421315521
        /// END
        /// Output:
        /// 422638655
        /// </summary>
        public static void Main()
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
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = int.Parse(codeArgs[1]);
                            long operandTwo = int.Parse(codeArgs[2]);
                            result = (long)(operandOne * operandTwo);
                            break;
                        }
                }
                opCode = Console.ReadLine();
                Console.WriteLine(result);
            }
        }
    }
}
