using System;
using System.Numerics;

class InstructionSet_Fixed
{
    static void Main()
    {
        string opCode = Console.ReadLine();

        while (opCode/*.ToLower()*/ != "END")
        {
            string[] codeArgs = opCode.Split(' ');
            BigInteger result = 0;
            switch (codeArgs[0]/*.ToLower()*/)
            {
                case "INC":
                {
                    long operandOne = long.Parse(codeArgs[1]);
                    result = ++operandOne;
                    break;
                }
                case "DEC":
                {
                    long operandOne = long.Parse(codeArgs[1]);
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
                    result = operandOne * operandTwo;
                    break;
                }
            }
            Console.WriteLine(result);
            opCode = Console.ReadLine();
        }
    }
}