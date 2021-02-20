namespace _02_InstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {
/* Input:
INC 0
ADD 1323134 421315521
DEC 57314183
MLA 252621 324532
END
*/
            string opCode = System.Console.ReadLine();
            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]); // fix: int => long
                            result = operandOne + 1; // fix: operandOne++ => operandOne + 1
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]); // fix: int => long
                            result = operandOne - 1; // fix: operandOne-- -> operandOne - 1
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]); // fix: int => long
                            long operandTwo = long.Parse(codeArgs[2]); // fix: int => long
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]); // fix: int => long
                            long operandTwo = long.Parse(codeArgs[2]); // fix: int => long
                            result = (long)(operandOne * operandTwo);
                            break;
                        }
                }

                Console.WriteLine(result);
                opCode = System.Console.ReadLine(); // fix: mising readline
            }
        }
    }
}
