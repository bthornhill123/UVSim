using System;
using System.Collections.Generic;
using System.Text;

namespace UVSimConsoleUI.OldStuff
{
    class JarensOldCodeThatsDecent
    {
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        UI.DisplayInstructors();
        //        UI.GetInput();
        //        UVSim.RunProgram();
        //        UVSim.MemDump();
        //        Console.Read();
        //    }
        //}

        //public static class UI
        //{
        //    public static void DisplayInstructors()
        //    {
        //        Console.WriteLine("Welcome to JCB's UV Simulator!\nPlease enter instructions one data word at a time.\nData words are positve or negative 4 digit strings." +
        //        "\nWhen you are finished, enter -99999 to stop and run program.\n");
        //    }

        //    public static void GetInput()
        //    {

        //        while (true)
        //        {
        //            Console.Write("{0:D2} ? ", UVSim.count);

        //            string user_input = Console.ReadLine();
        //            if (user_input == "-99999")
        //                break;

        //            if (user_input.Length == 5)
        //            {
        //                if (user_input[0] == '+' || user_input[0] == '-')
        //                {
        //                    //slice string to remove sign in front
        //                    UVSim.memory[UVSim.count] = (user_input.Substring(1, 4));
        //                    UVSim.count += 1;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Invalid Instruction: Missing (+) or (-) Sign");
        //                }

        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid Input");
        //            }


        //        }
        //    }


        //}
        //public static class UVSim
        //{

        //    const int MEM_SIZE = 100;

        //    public static string[] memory = new string[MEM_SIZE];
        //    public static int accumilator, pc = 0, operand = 0, opcode = 0, count = 0;

        //    //I/O Operations
        //    public static void Read(int op)
        //    {
        //        Console.Write("Enter an Integer: ");
        //        string input = Console.ReadLine();
        //        memory[op] = input;

        //    }
        //    public static void Write(int op)
        //    {
        //        Console.WriteLine("Contents of location {0}: {1}", op, memory[op]);
        //    }

        //    //Load/Store Operations
        //    public static void Load(int op)
        //    {
        //        accumilator = int.Parse(memory[op]);
        //    }

        //    public static void Store(int op)
        //    {
        //        memory[op] = accumilator.ToString();
        //    }

        //    //ALU
        //    public static void Add(int op) { accumilator += int.Parse(memory[op]); }
        //    public static void Subtract(int op) { accumilator -= int.Parse(memory[op]); }
        //    public static void Divide(int op) { accumilator /= int.Parse(memory[op]); }
        //    public static void Multiply(int op) { accumilator *= int.Parse(memory[op]); }

        //    //Control Operations
        //    //using op -1 because after the command runs the pc will be incremented by 1
        //    public static void Branch(int op) { pc = op - 1; }
        //    public static void BranchNeg(int op) { if (accumilator < 0) { pc = op - 1; } }
        //    public static void BranchZero(int op) { if (accumilator == 0) { pc = op - 1; } }
        //    public static void Halt() { pc = 101; }

        //    //Debugging Operations
        //    public static void MemDump()
        //    {
        //        Console.WriteLine("\nAccumilator: {0:d2}\nOpcode: {1:d2}\nOperand: {2:d2}\n\nMemory Dump: ", accumilator, opcode, operand);
        //        for (int i = 0; i < MEM_SIZE; i++)
        //        {
        //            Console.WriteLine("{0:d2}: {1}", i, memory[i]);
        //        }
        //    }

        //    public static void RunProgram()
        //    {
        //        Console.WriteLine("*** Running Program ***");
        //        //run code in memory 
        //        while (pc < MEM_SIZE)
        //        {
        //            if (memory[pc] != null)
        //            {
        //                opcode = int.Parse(memory[pc].Substring(0, 2));
        //                operand = int.Parse(memory[pc].Substring(2));

        //                switch (opcode)
        //                {
        //                    case 10:
        //                        Read(operand);
        //                        break;
        //                    case 11:
        //                        Write(operand);
        //                        break;
        //                    case 20:
        //                        Load(operand);
        //                        break;
        //                    case 21:
        //                        Store(operand);
        //                        break;
        //                    case 30:
        //                        Add(operand);
        //                        break;
        //                    case 31:
        //                        Subtract(operand);
        //                        break;
        //                    case 32:
        //                        Divide(operand);
        //                        break;
        //                    case 33:
        //                        Multiply(operand);
        //                        break;
        //                    case 40:
        //                        Branch(operand);
        //                        break;
        //                    case 41:
        //                        BranchNeg(operand);
        //                        break;
        //                    case 42:
        //                        BranchZero(operand);
        //                        break;
        //                    case 43:
        //                        Halt();
        //                        break;
        //                }
        //            }

        //            //increment program counter
        //            pc += 1;


        //        }
        //    }
        }
    }
}
