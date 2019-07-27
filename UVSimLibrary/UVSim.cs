using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using UVSimLibrary.Models;

namespace UVSimLibrary
{
    public class UVSim
    {
        private List<InputCommandModel> memory = new List<InputCommandModel>();
        private int programCounter = 0;
        private readonly int MEM_SIZE;

        public UVSim(int memorySize = 100)
        {
            MEM_SIZE = memorySize;
        }

        public void FetchUserManual()
        {
            string output = "";

            output += "Welcome to JCB's UV Simulator!\n";
            output += "Please enter instructions one data-word at a time.\n";
            output += "Data words are positve or negative 4 digit strings.\n";
            output += "When you are finished, enter -99999 to stop and run program.\n";
            output += "Please enter commands:\n";

            MessageBox.Show(output);
        }

        public void AcceptUserProgram()
        {

            int memoryLocation = 0;
            string response;

            do // User is still entering commands
            {
                //Keep accepting commands
                Console.Write(memoryLocation + " ? ");
                response = Console.ReadLine();

                string operation = response.Substring(0, 2);
                string operand = response.Substring(2, 2);

                memory.Add(new InputCommandModel { MemoryLocation = memoryLocation++, Operation = operation, Operand = operand });
            } while (response != "9999");



            foreach (var word in memory)
            {
                RunCommand(word.Operation, word.Operand);
                programCounter++;
            }
        }

        private void RunCommand(string operation, string operand)
        {
            //switch (operation)
            //{
            //    case "10":
            //        Read(operand);
            //        break;
            //    case "11":
            //        Write(operand);
            //        break;
            //    case "20":
            //        Load(operand);
            //        break;
            //    case "21":
            //        Store(operand);
            //        break;
            //    case "30":
            //        Add(operand);
            //        break;
            //    case "31":
            //        Subtract(operand);
            //        break;
            //    case "32":
            //        Divide(operand);
            //        break;
            //    case "33":
            //        Multiply(operand);
            //        break;
            //    case "40":
            //        Branch(operand);
            //        break;
            //    case "41":
            //        BranchNeg(operand);
            //        break;
            //    case "42":
            //        BranchZero(operand);
            //        break;
            //    case "43":
            //        Halt();
            //        break;
            //}
        }

        public void DisplayRegisterStats()
        {
            
        }

        public void DisplayMemory()
        {
            
        }


        //I/O Operations
        private static void Read(int op)
        {
            Console.Write("Enter an Integer: ");
            string input = Console.ReadLine();
            memory[op] = input;

        }
        private static void Write(int op)
        {
            Console.WriteLine("Contents of location {0}: {1}", op, memory[op]);
        }

        //Load/Store Operations
        private static void Load(int op)
        {
            accumilator = int.Parse(memory[op]);
        }
        private static void Store(int op)
        {
            memory[op] = accumilator.ToString();
        }

        //ALU
        private void Add(int op) { accumilator += int.Parse(memory[op]); }
        private void Subtract(int op) { accumilator -= int.Parse(memory[op]); }
        private void Divide(int op) { accumilator /= int.Parse(memory[op]); }
        private void Multiply(int op) { accumilator *= int.Parse(memory[op]); }

        //Control Operations
        //using op -1 because after the command runs the pc will be incremented by 1
        private static void Branch(int op) { pc = op - 1; }
        private static void BranchNeg(int op) { if (accumilator < 0) { pc = op - 1; } }
        private static void BranchZero(int op) { if (accumilator == 0) { pc = op - 1; } }
        private static void Halt() { pc = 101; }


        //Debugging Operations
        private static void MemDump()
        {
            Console.WriteLine("\nAccumilator: {0:d2}\nOpcode: {1:d2}\nOperand: {2:d2}\n\nMemory Dump: ", accumilator, opcode, operand);
            for (int i = 0; i < MEM_SIZE; i++)
            {
                Console.WriteLine("{0:d2}: {1}", i, memory[i]);
            }
        }

    }
}

