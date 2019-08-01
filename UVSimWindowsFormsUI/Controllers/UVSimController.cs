using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UVSimWindowsFormsUI.Controllers.InstructionControllers;
using UVSimWindowsFormsUI.Models;

namespace UVSimWindowsFormsUI.Controllers
{
    public static class UVSimController
    {
        // Ben Thornhill
        public static void DisplayGreeting(this UVSimModel uvSim)
        {
            string greeting = "";

            greeting += "Welcome to JCB's UV Simulator!\n";
            greeting += "---------------------------------------------------------\n\n";

            greeting += "Select Command from the operation list and enter memory location you would like to use.\n\n";
            greeting += "If you would like to run more than one simmulator at a time you can use the launch button in the previous window.\n\n";

            uvSim.OutputTextblock.Text += greeting;
        }

        // Jaren Flaker
        public static List<OperationModel> GetAvailableOperations(this UVSimModel uvSim)
        {
            List<OperationModel> output = new List<OperationModel>();

            output.Add(new OperationModel { Name = "Read", OpCode = "10" });
            output.Add(new OperationModel { Name = "Write", OpCode = "11" });
            output.Add(new OperationModel { Name = "Load", OpCode = "20" });
            output.Add(new OperationModel { Name = "Store", OpCode = "21" });
            output.Add(new OperationModel { Name = "Add", OpCode = "30" });
            output.Add(new OperationModel { Name = "Subtract", OpCode = "31" });
            output.Add(new OperationModel { Name = "Divide", OpCode = "32" });
            output.Add(new OperationModel { Name = "Multiply", OpCode = "33" });
            output.Add(new OperationModel { Name = "Remainder", OpCode = "34" });
            output.Add(new OperationModel { Name = "Exponent", OpCode = "35" });
            output.Add(new OperationModel { Name = "Branch", OpCode = "40" });
            output.Add(new OperationModel { Name = "BranchNeg", OpCode = "41" });
            output.Add(new OperationModel { Name = "BranchZero", OpCode = "42" });
            output.Add(new OperationModel { Name = "Halt", OpCode = "43" });

            return output;
        }

        // Ben Thornhill
        public static void RunProgram(this UVSimModel uvSim)
        {
            //Changed so program will run untill a halt command or reaches end of memory 
            while (uvSim.ProgramCounter != -666 && uvSim.ProgramCounter < uvSim.MemorySize)
            {
                string firstWord = uvSim.Memory[uvSim.ProgramCounter];
                string secondWord = uvSim.Memory[uvSim.ProgramCounter + 1];
                string fullInstruction = firstWord + secondWord;

                try
                {
                    uvSim.RunCommand(fullInstruction);
                }
                catch 
                {
                    string firstWordWithoutBreakpoint = firstWord.Substring(0, 2) + "00";
                    uvSim.Memory[uvSim.ProgramCounter] = firstWordWithoutBreakpoint;
                    throw;
                }

                uvSim.ProgramCounter += 2;
            }
        }

        // Ben Thornhill
        private static void RunCommand(this UVSimModel uvSim, string instruction)
        {
            string breakPoint = instruction.Substring(2, 2);
            if (breakPoint == "11")
                throw new Exception("Breakpoint was triggered.\n Please select 'Continue' to resume execution");

            string operation = instruction.Substring(0, 2);
            string operand = instruction.Substring(4, 4);

            switch (operation)
            {
                case "10":
                    uvSim.Read(operand);
                    break;
                case "11":
                    uvSim.Write(operand);
                    break;
                case "20":
                    uvSim.Load(operand);
                    break;
                case "21":
                    uvSim.Store(operand);
                    break;
                case "30":
                    uvSim.Add(operand);
                    break;
                case "31":
                    uvSim.Subtract(operand);
                    break;
                case "32":
                    uvSim.Divide(operand);
                    break;
                case "33":
                    uvSim.Multiply(operand);
                    break;
                case "34":
                    uvSim.Remainder(operand);
                    break;
                case "35":
                    uvSim.Exponent(operand);
                    break;
                case "40":
                    uvSim.Branch(operand);
                    break;
                case "41":
                    uvSim.BranchNeg(operand);
                    break;
                case "42":
                    uvSim.BranchZero(operand);
                    break;
                case "43":
                    uvSim.Halt();
                    break;
            }
        }

        // Cameron Prestera
        public static void DisplayRegisterStats(this UVSimModel uvSim)
        {
            //Jaren Flaker 
            uvSim.OutputTextblock.Text += $"\nAccumilator: {uvSim.Accumulator}\n";   
            uvSim.OutputTextblock.Text += $"\nProgram Counter: {uvSim.ProgramCounter}\n";

        }

        // Cameron Prestera
        public static void DisplayMemory(this UVSimModel uvSim)
        {
            string memory = "";
            int memoryLocation = 0;

            foreach (var word in uvSim.Memory)
            {
                memory += memoryLocation.ToString().PadLeft(3, '0') + " | " + word + "\n";
                memoryLocation++;
            }

            uvSim.MemoryTextblock.Text = memory;
        }
    }
}
