﻿using System;
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
        public static void DisplayGreeting(this UVSimModel uvSim)
        {
            string greeting = "";

            greeting += "Welcome to JCB's UV Simulator!\n";
            greeting += "---------------------------------------------------------\n\n";

            greeting += "Select Command from the operation list and enter memory location you would like to use.\n\n";
            greeting += "If you would like to run more than one simmulator at a time you can use the launch button in the previous window.\n\n";

            uvSim.OutputTextblock.Text += greeting;
        }

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
            output.Add(new OperationModel { Name = "Branch", OpCode = "40" });
            output.Add(new OperationModel { Name = "BranchNeg", OpCode = "41" });
            output.Add(new OperationModel { Name = "BranchZero", OpCode = "42" });
            output.Add(new OperationModel { Name = "Halt", OpCode = "43" });

            return output;
        }

        public static void RunProgram(this UVSimModel uvSim)
        {
            //Changed so program will run untill a halt command or reaches end of memory 
            while (uvSim.ProgramCounter != -666 && uvSim.ProgramCounter < uvSim.MemorySize)
            {
                uvSim.ProgramCounter++;
                uvSim.RunCommand(uvSim.Memory[uvSim.ProgramCounter - 1]);
            }
            DisplayMemory(uvSim);
            uvSim.ProgramCounter = 0;
        }

        private static void RunCommand(this UVSimModel uvSim, string instruction)
        {
            string operation = instruction.Substring(0, 2);
            string operand = instruction.Substring(2, 2);

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

        public static void DisplayRegisterStats(this UVSimModel uvSim)
        {
            //Jaren Flaker 
            //Todo - Display to output screen after program has finished running
            uvSim.OutputTextblock.Text += $"Accumilator: {uvSim.Accumulator}\n";   
            uvSim.OutputTextblock.Text += $"Program Counter: {uvSim.ProgramCounter}\n";

        }

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
